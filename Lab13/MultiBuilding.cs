using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class MultiBuilding : Building
    {
        int floor;

        public MultiBuilding(string adress, double length, double width, double height, int floor)
            : base(adress, length, width, height)
        {
            this.floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            return result +$"\nЕго количество этажей {floor}";
        }
    }
}
