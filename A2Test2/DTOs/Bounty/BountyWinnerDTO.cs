namespace A2Test2.DTOs.Bounty
{
    public class BountyWinnerDTO
    {
        public int BountyId { get; set; }
        public BountyDTO Bounty { get; set; }
        public string UserId { get; set; }
        public UserDTO User { get; set; }
        public int BountySubmissionId { get; set; }
        public BountySubmissionDTO BountySubmission { get; set; }

    }
}
