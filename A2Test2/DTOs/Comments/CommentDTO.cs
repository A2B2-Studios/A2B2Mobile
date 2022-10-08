using System.ComponentModel.DataAnnotations;

namespace A2Test2.DTOs.Comments
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public DateTime PostTime
        {
            get;set;
        }
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(2000, ErrorMessage = "Your comment cannot exceed 2000 characters.")]
        public string CommentText { get; set; }
        public UserDTO Commenter { get; set; }
        public int ParentPostId { get; set; }
        public List<ReplyCommentDTO> ReplyComments { get; set; } = new List<ReplyCommentDTO>();
    }
}
