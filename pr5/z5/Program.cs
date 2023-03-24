using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spell lumos = new Spell("люмос", 50, "стало ярче!");
            Spell crucio = new Spell("круцио", 30, "это плохое заклинание!");
            Magician harryPotter = new Magician("Волшебник", 90);
            harryPotter.spell(lumos);
            harryPotter.spell(crucio);
            Console.ReadKey(true);
        }
    }
    interface IMagic
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    class Spell : IMagic
    {
        public string Name
        {
            get;
            set;
        }
        public int Mana
        {
            get;
            set;
        }
        private string Effect
        {
            get;
            set;
        }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magician
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        public Magician(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mana);
        }
        public void spell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine($"{Name} колдует!");
                spell.WriteInfo();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine($"для использования {spell.Name} не хватает {mana} единиц маны, хлебните зелья!");
            }
        }
    }
    
}
