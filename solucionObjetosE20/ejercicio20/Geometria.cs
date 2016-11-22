using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;
    }

    class Punto
    {
        private int _x;
        private int _y;

        public int getX()
        {
            return this._x;
        }

        public int getY()
        {
            return this._y;
        }
    }
}
