using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp
{
    public class Liik
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int Id { get; set; }

        public Liik(string name, int age, string city, int id)
        {
            Name=name;
            Age=age;
            City=city;
            Id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Nimi: {0}\nVanus: {1}\nLinn: {2}\nID: {3}", Name, Age, City, Id);
        }

        public void ShowInfoAll(List<Liik> liikList)
        {
            foreach (Liik item in liikList)
            {
                Console.WriteLine("Nimi: {0}\nVanus: {1}\nLinn: {2}\nID: {3}", item.Name, item.Age, item.City, item.Id);
                Console.WriteLine();
            }
            Console.Write("\nVajutage Enter...");
            Console.ReadLine();
        }

        public Liik CreateLiik(List<Liik> liikList)
        {
            Random rand = new Random();
            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();
            Console.Write("Linn: ");
            string linn = Console.ReadLine();
            int vanus;
            int id;
            List<int> allID = new List<int> ();
            foreach (Liik item in liikList)
            {
                allID.Add(item.Id);
            }
            while (true)
            {
                try
                {
                    Console.Write("Vanus: ");
                    vanus = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vale andmevorming!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (true)
            {
                do
                {
                    id = rand.Next(0,9999999);
                    if (allID.Contains(id))
                    {
                        continue;
                    }
                } while (allID.Contains(id));
                Console.Write("ID: {0}", id);
                Console.Write("\nVajutage Enter...");
                Console.ReadLine();
                break;
            }
            Console.WriteLine();
            Liik liik = new Liik(nimi, vanus, linn, id);
            return liik;
        }

        public Liik Choice(List<Liik> liikList)
        {
            int id;
            while (true)
            {
                try
                {
                    Console.WriteLine("Kirjutage liikme ID..");
                    id = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    continue;
                }
            }
            foreach (Liik item in liikList)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Seda ID-d pole olemas");
            Console.ForegroundColor = ConsoleColor.White;
            Liik liik = new Liik("", 0, "", 0);
            return liik;
        }
    }
}
