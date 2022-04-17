
namespace Project.Domain.DTOs.CommentsDTOs
{
    public class CommentUpdateDTO
    {
        /// <summary>
        /// Id del usuario a modificar
        /// </summary>
        public int? UserId { get; set; }
          /// <summary>
        /// Id de la Noticia a modificar
        /// </summary>
        public int? NewId { get; set; }
        /// <summary>
        /// Comentario a modificar
        /// </summary>
        public string Body { get; set; }
    }
}
