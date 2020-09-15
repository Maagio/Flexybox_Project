using System;
using System.Linq;
using System.Collections.Generic;
using Flexybox_project.Models;

namespace Flexybox_project
{
    public class Controller
    {
        public void Run()
        {
            IBackend backend = new Backend();
            while (true)
            {
                Console.WriteLine("Vælg mulighed. Tryk k for at stoppe");
                Console.WriteLine("Tryk 1 for at reverse en string");
                Console.WriteLine("Tryk 2 for at tjekke om et ord er et palindrom");
                Console.WriteLine("Tryk 3 for at få de manglende tal imellem andre tal");
                Console.WriteLine("Tryk 4 for at udskrive mærke navne på instancer");
                string input = Console.ReadLine();
                if (input == "k")
                    break;
                else if (input == "1")
                {
                    Console.WriteLine("Skriv et ord som så vil blive reversed");
                    string word = Console.ReadLine();
                    Console.WriteLine(backend.ReverseString(word));
                }
                else if (input == "2")
                {
                    Console.WriteLine("Skriv et ord som så vil blive tjekket om det er et palindrom");
                    string word = Console.ReadLine();
                    Console.WriteLine(backend.IsPalindrome(word));
                }
                else if (input == "3")
                {
                    int[] arr = new int[5];
                    Console.WriteLine("Indtask 5 tal");
                    for (int i = 0; i < 5; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    foreach (var item in backend.MissingElements(arr))
                    {
                        Console.Write(item + " ");
                    }
                }
                else if (input == "4")
                {
                    InstanceService instances = new InstanceService();
                    IEnumerable<Vehicle> vehicles = instances.GetInstances();
                    foreach (var item in vehicles)
                    {
                        Console.WriteLine(item.GetBrand());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}