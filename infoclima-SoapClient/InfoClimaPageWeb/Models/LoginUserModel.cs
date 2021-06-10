using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InfoClimaPageWeb.Models
{
    public class LoginUserModel
    {
        //ID
        [Key]
        public int id { get; set; }
        //Usuario
        [DataType(DataType.Text)]
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public string username { get; set; }
        //Clave
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public string key { get; set; }
        //Rol
        [DataType(DataType.Text)]
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public string description { get; set; }
        public bool isAuth { get; set; }
    }
}