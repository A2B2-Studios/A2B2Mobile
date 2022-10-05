using A2Test2.DTOs;
using A2Test2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Test2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/users";

        public UserRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<UserProfileDTO> GetUserProfileById(string id)
        {
            var response = await httpService.GetHelper<UserProfileDTO>($"{url}/profile/{id}");
            return response;
        }

        public async Task<UserProfileDTO> GetUserProfileByName(string name)
        {
            var response = await httpService.GetHelper<UserProfileDTO>($"{url}/profile/{name}");
            return response;
        }

        public async Task<UsernameDTO> GetUsernameById(string id)
        {
            return await httpService.GetHelper<UsernameDTO>($"{url}/{id}/name");
        }

        public async Task<List<UserPostsDTO>> GetUserPostList(string id)
        {
            return await httpService.GetHelper<List<UserPostsDTO>>($"{url}/{id}/posts");
        }

        public async Task<List<UserCommentDTO>> GetUserCommentList(string id)
        {
            return await httpService.GetHelper<List<UserCommentDTO>>($"{url}/{id}/comments");
        }

        public async Task<PaginatedResponse<List<UserDTO>>> GetUserList(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<UserDTO>>($"{url}/userList", paginationDTO);
        }

        public async Task<List<RoleDTO>> GetRoles()
        {
            return await httpService.GetHelper<List<RoleDTO>>($"{url}/roles");
        }

        public async Task AssignRole(EditRoleDTO editRole)
        {
            var response = await httpService.Post($"{url}/assignRole", editRole);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }
        public async Task RemoveRole(EditRoleDTO editRole)
        {
            var response = await httpService.Post($"{url}/removeRole", editRole);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

        }
    }
}
