using A2Test2.DTOs.Comments;

namespace A2Test2.DTOs.Posts
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PostTime
        {
            get;set;
        }
        public UserDTO User { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
