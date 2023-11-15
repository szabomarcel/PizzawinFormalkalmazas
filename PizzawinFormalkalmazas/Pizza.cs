using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzawinFormalkalmazas
{
    internal class Pizza
    {
        string pizzaNev;
        double mennyiseg;
        public Pizza(string line)
        {
            string[] sr = line.Split(';');
            pizzaNev = sr[0].Trim().Replace("\"", string.Empty);
            mennyiseg = double.Parse(sr[1].Trim().Replace("\"", string.Empty).Replace('.', ','));
        }

        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public override string ToString()
        {
            return pizzaNev;
        }
    }
}
