using ExpenseTracker.CustomValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Category
    {
        public Category()
        {
            this.Expenses = new List<Expense>();
        }
        public int CategoryId { get; set; }
        [Required, StringLength(60), Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        //Navigation
        public virtual ICollection<Expense> Expenses { get; set; }
    }
    public class Expense
    {
        [Key]
        public int ItemId { get; set; }
        [Required, StringLength(60), Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [CustomExpenseDate(ErrorMessage = "Expense Date can't be greater than to Today's Date.")]
        [Required, Display(Name = "Expense Date")]
        public DateTime ExpenseDate { get; set; } = DateTime.Now;
        //FK
        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        //Navigation
        public virtual Category Category { get; set; }
    }
    public class ExpenseDBContext : DbContext
    {
        public ExpenseDBContext(DbContextOptions<ExpenseDBContext> options) : base(options)
        {

        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>(entity => {
                entity.HasIndex(e => e.CategoryName).IsUnique();
            });
        }
    }
}
