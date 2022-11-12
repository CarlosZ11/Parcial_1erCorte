using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ServicioImpPostgrado : IServicioPostgrado
    {
        List<Postgrado> EstudiantesPostgrado;
        RepositorioPostgrado repositorioPostgrado;

        public ServicioImpPostgrado()
        {
            repositorioPostgrado = new RepositorioPostgrado();
            EstudiantesPostgrado = repositorioPostgrado.ObtenerTodoPostgrado();
        }


        public List<Postgrado> ObtenerTodoPostgrado()
        {
            return EstudiantesPostgrado;
        }
    }
}