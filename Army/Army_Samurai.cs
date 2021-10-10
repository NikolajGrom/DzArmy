using Army_02.Squad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Army
{
    class Army_Samurai
    {
        public string ArmyName { get; set; }
        SamuraiSquad[] samuraiSquads;
        int count;
        public Army_Samurai() { }
        public Army_Samurai(string ArmyName) { this.ArmyName = ArmyName; }
        //перегрузка оператора '[]'
        public SamuraiSquad this[int index]
        {
            get
            {
                return samuraiSquads[index];
            }
            set
            {
                samuraiSquads[index] = value;
            }
        }
        public SamuraiSquad this[string name]
        {
            get
            {
                var idx = IndexOf(name);
                return samuraiSquads[idx];
            }
            set
            {
                var idx = IndexOf(name);
                samuraiSquads[idx] = value;
            }

        }
        public Army_Samurai(int size = 10)
        {
            samuraiSquads = new SamuraiSquad[size];
        }

        public void Add(SamuraiSquad SamSquad)
        {
            if (count < samuraiSquads.Length)
            {
                samuraiSquads[count++] = SamSquad;
            }
        }
        public SamuraiSquad GetByIndex(int index)    //получить по индексу
        {
            return samuraiSquads[index];
        }

        private int IndexOf(string name)   //обращаясь по имени  возвращает солдата по индексу
        {
            for (int i = 0; i < samuraiSquads.Length; i++)
            {
                if (samuraiSquads[i].SquadName.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            return $" Army : {this.ArmyName} ";
        }
    }
}
