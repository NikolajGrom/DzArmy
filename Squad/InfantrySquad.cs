using Army_02.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_02.Squad
{
    public class InfantrySquad
    {
        public string InfantryName { get; set; }
        RomanSoldier[] romen;
        int count;
        public InfantrySquad() { }
        public InfantrySquad(string InfantryName) { this.InfantryName = InfantryName; }
        //перегрузка оператора '[]'
        public RomanSoldier this[int index]
        {
            get
            {
                return romen[index];
            }
            set
            {
                romen[index] = value;
            }
        }
        public RomanSoldier this[string name]
        {
            get
            {
                var idx = IndexOf(name);
                return romen[idx];
            }
            set
            {
                var idx = IndexOf(name);
                romen[idx] = value;
            }

        }
        public InfantrySquad(int size = 10)
        {
            romen = new RomanSoldier[size];
        }

        public void Add(RomanSoldier romanSoldier)
        {
            if (count < romen.Length)
            {
                romen[count++] = romanSoldier;
            }
        }
        public RomanSoldier GetByIndex(int index)    //получить по индексу
        {
            return romen[index];
        }

        private int IndexOf(string name)   //обращаясь по имени  возвращает солдата по индексу
        {
            for (int i = 0; i < romen.Length; i++)
            {
                if (romen[i].Name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
