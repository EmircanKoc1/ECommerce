namespace CoreLayer.DTOs
{
    public class ClaimDto : BaseDto
    {

        public string ClaimType { get; set; }
        public string ClaimName { get; set; }


        public ICollection<UserDto> Users { get; set; }
    }
}
