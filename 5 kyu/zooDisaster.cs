using System;
using System.Linq;
using System.Collections.Generic;

public class Dinglemouse {

    public static string[] WhoEatsWho(string zoo) {

        if (zoo == "") {
            string[] empty = new String[1];
            empty[0] = "";
            return empty;
        }

        else {
            List<string> animals = zoo.Split(',').ToList();
            List<string> results = new List<string>();
            results.Add(zoo);


            for (int j = 0; j < animals.Count; j++) {
                Console.WriteLine((animals[j]));
            }

            animals.Insert(0, "Beginning");
            animals.Add("End");
            int i = 1;
            Console.WriteLine(("///"));

            while (animals[i] != "End") {

                if (animals[i] == "antelope" && animals[i - 1] == "grass") {
                    animals.RemoveAt(i - 1);
                    results.Add("antelope eats grass");
                    Console.WriteLine("antelope eats grass");
                    i = 0;
                }

                else if (animals[i] == "antelope" && animals[i + 1] == "grass") {
                    animals.RemoveAt(i + 1);
                    results.Add("antelope eats grass");
                    Console.WriteLine("antelope eats grass");
                    i = 0;
                }

                else if (animals[i] == "big-fish" && animals[i - 1] == "little-fish") {
                    animals.RemoveAt(i - 1);
                    results.Add("big-fish eats little-fish");
                    Console.WriteLine("big-fish eats little-fish");
                    i = 0;
                }

                else if (animals[i] == "big-fish" && animals[i + 1] == "little-fish") {
                    animals.RemoveAt(i + 1);
                    results.Add("big-fish eats little-fish");
                    Console.WriteLine("big-fish eats little-fish");
                    i = 0;
                }

                else if (animals[i] == "bug" && animals[i - 1] == "leaves") {
                    animals.RemoveAt(i - 1);
                    results.Add("bug eats leaves");
                    Console.WriteLine("bug eats leaves");
                    i = 0;
                }

                else if (animals[i] == "bug" && animals[i + 1] == "leaves") {
                    animals.RemoveAt(i + 1);
                    results.Add("bug eats leaves");
                    Console.WriteLine("bug eats leaves");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "big-fish") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats big-fish");
                    Console.WriteLine("bear eats big-fish");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "big-fish") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats big-fish");
                    Console.WriteLine("bear eats big-fish");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "bug") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats bug");
                    Console.WriteLine("bear eats bug");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "bug") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats bug");
                    Console.WriteLine("bear eats bug");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "chicken") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats chicken");
                    Console.WriteLine("bear eats chicken");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "chicken") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats chicken");
                    Console.WriteLine("bear eats chicken");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "cow") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats cow");
                    Console.WriteLine("bear eats cow");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "cow") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats cow");
                    Console.WriteLine("bear eats cow");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "leaves") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats leaves");
                    Console.WriteLine("bear eats leaves");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "leaves") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats leaves");
                    Console.WriteLine("bear eats leaves");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i - 1] == "sheep") {
                    animals.RemoveAt(i - 1);
                    results.Add("bear eats sheep");
                    Console.WriteLine("bear eats sheep");
                    i = 0;
                }

                else if (animals[i] == "bear" && animals[i + 1] == "sheep") {
                    animals.RemoveAt(i + 1);
                    results.Add("bear eats sheep");
                    Console.WriteLine("bear eats sheep");
                    i = 0;
                }

                else if (animals[i] == "chicken" && animals[i - 1] == "bug") {
                    animals.RemoveAt(i - 1);
                    results.Add("chicken eats bug");
                    Console.WriteLine("chicken eats bug");
                    i = 0;
                }

                else if (animals[i] == "chicken" && animals[i + 1] == "bug") {
                    animals.RemoveAt(i + 1);
                    results.Add("chicken eats bug");
                    Console.WriteLine("chicken eats bug");
                    i = 0;
                }

                else if (animals[i] == "cow" && animals[i - 1] == "grass") {
                    animals.RemoveAt(i - 1);
                    results.Add("cow eats grass");
                    Console.WriteLine("cow eats grass");
                    i = 0;
                }

                else if (animals[i] == "cow" && animals[i + 1] == "grass") {
                    animals.RemoveAt(i + 1);
                    results.Add("cow eats grass");
                    Console.WriteLine("cow eats grass");
                    i = 0;
                }

                else if (animals[i] == "fox" && animals[i - 1] == "chicken") {
                    animals.RemoveAt(i - 1);
                    results.Add("fox eats chicken");
                    Console.WriteLine("fox eats chicken");
                    i = 0;
                }

                else if (animals[i] == "fox" && animals[i + 1] == "chicken") {
                    animals.RemoveAt(i + 1);
                    results.Add("fox eats chicken");
                    Console.WriteLine("fox eats chicken");
                    i = 0;
                }

                else if (animals[i] == "fox" && animals[i - 1] == "sheep") {
                    animals.RemoveAt(i - 1);
                    results.Add("fox eats sheep");
                    Console.WriteLine("fox eats sheep");
                    i = 0;
                }

                else if (animals[i] == "fox" && animals[i + 1] == "sheep") {
                    animals.RemoveAt(i + 1);
                    results.Add("fox eats sheep");
                    Console.WriteLine("fox eats sheep");
                    i = 0;
                }

                else if (animals[i] == "giraffe" && animals[i - 1] == "leaves") {
                    animals.RemoveAt(i - 1);
                    results.Add("giraffe eats leaves");
                    Console.WriteLine("giraffe eats leaves");
                    i = 0;
                }

                else if (animals[i] == "giraffe" && animals[i + 1] == "leaves") {
                    animals.RemoveAt(i + 1);
                    results.Add("giraffe eats leaves");
                    Console.WriteLine("giraffe eats leaves");
                    i = 0;
                }

                else if (animals[i] == "lion" && animals[i - 1] == "antelope") {
                    animals.RemoveAt(i - 1);
                    results.Add("lion eats antelope");
                    Console.WriteLine("lion eats antelope");
                    i = 0;
                }

                else if (animals[i] == "lion" && animals[i + 1] == "antelope") {
                    animals.RemoveAt(i + 1);
                    results.Add("lion eats antelope");
                    Console.WriteLine("lion eats antelope");
                    i = 0;
                }

                else if (animals[i] == "lion" && animals[i - 1] == "cow") {
                    animals.RemoveAt(i - 1);
                    results.Add("lion eats cow");
                    Console.WriteLine("lion eats cow");
                    i = 0;
                }

                else if (animals[i] == "lion" && animals[i + 1] == "cow") {
                    animals.RemoveAt(i + 1);
                    results.Add("lion eats cow");
                    Console.WriteLine("lion eats cow");
                    i = 0;
                }

                else if (animals[i] == "panda" && animals[i - 1] == "leaves") {
                    animals.RemoveAt(i - 1);
                    results.Add("panda eats leaves");
                    Console.WriteLine("panda eats leaves");
                    i = 0;
                }

                else if (animals[i] == "panda" && animals[i + 1] == "leaves") {
                    animals.RemoveAt(i + 1);
                    results.Add("panda eats leaves");
                    Console.WriteLine("panda eats leaves");
                    i = 0;
                }

                else if (animals[i] == "sheep" && animals[i - 1] == "grass") {
                    animals.RemoveAt(i - 1);
                    results.Add("sheep eats grass");
                    Console.WriteLine("sheep eats grass");
                    i = 0;
                }

                else if (animals[i] == "sheep" && animals[i + 1] == "grass") {
                    animals.RemoveAt(i + 1);
                    results.Add("sheep eats grass");
                    Console.WriteLine("sheep eats grass");
                    i = 0;
                }

                i++;
            }

            animals.RemoveAll(animal => animal == "Beginning");
            animals.RemoveAll(animal => animal == "End");
            string final = "";

            for (int j = 0; j < animals.Count; j++) {
                final += animals[j] + ",";
                Console.WriteLine((animals[j]));
            }

            final = final.Remove(final.Length - 1);
            results.Add(final);
            string[] finals = results.ToArray();

            return finals;

        }
    }
}
