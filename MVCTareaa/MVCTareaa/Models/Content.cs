using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCTareaa.Models
{
    public class Content
    {
        [Required]
        public string Contenido { get; set; }
    }

    public enum Contenidos
    {
        Noticias,
        Música,
        Películas
    }
}