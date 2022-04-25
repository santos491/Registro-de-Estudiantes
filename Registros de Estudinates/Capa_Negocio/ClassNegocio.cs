using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassDatos objd = new ClassDatos();

        public DataTable N_listar_Estudiantes()
        {
            return objd.D_listar_Estudiantes();
        }

        public DataTable N_buscar_Estudiantes(ClassEntidad obje)
        {
            return objd.D_buscar_Estudiantes(obje);
        }

        public String N_mantenimiento_Estudiantes(ClassEntidad obje)
        {
            return objd.D_mantenimiento_Estudiantes(obje);
        }
    }
}
