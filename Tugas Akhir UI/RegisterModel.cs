namespace Tugas_Akhir_UI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RegisterModel : DbContext
    {
        public RegisterModel()
            : base("name=RegisterModel")
        {
        }

        public virtual DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
