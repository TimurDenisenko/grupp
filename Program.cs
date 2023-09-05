using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor= ConsoleColor.White;
            Group grupp = new Group(0);
            Liik liik = new Liik("",0,"");
            while (true)
            {
                grupp.Menu();
                ConsoleKeyInfo level = Console.ReadKey();
                Console.Clear();
                switch (level.KeyChar)
                {
                    case '1':
                        grupp=grupp.CreateGroup();
                        break;
                    case '5':
                        liik=liik.CreateLiik();
                        liik.ShowInfo();
                        break;
                    case '2':
                        grupp.AddMember(liik);
                        break;
                    case '3':
                        grupp.TheOldest();
                        break;
                    case '4':
                        grupp.TheYoungest();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
