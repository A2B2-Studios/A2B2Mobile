namespace A2Test2.DTOs.Comments
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public DateTime PostTime
        {
            get;set;
        }
        public string CommentText { get; set; }
        public UserDTO Commenter { get; set; }
        public int ParentPostId { get; set; }
        public List<ReplyCommentDTO> ReplyComments { get; set; } = new List<ReplyCommentDTO>();
    }
}
