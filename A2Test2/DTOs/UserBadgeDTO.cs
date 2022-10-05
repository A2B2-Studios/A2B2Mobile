namespace A2Test2.DTOs
{
    public class UserBadgeDTO
    {
        public string ApplicationUserId { get; set; }
        public UserDTO User { get; set; }
        public int BadgeId { get; set; }
        public BadgeDTO Badge { get; set; }
        public DateTime AwardedDate { get; set; }
    }
}
