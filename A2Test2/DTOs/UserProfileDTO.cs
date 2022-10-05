using A2Test2.DTOs.Bounty;
using A2Test2.DTOs.Posts;

namespace A2Test2.DTOs
{
    public class UserProfileDTO
    {
        public string Username { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastActive { get; set; }
        public List<BountySubmissionDTO> BountySubmissions { get; set; } = new List<BountySubmissionDTO>();
        public List<string> Roles { get; set; } = new List<string>();
        public UserDTO UsernameStyle { get; set; } = new UserDTO();
        public List<ImagePostDTO> Posts { get; set; } = new List<ImagePostDTO>();

    }
}
