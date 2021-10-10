using Army_02.Squad;
using System;
using Army_02.Soldiers;
using Army_02.Army;

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
            /*
         
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
            */
            /*
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
          */


            #endregion

            #region Army

            
            int countArmy =3, CountSold = 3;
           
          
            Army_Roman army_Roman = new Army_Roman(countArmy);
            Army_Samurai army_Samurai = new Army_Samurai(countArmy);
            army_Samurai.ArmyName = "SAMURAI";
            army_Samurai.Add(new SamuraiSquad("Отряд_01"));
            army_Samurai.Add(new SamuraiSquad("Отряд_02"));

            SamuraiSquad squad1 = new SamuraiSquad(CountSold);
            SamuraiSquad squad2 = new SamuraiSquad(CountSold);

            squad1.SquadName = "Отряд_01";
            squad1.Add(new ("s1"));
            squad1.Add(new SamuraiSoldier("s2"));
            squad1.Add(new SamuraiSoldier("s3"));

            squad2.SquadName = "Отряд_02";
            squad2.Add(new("s2.1"));
            squad2.Add(new SamuraiSoldier("s2.2"));
            squad2.Add(new SamuraiSoldier("s2.3"));


            for (int i = 0; i < countArmy; i++)
            {
                Console.WriteLine($" "+ army_Samurai.ArmyName);
                Console.WriteLine("------");
                for (int j = 0; j < countArmy; j++)
                {
                    Console.WriteLine("\n " + squad1.SquadName + " "+squad1[i] + 
                                      "\n " + squad2.SquadName +" "+ squad2[i]);
                    Console.WriteLine("------");
                }
            }


            #endregion

            Console.ReadKey();

        }
    }
}
