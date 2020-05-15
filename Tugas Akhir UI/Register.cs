namespace Tugas_Akhir_UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Register")]
    public partial class Register
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(50)]
        public string Jenis_Kelamin { get; set; }

        [Required]
        [StringLength(50)]
        public string Usia { get; set; }

        [Required]
        [StringLength(50)]
        public string Tinggi_Badan { get; set; }

        [Required]
        [StringLength(50)]
        public string Berat_Badan { get; set; }
    }
}
