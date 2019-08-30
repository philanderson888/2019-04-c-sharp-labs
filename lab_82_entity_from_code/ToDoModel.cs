namespace lab_82_entity_from_code
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDoModel : DbContext
    {
        public ToDoModel()
            : base("name=ToDoModel2")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.Category);
        }
    }
}
