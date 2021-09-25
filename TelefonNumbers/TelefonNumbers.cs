using System;
using System.Collections.Generic;

namespace Coding_Games
{
    public class PhoneNumbers
    {
        static List<List<int>> telephones = new List<List<int>>();
        public static void Main(string[] args)
        {
            telephones = GetNumbers();
        }

        static List<List<int>> GetNumbers()
        {
            List<List<int>> listLists = new List<List<int>>();
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string telephone = Console.ReadLine();
                for (int j = 0; j < telephone.Length; j++)
                {
                    int number = int.Parse(telephone.Substring(i, i + 1));
                    list.Add(number);
                }

                listLists.Add(list);
            }
            return listLists;
        }

        static void SystemiseData()
        {
            
        }
    }
}