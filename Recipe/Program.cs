using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe r1 = new Recipe(4367, "Krumplistészta", new List<string>() { "krumpli", "tészta", });
            Recipe r2 = new Recipe(5783, "Lasagne", new List<string>() { "tészta", "hús", "sajt" });
            Recipe r3 = new Recipe(6723, "Húsleves", new List<string>() { "hús", "víz", "só" });
            Recipe r4 = new Recipe(7432, "Tarhonyáshús", new List<string>() { "tarhonya", "paprika", "hagyma" });
            Recipe r5 = new Recipe(8324, "Sültkrumpli", new List<string>() { "krumpli", "olaj", "tűz" });


            Recipe r1Copy = (Recipe)r1.DeepCopy();
            Recipe r2Copy = (Recipe)r2.DeepCopy();
            Recipe r3Copy = (Recipe)r3.DeepCopy();
            r1Copy.Ingredient.Add("mák");
            r1Copy.Ingredient.Remove("krumpli");
            r1Copy.Name = "MákosTészta";
            r1Copy.Id = 243235;
            r2Copy.Ingredient.Add("só");
            r2Copy.Id = 34545;
            r2Copy.Name = "SózottLasagne";
            r3Copy.Ingredient.Remove("só");
            r3Copy.Ingredient.Add("cukor");
            r3Copy.Name = "CukrosHúsleves";
            r3Copy.Id = 2346;

            Console.WriteLine(r1.ToString());
            Console.WriteLine(r2.ToString());
            Console.WriteLine(r3.ToString());
            Console.WriteLine(r4.ToString());
            Console.WriteLine(r5.ToString());
            Console.WriteLine(r1Copy.ToString());
            Console.WriteLine(r2Copy.ToString());
            Console.WriteLine(r3Copy.ToString());




            Console.ReadLine();
        }
    }
}
