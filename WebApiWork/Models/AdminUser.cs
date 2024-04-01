namespace WebApiWork.Models
{
    public class AdminUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AddDate { get; set; }
    }
}
