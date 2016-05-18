namespace DEX.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Company Company { get; set; }
    }
}