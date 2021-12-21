using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab20_1
{
   
class Figures
    {
        // объявление методов класса
        // методы объявляются без ключевого слова static
        // длина окружности
        public double Get_Length(double r)
        {
            double length;
            length = 3.1415 * 2 * r;
            return length;
        }

        // площадь круга
        public double Get_Area(double r)
        {
            double area;
            area = 3.1415 * r * r;
            return area;
        }

        // объем шара
        public double Get_Volume(double r)
        {
            double volume;
            volume = 4.0 / 3.0 * 3.1415 * r * r * r;
            return volume;
        }
    }
}
