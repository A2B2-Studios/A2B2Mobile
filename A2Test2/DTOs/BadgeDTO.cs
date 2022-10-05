namespace A2Test2.DTOs
{
    public class BadgeDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public List<UserDTO> Users { get; set; }
    }
}
