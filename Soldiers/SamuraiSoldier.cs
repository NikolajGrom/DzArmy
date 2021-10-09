using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Soldiers
{
    public class SamuraiSoldier : Soldier
    {
        protected System.Random r;
        public SamuraiSoldier(string name) : base(name, 70, 44) { r = new System.Random(); }

        public override void Atack(Soldier enemy)
        {
            // enemy?.Defend(this);         
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
            System.Console.WriteLine($" Samurai Увернулся ");
            var a = r.Next(0, enemy.Damage);
            System.Console.WriteLine($" {a} % ");
         
           // this.HP -= (enemy.Damage - a);
           
            
            if (this.HP > 0)
            {
                this.HP -= (enemy.Damage - a);
            }
            if ( HP <= 0)
            {
                Console.WriteLine($" " + Name + " УБИТ !!! ");
            }
            
        }
    }
}
