using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCTareaa.Models
{
    public class DatosUsuario
    {
        [Required]
        public long Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [Range(15,99)]
        public int Edad { get; set; }
        public long Telefono { get; set; }
        [Display(Name = "Correo electrónico")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Genero { get; set; }
        public string Puesto { get; set; }
        [Display(Name = "Foto")]
        [Required]
        public HttpPostedFileBase foto { get; set; }
        [Display(Name = "Currículum")]
        [Required]
        public HttpPostedFileBase curriculum { get; set; }
        
    }

    public enum Generos
    {
        Masculino,
        Femenino
    }

    public enum Puestos
    {
        [Display(Name = "GERENTE DE T.I")]
        GerenteTI,

        [Display(Name = "GERENTE DE INFRAESTRUCTURA T.I")]
        GerenteInfraTI,

        [Display(Name = "GERENTE DE PROYECTOS DE T.I")]
        GerenteProyecTI,

        [Display(Name = "GERENTE DE DESARROLLO DE T.I")]
        GerenteDevTI,

        [Display(Name = "GERENTE DE SEGURIDAD DE T.I")]
        GerenteSegurTI,

        [Display(Name = "ARQUITECTO ADMINISTRADOR Y ANALISTA DE REDES")]
        ArquitectoAdminAnalsRedes,

        [Display(Name = "ADMINISTRADOR DE BASE DE DATOS")]
        AdministradorDB,

        [Display(Name = "GERENTE DE OPERACIONES")]
        GerenteOperaciones,

        [Display(Name = "ANALISTA DE INTELIGENCIA DE NEGOCIO")]
        AnalistaIntelNegocio,

        [Display(Name = "ARQUITECTO DE SISTEMAS DE INFORMACION")]
        ArquitectoSistemInfo,

        [Display(Name = "ARQUITECTURA DE SOFTWARE")]
        ArquitecturaSoft,

        [Display(Name = "ANALISTA DE CALIDAD DE SOFTWARE")]
        AnalistaCalidSoft,

        [Display(Name = "DIRECTOR DE SOPORTE TECNICO")]
        DirectorSoporTecnico,

        [Display(Name = "ANALISTA DE SEGURIDAD INTERNA Y RIESGOS DE T.I")]
        AnalistaSegurInterRiesgTI,

        [Display(Name = "DIRECTOR DE GESTION INTERNA DE T.I")]
        DirectorGestInterTI
    }
}