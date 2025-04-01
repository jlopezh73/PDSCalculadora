using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto1PDS.Models;
using Proyecto1PDS.UseCases;

namespace Proyecto1PDS.Pages;

public class OperacionesModel : PageModel
{
    private readonly ILogger<OperacionesModel> _logger;

    [BindProperty()]
    public DatosOperacion datos {get;  set;}
    
    public double resultado {get; set;}

    public OperacionesModel(ILogger<OperacionesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
        _logger.LogInformation("--> Entraron a la página usando GET");        
    }

    public void OnPost()
    {        
        _logger.LogInformation("--> Entraron a la página usando POST");
        if (ModelState.IsValid) {
            RealizadorOperacion ro = new RealizadorOperacion();
            resultado = ro.Ejecutar(datos);        
        } else
            _logger.LogError("--> Modelo inválido");
    }    
}
