using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab20_1
{
    
    
    public partial class Form1 : Form
    {
        private object label4;
        private object label3;
        private object label2;

        // объявление типа делегата CalcFigure
        delegate double CalcFigure(double r);

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // объявление статических методов в классе
        // длина окружности
        public static double Get_Length(double r)
        {
            double length;
            length = 2 * 3.1415 * r;
            return length;
        }

        // площадь круга
        public static double Get_Area(double r)
        {
            double area;
            area = 3.1415 * r * r;
            return area;
        }

        // объем шара
        public static double Get_Volume(double r)
        {
            double volume;
            volume = 3.1415 * r * r * r * 4.0 / 3.0;
            return volume;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius, length, area, volume;


            radius = Convert.ToDouble(Console.ReadLine());

            CalcFigure CF = Get_Length;
            length = CF(radius); // 1. Вызов метода Get_Length()

            CF = Get_Area;
            area = CF(radius); // 2. Вызов метода Get_Area()

            CF = Get_Volume;
            volume = CF(radius); // 3. Вызов метода Get_Volume()

            // вывод результата на форму
            label2 = "Длина окружности = " + length.ToString();
            label3 = "Площадь круга = " + area.ToString();
            label4 = "Объем шара = " + volume.ToString();
        }
    }
}