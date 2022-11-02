using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_I.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string nombres { get; set; }
        [MaxLength(100)]
        public string apellidos { get; set; }

        [MaxLength(20)]
        public int telefono { get; set; }
        [MaxLength(20)]
        public int edad { get; set; }

        [MaxLength(100)]
        public string pais { get; set; }

        [MaxLength(20)]
        public string nota { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
    }
}
