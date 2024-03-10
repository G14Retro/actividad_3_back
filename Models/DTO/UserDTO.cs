namespace actividad_3_back.Models.DTO
{
    public class UserDTO
    {
        public Guid? IdUser { get; set; }
        public string Name { get; set; }
        public string FirtsName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<object> Roles { get; set; }
    }
}
