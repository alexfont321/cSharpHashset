using System;
using System.Collections.Generic;

namespace hashset {
    class Program {
        static void Main (string[] args) {
            List<string> Inventory = new List<string> () {
                "Camry",
                "F-150",
                "MDX",
                "Camry",
                "Camry",
                "Taurus",
                "F-150",
                "MDX",
                "Camry",
                "Xterra",
                "Mustang",
                "Suburban",
                "Santa Fe",
                "F-150",
                "Camry",
                "F-150",
                "F-150",
                "Mustang",
                "Camry",
                "Camry",
                "Camry",
                "Escalade",
                "Q30",
                "Camry",
                "MDX",
            };

            HashSet<string> allModels = new HashSet<string> ();

            foreach (string model in Inventory) {
                allModels.Add(model);
            }

            // Display all unique model names
            foreach (string vehicle in allModels) {
                Console.WriteLine ($"{vehicle}");
            }

            /*
                Output

                Camry
                F-150
                MDX
                Taurus
                Xterra
                Mustang
                Suburban
                Santa Fe
                Escalade
                Q30
            */




            //Exercises


            HashSet<string> Showroom = new HashSet<string> ();
            Showroom.Add("Sentra");
            Showroom.Add("Beetle");
            Showroom.Add("Audi");
            Showroom.Add("Corolla");


            Console.WriteLine(Showroom.Count);


            HashSet<string> usedLot = new HashSet<string> ();

            usedLot.Add("Porsche");
            usedLot.Add("Italian Car");


            Showroom.UnionWith(usedLot);

            Showroom.Remove("Porsche");

            foreach(string model in Showroom) {
                Console.WriteLine(model);
            }




        }
    }
}