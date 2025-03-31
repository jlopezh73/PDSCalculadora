using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto1PDS.Pages;

public class OperacionesModel : PageModel
{
    private readonly ILogger<OperacionesModel> _logger;

    [BindProperty(SupportsGet=true)]
    public double op1 {get;  set;}

    [BindProperty(SupportsGet=true)]
    public double op2 {get; set;}

    [BindProperty(SupportsGet=true)]
    public int operacion {get; set;}

    
    public double resultado {get; set;}

    public OperacionesModel(ILogger<OperacionesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
        _logger.LogInformation("--> Entraron a la página");
        resultado = Calcular(op1, op2, operacion);
    }

    private double Calcular(double xop1, double xop2, int xoperacion) {
        if (xoperacion == 1)
            return xop1 + xop2;
        else if (xoperacion == 2)
            return xop1 - xop2;
        else if (xoperacion == 3)
            return xop1 * xop2;
        else if (xoperacion == 4)
            return xop1 / xop2;
        else
            return 0;
    }
}
