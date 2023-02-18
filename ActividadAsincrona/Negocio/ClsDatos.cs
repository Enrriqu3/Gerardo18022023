using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ActividadAsincrona.Entidades;

namespace ActividadAsincrona.Negocio
{
    public class ClsDatos
    {
        public int Conteoo(Datos datos)
        {
            datos.total = datos.palabra.Length;
            return datos.total;

        }

    }
}