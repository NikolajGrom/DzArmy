using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Army_02.Soldiers;
namespace Army_02.Squad
{
    class SamuraiSquad
    {
        //Book[] books;
        SamuraiSoldier[] samurais;
        int count;
        //перегрузка оператора '[]'
        public SamuraiSoldier this[int index]
        {
            get
            {
                return samurais[index];
            }
            set
            {
                samurais[index] = value;
            }
        }
        public SamuraiSoldier this[string name]
        {
            get
            {
                var idx = IndexOf(name);
                return samurais[idx];
            }
            set
            {
                var idx = IndexOf(name);
                samurais[idx] = value;
            }

        }
        public SamuraiSquad(int size = 10)
        {
            samurais = new SamuraiSoldier[size];
        }

        public void Add(SamuraiSoldier samuraiSoldier)
        {
            if (count < samurais.Length)
            {
                samurais[count++] = samuraiSoldier;
            }
        }
        public SamuraiSoldier GetByIndex(int index)    //получить по индексу
        {
            return samurais[index];
        }

        private int IndexOf(string name)   //обращаясь по имени  возвращает солдата по индексу
        {
            for (int i = 0; i < samurais.Length; i++)
            {
                if (samurais[i].Name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
