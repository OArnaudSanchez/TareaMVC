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
        [Required(ErrorMessage ="Inserte su Cédula correctamente")]
        public long Cedula { get; set; }
        [Required(ErrorMessage = "Inserte su Nombre correctamente")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Inserte su Apellido correctamente")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Inserte su Edad correctamente")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Inserte su Telefono correctamente")]
        public long Telefono { get; set; }
        [Display(Name = "Correo electrónico")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [StringLength(100, ErrorMessage = "Longitud máxima 100")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Inserte su Email correctamente")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Inserte su Genero")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Inserte su puesto a aplicar")]
        public string Puesto { get; set; }
        [Display(Name = "Foto")]
        [Required(ErrorMessage = "Inserte su Foto correctamente")]
        public HttpPostedFileBase foto { get; set; }
        public string curriculum { get; set; }
        
    }

    public enum Generos
    {
        Masculino,
        Femenino
    }

    public enum Puestos
    {
        [Description("GERENTE DE T.I")]
        GerenteTI,
        [Description("GERENTE DE INFRAESTRUCTURA T.I")]
        GerenteInfraTI,
        [Description("GERENTE DE PROYECTOS DE T.I")]
        GerenteProyecTI,
        [Description("GERENTE DE DESARROLLO DE T.I")]
        GerenteDevTI,
        [Description("GERENTE DE SEGURIDAD DE T.I")]
        GerenteSegurTI,
        [Description("ARQUITECTO ADMINISTRADOR Y ANALISTA DE REDES")]
        ArquitectoAdminAnalsRedes,
        [Description("ADMINISTRADOR DE BASE DE DATOS")]
        AdministradorDB,
        [Description("GERENTE DE OPERACIONES")]
        GerenteOperaciones,
        [Description("ANALISTA DE INTELIGENCIA DE NEGOCIO")]
        AnalistaIntelNegocio,
        [Description("ARQUITECTO DE SISTEMAS DE INFORMACION")]
        ArquitectoSistemInfo,
        [Description("ARQUITECTURA DE SOFTWARE")]
        ArquitecturaSoft,
        [Description("ANALISTA DE CALIDAD DE SOFTWARE")]
        AnalistaCalidSoft,
        [Description("DIRECTOR DE SOPORTE TECNICO")]
        DirectorSoporTecnico,
        [Description("ANALISTA DE SEGURIDAD INTERNA Y RIESGOS DE T.I")]
        AnalistaSegurInterRiesgTI,
        [Description("DIRECTOR DE GESTION INTERNA DE T.I")]
        DirectorGestInterTI
    }
}