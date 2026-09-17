using Autoszerviz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoszerviz
{
    internal class Program
    {
        static void Main()
        {
            List<Jarmu> jarmuvek = new List<Jarmu> ();

            jarmuvek.Add(new Szemelyauto("ABC-123", 2015, "jó", 4));
            jarmuvek.Add(new Teherauto("XYZ-789", 2018, "rossz", 2000));
            jarmuvek.Add(new Motorkerekpar("MNO-456", 2020, "jó"));

            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.Szervizviszsga();
            }
        }
    }
}
