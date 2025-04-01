using Proyecto1PDS.Models;

namespace Proyecto1PDS.UseCases;

public class RealizadorOperacion {
    public double Ejecutar(DatosOperacion datos) {
        if (datos.operacion == 1)
            return (datos.op1 + datos.op2)??0;
        else if (datos.operacion == 2)
            return (datos.op1 - datos.op2)??0;
        else if (datos.operacion == 3)
            return (datos.op1 * datos.op2)??0;
        else if (datos.operacion == 4)
            return (datos.op1 / datos.op2)??0;
        else
            return 0;
    }
}