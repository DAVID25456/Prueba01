namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Contraseña { get; set; }

        [Required]
        [StringLength(50)]
        public string DNI { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(1)]
        public string Genero { get; set; }

        [StringLength(50)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }
    }
}
