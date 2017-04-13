using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace AutorizationTest.Models
{
   
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Не указано название.")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Не указано описание.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Не указана цена.")]
        //[Range(0.01, double.MaxValue, ErrorMessage = "Цена не может иметь отрицательное значение.")]
        //[DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = false)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        //[DisplayFormat(DataFormatString = "{0:C0.00}")]
        [DataType(DataType.Currency)]
      
        public decimal Price { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Не указана категория.")]
        public string Category { get; set; }
    }
}