namespace A2Test2.DTOs.Posts
{
    public class ImagePostDTO: PostDTO
    {
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public UsernameDTO UsernameDisplay { get; set; }
        public int CommentCount { get; set; }

        public string GetImageThumbnail()
        {
            string imageURL = ImageURL;
            string thumburl = imageURL.Replace(".jpg", "-thumb.jpg");

            return thumburl;
        }
    }
}
