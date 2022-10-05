namespace A2Test2.DTOs.Bounty
{
    public class SubBountyDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public BountyDTO Bounty { get; set; }
        public int Count { get; }
    }
}
