using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interview.Models {
    [Table("users")]
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string Gender { get; set; } = "";

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // navigation
        public List<Expense> Expenses { get; set; } = new();
        
        public long RoleId { get; set; }
        public Role? Role { get; set; }

        public User() { }

        public User(string name, string username, string password, string email, string phone, string address, string gender)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            Phone = phone;
            Address = address;
            Gender = gender;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}