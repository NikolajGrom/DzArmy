using Army_02.Squad;
using System;
using Army_02.Weapon;
using Army_02.Soldiers;

namespace Army_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Wars! ");
            #region Atack
            /*
            Soldiers.SamuraiSoldier stepa = new Soldiers.SamuraiSoldier(" Goto ");
            Soldiers.RomanSoldier roman = new Soldiers.RomanSoldier(" Roma ");

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);
          
            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> Samurai ---------");
            // roman.Atack(stepa);
            if (roman.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (roman.HP > 0)
            {
                roman.Atack(stepa);
               
            }
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> RomanSoldier ---------");
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (stepa.HP > 0)
            {
                stepa.Atack(roman);
               
            }
            if (roman.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }
            //stepa.Atack(roman);

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> Samurai ---------");
            // roman.Atack(stepa);
            if (roman.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (roman.HP > 0)
            {
                roman.Atack(stepa);
               
            }
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> RomanSoldier ---------");
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (stepa.HP > 0)
            {
                stepa.Atack(roman);
               
            }
            if (roman.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }
            //stepa.Atack(roman);
            
            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> Samurai ---------");
            // roman.Atack(stepa);
            if (roman.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (roman.HP > 0)
            {
                roman.Atack(stepa);
               
            }
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);

            Console.WriteLine($"figth");
            Console.WriteLine($"figth");

            Console.WriteLine($"***********************************\n");
            Console.WriteLine("---------  АТАКУЕТ --> RomanSoldier ---------");
            if (stepa.HP < 0)
            {
                Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                  " Нельзя издеватсянад мертвым ! ");
            }
            if (stepa.HP > 0)
            {
                stepa.Atack(roman);
                
            }
            if (roman.HP < 0)
            {
                Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
            }
            //stepa.Atack(roman);

            System.Console.WriteLine(stepa);
            System.Console.WriteLine(roman);
            */
            #endregion
            #region Squard
            int CountSold = 3;
            InfantrySquad infantry = new InfantrySquad(CountSold);
            SamuraiSquad samurai = new SamuraiSquad(CountSold);

            infantry.Add(new RomanSoldier(" Room_1 "));
            infantry.Add(new RomanSoldier(" Room_2 "));
            infantry.Add(new RomanSoldier(" Room_3 "));
            for (int i = 0; i < CountSold; i++)
            {
                Console.WriteLine(infantry[i]);
                Console.WriteLine("------");
            }

            samurai.Add(new SamuraiSoldier(" Samu_1 "));
            samurai.Add(new SamuraiSoldier(" Samu_2 "));
            samurai.Add(new SamuraiSoldier(" Samu_3 "));
            for (int i = 0; i < CountSold; i++)
            {
                Console.WriteLine(samurai[i]);
                Console.WriteLine("------");
            }

            for (int i = 0; i < CountSold; i++)
            {
                for (int j = 0; j < CountSold; j++)
                {
                   // infantry[i].Atack(samurai[j]);
                    Console.WriteLine("---------  АТАКУЕТ --> Samurai ---------");
                    // roman.Atack(stepa);
                    if (infantry[i].HP < 0)
                    {
                        Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                          " Нельзя издеватсянад мертвым ! ");
                    }
                    if (infantry[i].HP > 0)
                    {
                        infantry[i].Atack(samurai[j]);

                    }
                    if (samurai[j].HP < 0)
                    {
                        Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
                    }

                    Console.WriteLine(samurai[j]);
                    Console.WriteLine(infantry[i]);

                    Console.WriteLine($"figth");
                    Console.WriteLine($"figth");

                    Console.WriteLine($"***********************************\n");
                  
                    Console.WriteLine("---------  АТАКУЕТ --> RomanSoldier ---------");
                    if (samurai[j].HP < 0)
                    {
                        Console.WriteLine(" Нарушение Женевской конвенции\n" +
                                          " Нельзя издеватсянад мертвым ! ");
                    }
                    if (samurai[j].HP > 0)
                    {
                        samurai[j].Atack(infantry[i]);

                    }
                    if (infantry[i].HP < 0)
                    {
                        Console.WriteLine(" Убитый не может АТАКОВАТЬ !!! ");
                    }

                    Console.WriteLine(samurai[j]);
                    Console.WriteLine(infantry[i]);
                }
            }

            Console.WriteLine($"***********************************\n");
          


            #endregion


            Console.ReadKey();





        }
    }
}
