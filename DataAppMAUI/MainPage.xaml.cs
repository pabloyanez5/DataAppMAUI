using Android.Widget;
using DataAppMAUI.Interfaces;
using DataAppMAUI.Models;
using DataAppMAUI.Repositories;
using Microsoft.Maui;

namespace DataAppMAUI
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        public List<EstudianteUDLA> estudiantes;

        IEstudianteUDLARepository _repository;

        public MainPage()
        {
            InitializeComponent();
            _repository = new EstudianteUDLAAPIsRepository();
            estudiante = _repository.DevuelveInfoEstudianteUDLA(1);
            estudiantes = _repository.DevuelveListadoEstudianteUDLA();

            BindingContext = estudiante;
        }


/* Cambio no fusionado mediante combinación del proyecto 'DataAppMAUI (net8.0-android)'
Antes:
        private void BotonGuardarEstudiante_Clicked(object sender, EventArgs e)
        {
Después:
        private async Task BotonGuardarEstudiante_ClickedAsync(object sender, EventArgs e)
        {
*/
        private async Task BotonGuardarEstudiante_ClickedAsync(object sender, EventArgs e)
        {
            EstudianteUDLA  estudiante = new EstudianteUDLA
            {
                Id = 10,
                Nombre = "Pablo David Yanez Alvear",
                Carrera = "Ingenieria de Software"
            };
            bool crear_estudiante = _repository.CrearEstudianteUDLA(estudiante);

            
            


        }
    }

}
