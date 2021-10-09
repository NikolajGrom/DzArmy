using Army_02.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Soldiers
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }
        public Shield SoldierShield { get; set; }



        private Soldier() { }
        protected Soldier(string name, int hp, int damage)
        {
            this.Name = name;
            this.HP = hp;
            this.Damage = damage;
        }
        protected Soldier(string name, int hp, int damage, Shield SoldierShield)
        {
            this.Name = name;
            this.HP = hp;
            this.Damage = damage;
            this.SoldierShield = SoldierShield;
        }

        public abstract void Atack(Soldier enemy);
        public abstract void Defend(Soldier enemy);

        public override string ToString()
        {
            return $"{this.Name} has {this.HP} hp and send {this.Damage} dm!";
        }

    }
}
