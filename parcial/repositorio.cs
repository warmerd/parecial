using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
   public sealed class repositorio
    {
        public List<repositorio> opcion_modoD { get; set; } = new List<repositorio>();
        public static repositorio intacia { get; } = new repositorio();

        private repositorio()
        {

        }
    }
}
