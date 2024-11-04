using Refuerzo2024.View.asignaturas;
using Refuerzo2024.View.Estudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refuerzo2024.Controller.Asignaturas
{
    internal class controllerAsignaturas
    {
        AsignaturasView objAsignaturas;

        public controllerAsignaturas(AsignaturasView objAsignaturas)
        {
            this.objAsignaturas = objAsignaturas;
            //Manejar eventos que surjan en la vista
            objAsignaturas.Load += new EventHandler(CargaInicial);
            objAsignaturas.btnAgregar.Click += new EventHandler(RegistrarEstudiante);
            objAsignaturas.dgvEstudiantes.CellClick += new DataGridViewCellEventHandler(SeleccionarDato);
            objAsignaturas.btnActualizar.Click += new EventHandler(ActualizarEstudiante);
            objAsignaturas.btnEliminar.Click += new EventHandler(EliminarEstudiante);
            objAsignaturas.btnBuscar.Click += new EventHandler(BuscarEstudiante);
        }
    }
}
