using Proyecto1PDS.Models;

namespace Proyecto1PDS.UseCases;

public class RealizarOperacion {
    public double Ejecutar(DatosOperacion datos) {
        if (datos.operacion == 1)
            return datos.op1 + datos.op2;
        else if (datos.operacion == 2)
            return datos.op1 - datos.op2;
        else if (datos.operacion == 3)
            return datos.op1 * datos.op2;
        else if (datos.operacion == 4)
            return datos.op1 / datos.op2;
        else
            return 0;
    }
}