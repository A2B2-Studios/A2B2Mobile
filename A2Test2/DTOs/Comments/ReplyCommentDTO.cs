namespace A2Test2.DTOs.Comments
{
    public class ReplyCommentDTO: CommentDTO
    {
        public CommentDTO ParentComment { get; set; }
        public int Level { get; set; }
    }
}
