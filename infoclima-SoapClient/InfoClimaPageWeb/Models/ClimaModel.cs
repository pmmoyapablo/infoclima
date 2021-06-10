using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InfoClimaPageWeb.Models
{
    public class ClimaModel
    {
        //ID
        [Key]
        public int Id { get; set; }
       
        [DataType(DataType.Text)]
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
       // [DataType(DataType.PostalCode)]
        [Display(Name = "Temperatura")]
        public int Temperatura { get; set; }

        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        //[DataType(DataType.PostalCode)]
        [Display(Name = "Viento")]
        public int Viento { get; set; }

        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        //[DataType(DataType.Currency)]
        [Display(Name = "Humedad")]
        public decimal Humedad { get; set; }
       
        [DataType(DataType.Text)]
        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public string Ciudad { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "Debe asignar un valor a {0}")]
        public DateTime Fecha { get; set; }
  }
}