using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzawinFormalkalmazas
{
    internal class Pizza
    {
        int pizzaId;
        string pizzaNev;
        int pizzaAr;
        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            pizzaId = int.Parse(sor[0]);
            pizzaNev = sor[1].Trim().Replace("\"", string.Empty);
            pizzaAr = int.Parse(sor[2].Trim().Replace("\"", string.Empty).Replace('.', ','));
        }

        public int PizzaId { get => pizzaId; set => pizzaId = value; }
        public string PizzaNev { get => pizzaNev; set => pizzaNev = value; }
        public int PizzaAr { get => pizzaAr; set => pizzaAr = value; }

        public override string ToString()
        {
            return pizzaNev;
        }
    }
}
