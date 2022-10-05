using A2Test2.DTOs.Comments;
using A2Test2.DTOs.Posts;
using A2Test2.DTOs;

namespace A2Test2.Repository
{
    public interface IImagePostRepository
    {
        Task<string> CreatePost(ImagePostDTO post);
        Task DeleteComment(int id);
        Task<PaginatedResponse<List<ImagePostDTO>>> GetImagePostList(PaginationDTO paginationDTO);
        Task<ImagePostDTO> GetPostById(int id);
        Task<CommentDTO> PostComment(CommentDTO comment);
        Task<ReplyCommentDTO> PostReply(ReplyCommentDTO reply);
    }
}