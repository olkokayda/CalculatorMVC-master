using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.WebPages.Html;

namespace CalculatorMVC.Models
{
    public class Calculator
    {
        [Display(Name ="First number")]
        [Required]
        [Range(1, 100, ErrorMessage = "This calculator is retarded and can accept only positive numbers.")]
        public int? Number1 { get; set; }

        [Display(Name ="Second number")]
        [Required]
        [Range(1, 100, ErrorMessage = "This calculator is retarded and can accept only positive numbers.")]
        public int? Number2 { get; set; }

        public double? Result { get; set; }
        public string Operation { get; set; }
        public List<SelectListItem> OperationsList { get; set; }

        public Calculator()
        {
            OperationsList = new List<SelectListItem>
            {
               new SelectListItem { Text = "Add", Value = "+", Selected = true },
               new SelectListItem { Text = "Subtract", Value = "-", Selected = true },
               new SelectListItem { Text = "Multiply", Value = "*", Selected = true },
               new SelectListItem { Text = "Divide", Value = "/", Selected = true },
            };
        }

        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    Result = (double)Number1 / (double)Number2;
                    break;
            }
        }
    }
}