using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace actividad_3_back.Models.DAO
{
    public class UserModel
    {
        public Guid IdUsers { get; set; }
        public string Name { get; set; }
        public string FirtsName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public virtual ICollection<Users_Has_RolesModel>? Users_Has_Roles{ get; set; }
        public virtual ICollection<RolesModel>? Roles { get; set; }
    }
}
