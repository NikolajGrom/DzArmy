using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Weapon
{
    public class Shield
    {
        public int DefendHP { get; set; }
        protected int Size { get; set; } = 1;

        public void Defend(Soldiers.Soldier holder, int damage)
        {
            holder.HP -= (damage - (this.DefendHP / Size));
        }

    }
}
