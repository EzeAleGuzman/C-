using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; } 

        public float Precio { get; set;}

        private int codMarca;

        public int CodMarca
        { get { return codMarca;  }
          set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }  
        }
    }
}
