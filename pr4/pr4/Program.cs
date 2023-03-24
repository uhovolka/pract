using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spell lumos = new Spell("люмос", 50, "стало ярче!");
            Spell crucio = new Spell("круцио", 30, "это плохое заклинание, перестаньте!");
            Wizard mag = new Wizard("волшебник", 90);
            mag.spell(lumos);
            mag.spell(crucio);
            Console.ReadKey();
        }

        class Spell
        {
            public string name { get; private set; }
            public int mana { get; private set; }
            private string effect { get; set; }
            public Spell(string name, int mana, string effect)
            {
                this.name = name;
                this.mana = mana;
                this.effect = effect;
            }
            public void Use()
            {
                Console.WriteLine(effect);
            }
        }
        class Wizard
        {
            public string name { get; private set; }
            public int mana { get; private set; }
            public Wizard(string name, int mana)
            {
                this.name = name;
                this.mana = mana;
            }
            public void spell(Spell spell)
            {
                if (mana >= spell.mana)
                {
                    mana -= spell.mana;
                    Console.WriteLine("{0} колдует!", name);
                    spell.Use();
                }
                else
                {
                    int mana = spell.mana - this.mana;
                    Console.WriteLine(
                        "для использования {0} не хватает {1} единиц маны, хлебните зелья!",
                        spell.name, mana);
                }
            }
        }
    }
    }

