using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Building
    {
        string adress;
        double length;
        double width;
        double height;
        public string Adress
        {
            get 
            {
                return adress;
            }
            set 
            {

            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {

            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {

            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {

            }
        }

        public Building(string adress, double length, double width, double height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $"Адресс здания: {adress}\nЕго длина {length}\nЕго ширина {width}\nЕго высота {height}";
        }
    }
}
