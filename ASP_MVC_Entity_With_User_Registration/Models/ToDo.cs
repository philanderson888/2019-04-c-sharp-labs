using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_MVC_Entity_With_User_Registration.Models
{


    public partial class Category
    {
        public Category()
        {
            Task2s = new HashSet<Task2>();
        }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<Task2> Task2s { get; set; }
    }




    public partial class User
    {
        public User()
        {
            Task2s = new HashSet<Task2>();
        }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public virtual ICollection<Task2> Task2s { get; set; }

    }


    public partial class Task2
    {
        public int Task2ID { get; set; }

        [StringLength(50)]
        public string TaskDescription { get; set; }

        public bool? Done { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStarted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCompleted { get; set; }

        public int? Category { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Deadline { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual User User { get; set; }
    }





    public partial class ToDoModel : DbContext
    {
        public ToDoModel()
            : base()
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task2> Task2s { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Task2s)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.Category);
        }
    }

}