using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Soldiers
{
    public class RomanSoldier : Soldier
    {

        public RomanSoldier(string name) : base(name, 100, 12, new Weapon.Shield())
        {

        }

        public override void Atack(Soldier enemy)
        {
            
            //this.Defend(enemy);
           
            
             if (enemy.HP > 0)
             {
                 this.Defend(enemy);
             }
             if ((this.HP <= 0))
             {
                 Console.WriteLine(" Бой окончен ! ");
                 Console.WriteLine(" Поиск нового соперника вместо: " + Name);
             }
            
        }
        public override void Defend(Soldier enemy)
        {
            
           // this.SoldierShield?.Defend(this, enemy.Damage);
           
            
            if (HP > 0)
            {
                this.SoldierShield?.Defend(this, enemy.Damage);
            }
            if ((HP -= (enemy.Damage)) <= 0 || HP <= 0)
            {
                Console.WriteLine($" " + Name + " УБИТ !!! ");
            }
            

        }

    }
}
