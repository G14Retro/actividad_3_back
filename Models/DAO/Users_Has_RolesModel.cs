using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace actividad_3_back.Models.DAO
{
    public class Users_Has_RolesModel
    {   
        public Guid IdUser { get; set; }
        public Guid IdRol { get; set; }

        public virtual UserModel? User { get; set; }
        public virtual RolesModel? Roles { get; set; }
    }
}
