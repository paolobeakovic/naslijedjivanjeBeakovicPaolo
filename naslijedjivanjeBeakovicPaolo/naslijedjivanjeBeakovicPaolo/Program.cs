using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslijedjivanjeBeakovicPaolo
{
    interface IControl
    {
        void Metoda();
        int Brojac { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListBox x = new ListBox();
            x.Metoda();
            ComboBox y = new ComboBox();
            y.Metoda();
            Console.ReadKey();

        }
    }
}
