using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp
{
    public class Group
    {
        public List<Liik> Members { get; } = new List<Liik>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(Liik member)
        {
            Liik liik = new Liik("", 0, "");
            Console.ForegroundColor = ConsoleColor.Red;
            if (Members.Contains(member))
            {
                Console.WriteLine("Liik ei ole lisatud! Selline liige on juba olemas");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            if (Members.Count >= _maxAmount)
            {
                Console.WriteLine("Liik ei ole lisatud! Osalejate arv grupis on täis");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            if (member == liik)
            {
                Console.WriteLine("Liik ei ole lisatud! Tühjust lisada ei saa");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Liik on lisatud");
            Members.Add(member);
            Console.ForegroundColor = ConsoleColor.White;
            ShowInfo();
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liik member)
        {
            return Members.Contains(member);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Osalejate arv: {0}/{1}", _maxAmount, Members.Count);
            Console.Write("Liikmed: ");
            foreach (Liik item in Members)
            {
                Console.Write(item.Name+"; ");
            }
        }

        public void TheOldest()
        {
            List<int> MembersAge = new List<int>();
            List<string> MembersMaxAge = new List<string>();
            foreach (Liik item in Members)
            {
                MembersAge.Add(item.Age);
            }
            int MaxAge=MembersAge.Max();
            foreach (Liik item in Members)
            {
                if (item.Age==MaxAge)
                {
                    MembersMaxAge.Add(item.Name);
                }
            }
            switch (MembersMaxAge.Count)
            {
                case 1: Console.WriteLine("Kõige vanem on {0}", MembersMaxAge[0]); break;
                default: Console.WriteLine("Kõige vanimad on "+string.Join(", ", MembersMaxAge)); break;
            }
        }

        public void TheYoungest()
        {
            {
                List<int> MembersAge = new List<int>();
                List<string> MembersMinAge = new List<string>();
                foreach (Liik item in Members)
                {
                    MembersAge.Add(item.Age);
                }
                int MinAge = MembersAge.Min();
                foreach (Liik item in Members)
                {
                    if (item.Age==MinAge)
                    {
                        MembersMinAge.Add(item.Name);
                    }
                }
                switch (MembersMinAge.Count)
                {
                    case 1: Console.WriteLine("Kõige noorem on {0}", MembersMinAge[0]);  break;
                    default: Console.WriteLine("Kõige noorimad on "+string.Join(", ", MembersMinAge));break;
                }
            }
        }

        public Group CreateGroup()
        {
            Console.WriteLine("Maksimaalne inimeste arv grupis");
            int MaxAmount = Int32.Parse(Console.ReadLine());
            Group grupp = new Group(MaxAmount);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Grupp on lisatud");
            Console.ForegroundColor= ConsoleColor.White;
            return grupp;
        }

        public void Menu()
        {
            Console.WriteLine("Menu\n\n * Grupp\n     [1] Loo grupp\n     [2] Lisa gruppi\n     [3] Kõige vanem\n     [4] Kõige noorem\n\n * Liik\n     [5] Loo liik\n     [6] Loo liikmed\n");
        }
    }
}
