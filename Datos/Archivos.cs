using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivos
    {
        protected string ruta;

        public Archivos()
        {

        }

        public Archivos(String fileName)
        {
            ruta = fileName;
        }
    }
}
