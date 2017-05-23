using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaAspNet.Models
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {get;set;}
        public string ImagenUrl { get; set; }
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public virtual Genero Genero { get; set; }
    }
}