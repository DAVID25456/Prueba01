namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Clases
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;

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


        //Metodos de la clase Usuario

        //Metodo que verifica si el usuario existe

        public bool VerificarUsuario(string email, string contraseña)
        {
            //Definir el origen de fuente de datos
            using (var bd = new Model1())
            {
                var usuario = bd.Usuario.FirstOrDefault(u => u.Email == email && u.Contraseña == contraseña);
                return usuario != null; //Si existe retorna TRUE, caso contrario FALSE
            }
        }
    }
}
