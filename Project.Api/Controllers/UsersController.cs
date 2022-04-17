using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Interfaces;
using Project.Domain.DTOs.UserDTOs;
using Project.Domain.Helpers.Commons;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Objects and Constructor
        public readonly IUserServices _userServices;
        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        #endregion

        [HttpGet("allUsers")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAll()
        {
            try
            {
                var userlist = await _userServices.GetAll();
                return Ok(userlist);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }

        [Authorize(Roles ="Administrator")]
        [HttpPatch("update")]
        public async Task<ActionResult<Result>> Update([FromForm] UserUpdateDTO userUpdateDTO)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString();
                var response = await _userServices.Update(userUpdateDTO, token);
                return response.HasErrors
                    ? BadRequest(response.Messages)
                    : Ok(response);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Result>> Delete([FromForm] int id)
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString();
                var response = await _userServices.Delete(token);
                return Ok(response);
            }
            catch (Exception result)
            {
                return BadRequest(result.Message);
            }
        }
    }
}