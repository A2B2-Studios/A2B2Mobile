using System.ComponentModel.DataAnnotations;

namespace A2Test2.DTOs.Bounty
{
    public class BountySubmissionDTO
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [Required]
        [StringLength(128, ErrorMessage = "Title cannot exceed 128 characters.")]
        public string Title { get; set; }
        [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters.")]
        public string Description { get; set; }
        [Required]
        [Range(1, 2, ErrorMessage = "You must choose.")]
        public int Type { get; set; }
        public string ImageUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public DateTime CreatedDate
        {
            get;set;
        }
        public BountyDTO Bounty { get; set; }
        public int SubBountyId { get; set; }

        public string GetImageThumbnail()
        {
            string imageURL = ImageUrl;
            string thumburl = imageURL.Replace(".jpg", "-thumb.jpg");

            return thumburl;
        }

    }
}
