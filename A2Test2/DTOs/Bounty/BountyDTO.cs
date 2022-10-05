using System.ComponentModel.DataAnnotations;

namespace A2Test2.DTOs.Bounty
{
    public class BountyDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; }
        public string Rules { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalid start date")]
        public DateTime StartDate {
            get;set;
        }
        [Required(ErrorMessage = "You must pick an end date.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid end date")]
        public DateTime EndDate
        {
            get;set;
        }
        public string PrizeInfo { get; set; }
        public string WinnerUserId { get; set; }
        public string BountyImageUrl { get; set; }
        public bool UseSubBounty { get; set; }
        public bool OneSubmissionPerUser { get; set; }
        public bool OneSubmissionPerSubBounty { get; set; }

        public List<BountySubmissionDTO> Submissions { get; set; } = new List<BountySubmissionDTO>();
        public List<SubBountyDTO> SubBounties { get; set; } = new List<SubBountyDTO>();
        public List<BountyWinnerDTO> Winners { get; set; } = new List<BountyWinnerDTO>();
    }
}
