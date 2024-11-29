using DataAppMAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMAUI.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        List<EstudianteUDLA> DevuelveListadoEstudianteUDLA();
        EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean EliminarEstudianteUDLA(int Id);

    }
}
