﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Logica
{
    public interface IServicioPregrado
    {
        List<Pregrado> ObtenerTodoPregrado();
    }
}