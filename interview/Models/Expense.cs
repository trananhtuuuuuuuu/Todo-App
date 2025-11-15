using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace interview.Models {
    [Table("expenses")]
    public class Expense {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Category { get; set; } = "";
        public string PayMethod { get; set; } = "";
        public string? Note { get; set; }
        public string? Address { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public DateTime UpdatedDate { get; set; }

        // FK + navigation to User
        public long? UserId { get; set; }            // FK
        public User? User { get; set; }              // navigation property

        public Expense() { }

        public Expense(string category, string payMethod, string? note, string? address, decimal amount, DateTime date)
        {
            Category = category;
            PayMethod = payMethod;
            Note = note;
            Address = address;
            Amount = amount;
            Date = date;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}