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
        public int MaxAmount { get; set; }

        public Group(int maxAmount)
        {
            MaxAmount = maxAmount;
        }

        public void AddMember(Liik member)
        {
            Liik liik = new Liik("", 0, "", 0);
            Console.ForegroundColor = ConsoleColor.Red;
            if (Members.Contains(member))
            {
                Console.WriteLine("Liik ei ole lisatud! Selline liige on juba olemas");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nVajutage Enter...");
                Console.ReadLine();
                return;
            }
            if (Members.Count >= MaxAmount)
            {
                Console.WriteLine("Liik ei ole lisatud! Osalejate arv grupis on täis");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nVajutage Enter...");
                Console.ReadLine();
                return;
            }
            if (member.Name == liik.Name && member.Age == liik.Age && member.City == liik.City)
            {
                Console.WriteLine("Liik ei ole lisatud! Tühjust lisada ei saa");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nVajutage Enter...");
                Console.ReadLine();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Liik on lisatud");
            Members.Add(member);
            Console.ForegroundColor = ConsoleColor.White;
            ShowInfo();
            Console.Write("\nVajutage Enter...");
            Console.ReadLine();
            return;
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
            Console.WriteLine("Osalejate arv: {0}/{1}", MaxAmount, Members.Count);
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
            int MaxAge;
            try
            {
                MaxAge = MembersAge.Max();
            }
            catch (Exception)
            {
                return;
            }
            foreach (Liik item in Members)
            {
                if (item.Age==MaxAge)
                {
                    MembersMaxAge.Add(item.Name);
                }
            }
            switch (MembersMaxAge.Count)
            {
                case 1: Console.WriteLine("Kõige vanem on {0}", MembersMaxAge[0]); Console.Write("\nVajutage Enter..."); Console.ReadLine(); break;
                default: Console.WriteLine("Kõige vanimad on "+string.Join(", ", MembersMaxAge)); Console.Write("\nVajutage Enter..."); Console.ReadLine(); break;
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
                int MinAge;
                try
                {
                    MinAge = MembersAge.Min();
                }
                catch (Exception)
                {
                    return;
                }
                foreach (Liik item in Members)
                {
                    if (item.Age==MinAge)
                    {
                        MembersMinAge.Add(item.Name);
                    }
                }
                switch (MembersMinAge.Count)
                {
                    case 1: Console.WriteLine("Kõige noorem on {0}", MembersMinAge[0]); Console.Write("\nVajutage Enter..."); Console.ReadLine(); break;
                    default: Console.WriteLine("Kõige noorimad on "+string.Join(", ", MembersMinAge)); Console.Write("\nVajutage Enter..."); Console.ReadLine(); break;
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
            Console.Write("\nVajutage Enter...");
            Console.ReadLine();
            return grupp;
        }

        public void DelMember(Liik liik)
        {
            Members.Remove(liik);
            Console.Write("\nVajutage Enter...");
            Console.ReadLine();
        }
    }
}
