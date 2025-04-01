namespace Proyecto1PDS.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
public class DatosOperacion {
    [Required(ErrorMessage="* El operando 1 es obligatorio")]
    [Display(Name="Valor Operando 1")]
    public double? op1 {get; set;}
    
    [Required(ErrorMessage="* El operando 2 es obligatorio")]
    [Display(Name="Valor Operando 2")]
    public double? op2 {get; set;}
    public int operacion {get; set;}
}