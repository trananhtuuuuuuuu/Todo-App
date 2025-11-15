using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interview.Models {
    [Table("roles")]
    public class Role {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoleId { get; set; }

        public string RoleName { get; set; } = "";
        public string RoleDescription { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public List<Permission> Permissions { get; set; } = new();
        public List<User> Users { get; set; } = new();

        public Role() { }

        public Role(string roleName, string roleDescription)
        {
            RoleName = roleName;
            RoleDescription = roleDescription;
            CreatedDate = DateTime.UtcNow;
            //UpdatedDate = DateTime.UtcNow;
        }
    }
}