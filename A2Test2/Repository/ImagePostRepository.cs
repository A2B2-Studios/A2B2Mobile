using A2Test2.DTOs.Comments;
using A2Test2.DTOs.Posts;
using A2Test2.DTOs;
using A2Test2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Test2.Repository
{
    public class ImagePostRepository : IImagePostRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/posts";

        public ImagePostRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<string> CreatePost(ImagePostDTO post)
        {
            var response = await httpService.Post(url, post);
            return await response.GetBody();

        }
        public async Task<ImagePostDTO> GetPostById(int id)
        {
            return await httpService.GetHelper<ImagePostDTO>($"{url}/{id}");

        }

        public async Task<PaginatedResponse<List<ImagePostDTO>>> GetImagePostList(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<ImagePostDTO>>($"{url}/list", paginationDTO);
        }

        public async Task<CommentDTO> PostComment(CommentDTO comment)
        {
            var response = await httpService.Post<CommentDTO, CommentDTO>($"{url}/comments", comment);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<ReplyCommentDTO> PostReply(ReplyCommentDTO reply)
        {
            var response = await httpService.Post<ReplyCommentDTO, ReplyCommentDTO>($"{url}/comments/reply", reply);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task DeleteComment(int id)
        {
            var response = await httpService.Delete($"{url}/comments/{id}");

        }

    }
}
