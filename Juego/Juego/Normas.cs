﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    public class Normas
    {
        public bool EstadoInicial;

        public static bool IsAlive(bool EstadoInnicial, int celulasVecinas)
        {
            bool estado = EstadoInnicial;
            if ((!EstadoInnicial && celulasVecinas == 3) || (EstadoInnicial && celulasVecinas == 2))
            {
                estado = true;
            }
            else estado = false;           
            return estado;
        }
    }
}
