using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project.Api.Controllers;
using Project.Core.Interfaces;
using Project.Core.Services;
using Project.Domain.DTOs.MembersDTOs;
using Project.Domain.Entities;
using Project.Domain.Helpers.Pagination;
using Project.Infrastucture.Data;
using Project.Infrastucture.Interfaces;
using Project.Infrastucture.UnitOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Test.Helper;
using Xunit;

namespace Test.UnitTest
{
    [TestClass]
    public class MemberControllersTest : TestsContext
    {
        #region TestInit and Injections
        private ApplicationDbContext _context;
        private Mock<IContactsServices> _contactsServicesMock = new();
        private IMemberServices memberServices;
        private IUnitOfWork unitOfWork;
        private IUriService uriService;
        private IImageService imageService;
        // private IMailService mailService;
        // private IOrganizationsServices organizationsServices;
        private IConfiguration configurations;

        [TestInitialize]
        public void Init()
        {
            var configcollection = new Dictionary<string, string>()
             {
              
                 {"Welcomesubject","Bienvenido" },
                 {"WelcomeMessage","Usted ha sido registrado exitosamente en nuestra plataforma." },
                 {"ContactMessage","Gracias por contactarnos" },
                 {"ContactBodyMessage","Nuestro equipo se va a comunicar a la brevedad" }
             };
            configurations = new ConfigurationBuilder()
                .AddInMemoryCollection(configcollection)
                .Build();

            _context = GetTestContext(Guid.NewGuid().ToString());
            unitOfWork = new UnitOfWork(_context);
            imageService = new ImageService();
            uriService = new UriService("http://testUriBase");
            // organizationsServices = new OrganizationsServices(unitOfWork, imageService);
            // mailService = new SendGridMailService(configurations, organizationsServices);
            memberServices = new MemberServices(unitOfWork, imageService, uriService);
            SeedMember(_context);
        }
        #endregion

        [TestMethod]
        public async Task GetAll_ShouldReturn_10ItemsPerPage()
        {
            //Arrange
            Init();

            var httpContext = new DefaultHttpContext();
            httpContext.Request.Path = "/testUri";

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };

            var controller = new MemberController(memberServices);
            controller.ControllerContext = controllerContext;

            //Act

            var response = await controller.GetAll(1);
            var expected = (ObjectResult)response.Result;

            //Assert
            Xunit.Assert.Equal(200, expected.StatusCode);
            Xunit.Assert.IsType<PaginationDTO<MembersDTO>>(expected.Value);
        }

        [TestMethod]
        public async Task Delete_ShouldReturn_MemberOk()
        {
            //Arrange
            Init();
            var controller = new MemberController(memberServices);

            //Act
            var response = await controller.Delete(1);
            var expected = response as OkObjectResult;
            //Assert
            Xunit.Assert.NotNull(expected);
            Xunit.Assert.Equal(200, expected.StatusCode);
        }
        [TestMethod]
        public async Task Update_ShouldReturnOk_WhenUpdate()
        {
            //Assert
            Init();

            var controller = new MemberController(memberServices);
            var newUpdaMemebr = new MemberUpdateDTO()
            {
                Id = 1,
                Name = "TestPrueba",
                FacebookUrl = "https://www.facebook.com/",
                InstagramUrl = "https://www.facebook.com/",
                LinkedinUrl = "https://www.facebook.com/",
                Image = null,
                Description = "TeteandoMenber"
            };

            //Act
            var response = await controller.Update(newUpdaMemebr);
            var expected = (ObjectResult)response.Result;

            //Assert
            Xunit.Assert.Equal(200, expected.StatusCode);

        }

        public IFormFile CreateImage()
        {
            var stream = File.OpenRead(@"..\..\..\Image\Captura1.PNG");
            var image = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
            {
                Headers = new HeaderDictionary(),
                //ContentDisposition = "from-data; name=\"Image\"; flilename=\"Alkemy.png\"",
                ContentType = "image/png"
            };
            return image;
        }
       

        [TestMethod]
        public async Task Insert_ShouldReturnOk_WhenInserted()
        {
            //Assert
            Init();
            var httpContext = new DefaultHttpContext();
            httpContext.Request.Path = "/testUri";

            var controllerContext = new ControllerContext()
            {
                HttpContext = httpContext,
            };


            var controller = new MemberController(memberServices);
            controller.ControllerContext = controllerContext;

            var newInsertMember = new MemberInsertDTO()
            {
                Name = "TestPrueba",
                FacebookUrl = "https://www.facebook.com/",
                InstagramUrl = "https://www.facebook.com/",
                LinkedinUrl = "https://www.facebook.com/",
                Image = CreateImage(),
                Description = "TeteandoMenber"
            };

            //Act
            var response = await controller.Post(newInsertMember);
            var castedExpected = response as OkObjectResult;

            //Assert
            Xunit.Assert.NotNull(castedExpected);
            Xunit.Assert.Equal(200, castedExpected.StatusCode);

        }

        private void SeedMember(ApplicationDbContext context)
        {
            for (int i = 1; i < 11; i++)
            {
                var member = new Member
                {
                    Name = "TestPrueba",
                    FacebookUrl = "UrlFace",
                    InstagramUrl = "UrlInsta",
                    LinkedinUrl = "UrlLike",
                    Image = "img/",
                    Description = "TeteandoMenber"
                };

                context.Add(member);
            }
            context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
