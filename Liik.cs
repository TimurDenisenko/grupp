using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp
{
    public class Liik
    {
        private readonly string _name;
        private readonly int _age;
        private readonly string _city;

        public Liik(string name, int age, string city)
        {
            _name=name;
            _age=age;
            _city=city;
        }

        public string Name { get => _name; }
        public int Age { get => _age;}
        public string City { get => _city; }

        public void ShowInfo()
        {
            Console.WriteLine("Nimi: {0}\nVanus: {1}\nLinn: {2}", Name, Age, City);
        }

        public Liik CreateLiik()
        {
            Console.WriteLine("Nimi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Vanus: ");
            int vanus = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Linn: ");
            string linn = Console.ReadLine();
            Console.WriteLine();
            Liik liik = new Liik(nimi, vanus, linn);
            return liik;
        }
    }
}
