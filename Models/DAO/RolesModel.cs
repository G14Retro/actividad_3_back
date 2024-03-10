using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace actividad_3_back.Models.DAO
{
    public class RolesModel
    {
        public Guid IdRoles { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public virtual ICollection<Users_Has_RolesModel>? Users_Has_Roles { get; set; }
        public virtual ICollection<UserModel>? Users { get; private set; }
    }
}
