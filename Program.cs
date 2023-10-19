using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Deu_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rndNum = new Random();
            char[] A1 = new char[15];
            char[] A2 = new char[15];
            char[] A3 = new char[15];
            string[] names = {"Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan"};
            int[] scores = {100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30};
            int indexCountA1 = 0, indexCountA2 = 0, indexCountA3 = 0, p1_score = 120, p2_score = 120, turn = 1, count = 0, indexNum = 0;
            string player = "";
            bool flag = false;


            while (!flag && p1_score >= 0 && p2_score >= 0)
            {
                int randomly_selectedNum = rndNum.Next(1, 4);
                int randomSelectArray = rndNum.Next(1, 4);

                if (randomly_selectedNum == 1)
                {
                    if (randomSelectArray == 1)
                    {
                        if (indexCountA1 < 15)
                        {
                            A1[indexCountA1] = 'D';
                            indexCountA1++;
                        }
                    }
                    else if (randomSelectArray == 2)
                    {
                        if (indexCountA2 < 15)
                        {
                            A2[indexCountA2] = 'D';
                            indexCountA2++;
                        }
                    }
                    else
                    {
                        if (indexCountA3 < 15)
                        {
                            A3[indexCountA3] = 'D';
                            indexCountA3++;
                        }
                    }
                }
                else if (randomly_selectedNum == 2)
                {
                    if (randomSelectArray == 1)
                    {
                        if (indexCountA1 < 15)
                        {
                            A1[indexCountA1] = 'E';
                            indexCountA1++;
                        }
                    }
                    else if (randomSelectArray == 2)
                    {
                        if (indexCountA2 < 15)
                        {
                            A2[indexCountA2] = 'E';
                            indexCountA2++;
                        }
                    }
                    else
                    {
                        if (indexCountA3 < 15)
                        {
                            A3[indexCountA3] = 'E';
                            indexCountA3++;
                        }
                    }
                }
                else
                {
                    if (randomSelectArray == 1)
                    {
                        if (indexCountA1 < 15)
                        {
                            A1[indexCountA1] = 'U';
                            indexCountA1++;
                        }
                    }
                    else if (randomSelectArray == 2)
                    {
                        if (indexCountA2 < 15)
                        {
                            A2[indexCountA2] = 'U';
                            indexCountA2++;
                        }
                    }
                    else
                    {
                        if (indexCountA3 < 15)
                        {
                            A3[indexCountA3] = 'U';
                            indexCountA3++;
                        }
                    }
                }

                if (turn % 2 != 0)
                {
                    player = "Player1";
                    p1_score -= 5;
                }
                else
                {
                    player = "Player2";
                    p2_score -= 5;
                }

                Console.WriteLine(player + " :" + "\t" + "(" + "P1-" + p1_score + " P2-" + p2_score + ")");
                Console.Write("A1  ");
                for (int i = 0; i < A1.Length; i++)
                {
                    Console.Write(A1[i] + " ");
                }
                Console.WriteLine();
                Console.Write("A2  ");
                for (int i = 0; i < A2.Length; i++)
                {
                    Console.Write(A2[i] + " ");
                }
                Console.WriteLine();
                Console.Write("A3  ");
                for (int i = 0; i < A3.Length; i++)
                {
                    Console.Write(A3[i] + " ");
                }

                for (int j = 0; j < A1.Length; j++)
                {
                    if (j + 2 <= A1.Length)
                    {
                        if (A1[j] == 'D' && A1[j + 1] == 'E' && A1[j + 2] == 'U')
                        {
                            flag = true;
                            break;
                        }
                        else if (A1[j] == 'U' && A1[j + 1] == 'E' && A1[j + 2] == 'D')
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                for (int j = 0; j < A2.Length; j++)
                {
                    if (j + 2 <= A2.Length)
                    {
                        if (A2[j] == 'D' && A2[j + 1] == 'E' && A2[j + 2] == 'U')
                        {
                            flag = true;
                            break;
                        }
                        else if (A2[j] == 'U' && A2[j + 1] == 'E' && A2[j + 2] == 'D')
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                for (int j = 0; j < A3.Length; j++)
                {
                    if (j + 2 <= A3.Length)
                    {
                        if (A3[j] == 'D' && A3[j + 1] == 'E' && A3[j + 2] == 'U')
                        {
                            flag = true;
                            break;
                        }
                        else if (A3[j] == 'U' && A3[j + 1] == 'E' && A3[j + 2] == 'D')
                        {
                            flag = true;
                            break;
                        }
                    }
                }

                for (int k = 0; k < A1.Length; k++)
                {
                    if (A1[k] == 'D' && A2[k] == 'E' && A3[k] == 'U')
                    {
                        flag = true;
                        break;
                    }
                    else if (A1[k] == 'U' && A2[k] == 'E' && A3[k] == 'D')
                    {
                        flag = true;
                        break;
                    }
                }

                if (A1.Length >= 2 && A2.Length >= 2 && A3.Length >= 2)
                {
                    for (int l = 0; l < A1.Length; l++)
                    {
                        if (l + 3 <= A1.Length && l + 3 <= A2.Length && l + 3 <= A3.Length)
                        {
                            if (A1[l] == 'D' && A2[l + 1] == 'E' && A3[l + 2] == 'U')
                            {
                                flag = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            }
                            else if (A1[l] == 'U' && A2[l + 1] == 'E' && A3[l + 2] == 'D')
                            {
                                flag = true;
                                break;
                            }
                            else if (A1[l + 2] == 'D' && A2[l + 1] == 'E' && A3[l] == 'U')
                            {
                                flag = true;
                                break;
                            }
                            else if (A1[l + 2] == 'U' && A2[l + 1] == 'E' && A3[l] == 'D')
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                turn++;
                count++;
            }

            Console.WriteLine();
            if (flag)
            {
                Console.WriteLine("Winner:" + player);
            }
            else
            {
                Console.WriteLine("Tie");
            }
            Console.WriteLine();

            for (int m = 0; m < scores.Length; m++)
            {
                if (scores[m] >= p1_score)
                {
                    indexNum = m;
                }
            }
            Console.WriteLine("Player" + "\t\t" + "Score");
            Console.WriteLine();

            if (player == "Player1")
            {
                if (indexNum == 0)
                {
                    Console.WriteLine(player + "\t\t" + p1_score);
                    for (int o = 0; o < names.Length; o++)
                    {
                        Console.WriteLine(names[o] + "\t\t" + scores[o]);
                    }
                }
                else
                {
                    for (int n = 0; n < indexNum + 1; n++)
                    {
                        Console.WriteLine(names[n] + "\t\t" + scores[n]);
                    }
                    Console.WriteLine(player + "\t\t" + p1_score);
                    for (int o = indexNum + 1; o < names.Length; o++)
                    {
                        Console.WriteLine(names[o] + "\t\t" + scores[o]);
                    }
                }
            }
            else if (player == "Player2")
            {
                if (indexNum == 0)
                {
                    Console.WriteLine(player + "\t\t" + p2_score);
                    for (int o = 0; o < names.Length; o++)
                    {
                        Console.WriteLine(names[o] + "\t\t" + scores[o]);
                    }
                }
                else
                {
                    for (int n = 0; n < indexNum + 1; n++)
                    {
                        Console.WriteLine(names[n] + "\t\t" + scores[n]);
                    }
                    Console.WriteLine(player + "\t\t" + p2_score);
                    for (int o = indexNum + 1; o < names.Length; o++)
                    {
                        Console.WriteLine(names[o] + "\t\t" + scores[o]);
                    }
                }
            }
            else
            {
                for (int p = 0; p < names.Length; p++)
                {
                    Console.WriteLine(names[p] + "\t\t" + scores[p]);
                }
            }
            Console.ReadLine();
        }
    }
}
