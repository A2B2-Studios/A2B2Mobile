using A2Test2.DTOs;

namespace A2Test2.Repository
{
    public interface IUserRepository
    {
        Task AssignRole(EditRoleDTO editRole);
        Task<List<RoleDTO>> GetRoles();
        Task<List<UserCommentDTO>> GetUserCommentList(string id);
        Task<PaginatedResponse<List<UserDTO>>> GetUserList(PaginationDTO paginationDTO);
        Task<UsernameDTO> GetUsernameById(string id);
        Task<List<UserPostsDTO>> GetUserPostList(string id);
        Task<UserProfileDTO> GetUserProfileById(string id);
        Task<UserProfileDTO> GetUserProfileByName(string name);
        Task RemoveRole(EditRoleDTO editRole);
    }
}