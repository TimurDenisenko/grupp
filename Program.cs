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
            Liik liik = new Liik("",0,"",0);
            List<Liik> liikList = new List<Liik> ();

            while (true)
            {
                Console.Write("Menu\n\n * Grupp\n     [1] Loo grupp\n     [2] Lisa gruppi\n     [3] Kõige vanem\n     [4] Kõige noorem\n     [5] Kustuta liik gruppist\n     [6] Vaatama kõik liiked gruppist\n");
                Console.WriteLine("\n * Liik\n     [7] Loo liik\n     [8] Vaatama kõik liiked\n     [9] Kustuta liik\n");
                ConsoleKeyInfo level = Console.ReadKey();
                Console.Clear();
                switch (level.KeyChar)
                {
                    case '1':
                        grupp=grupp.CreateGroup();
                        break;
                    case '7':
                        liik=liik.CreateLiik(liikList);
                        liikList.Add(liik);
                        break;
                    case '2':
                        liik = liik.Choice(liikList);
                        grupp.AddMember(liik);
                        break;
                    case '3':
                        grupp.TheOldest();
                        break;
                    case '4':
                        grupp.TheYoungest();
                        break;
                    case '8':
                        liik.ShowInfoAll(liikList);
                        break;
                    case '5':
                        liik=liik.Choice(liikList);
                        grupp.DelMember(liik);
                        break;
                    case '9':
                        liik = liik.Choice(liikList);
                        liikList.Remove(liik);
                        grupp.DelMember(liik); 
                        break;
                    case '6':
                        liik.ShowInfoAll(grupp.Members);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
