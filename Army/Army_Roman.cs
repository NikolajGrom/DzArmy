using Army_02.Squad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Army
{
    class Army_Roman
    {
        public string ArmyName { get; set; }
        InfantrySquad[] infantrySquads;
        int count;
        public Army_Roman() { }
        public Army_Roman(string ArmyName) { this.ArmyName = ArmyName; }
        public InfantrySquad this[int index]
        {
            get
            {
                return infantrySquads[index];
            }
            set
            {
                infantrySquads[index] = value;
            }
        }
        public InfantrySquad this[string name]
        {
            get
            {
                var idx = IndexOf(name);
                return infantrySquads[idx];
            }
            set
            {
                var idx = IndexOf(name);
                infantrySquads[idx] = value;
            }

        }
        public Army_Roman(int size = 10)
        {
            infantrySquads = new InfantrySquad[size];
        }

        public void Add(InfantrySquad InfSquad)
        {
            if (count < infantrySquads.Length)
            {
                infantrySquads[count++] = InfSquad;
            }
        }
        public InfantrySquad GetByIndex(int index)    //получить по индексу
        {
            return infantrySquads[index];
        }

        private int IndexOf(string name)   //обращаясь по имени  возвращает солдата по индексу
        {
            for (int i = 0; i < infantrySquads.Length; i++)
            {
                if (infantrySquads[i].InfantryName.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            return $" Army : {ArmyName} !";
        }
    }
}
