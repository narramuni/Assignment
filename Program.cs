using BasicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphones = new List<Smartphone>
        {
            new Smartphone (12345, "iPhone 12", "A2345",799.99m),
            new Smartphone (67890,"Samsung Galaxy S21","S2101",749.99m),
            new Smartphone (54321,"Google Pixel 5","PXL5",699.99m),
            new Smartphone (98765,"OnePlus 9 Pro","OP9P",899.99m),
            new Smartphone (43210,"Sony Xperia 5 III","X5III",749.99m)
        };

            Console.WriteLine("Smartphones before sorting:");
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }

            smartphones.Sort(); // Sorts the list based on the IComparable implementation in the Smartphone class

            Console.WriteLine("\nSmartphones after sorting by Name:");
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }


            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "One");
            dictionary1.Add(2, "Two");
            dictionary1.Add(3, "Three");


            Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
            dictionary2.Add(1, "Arun");
            dictionary2.Add(2, "Tharun");
            dictionary2.Add(3, "Two");

            Console.WriteLine("Concatenated Dictionaries");
            IEnumerable<KeyValuePair<int, string>> concatenatedObj = dictionary1.Concat(dictionary2);
            foreach (KeyValuePair<int, string> item in concatenatedObj)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Concatenated");


            Console.WriteLine("Intersected Dictionaries");
            IEnumerable<KeyValuePair<int, string>> intersectedObj = dictionary1.Where(kvp => dictionary2.ContainsKey(kvp.Key));
            foreach (KeyValuePair<int, string> item in intersectedObj)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Intersected");

            LinkedList<Smartphone> linkedList = new LinkedList<Smartphone>();

            Smartphone smartphone1 = new Smartphone(1, "Ipad 12", "A2345", 799.99m);
            Smartphone smartphone2 = new Smartphone(2, "Laptop Galaxy S21", "S2101", 749.99m);
            Smartphone smartphone3 = new Smartphone(3, "MIcroPhone Pixel 5", "PXL5", 699.99m);

            linkedList.AddLast(smartphone1);
            linkedList.AddLast(smartphone2);
            linkedList.AddLast(smartphone3);

            Console.WriteLine("Linked List of Smartphones:");

            foreach (Smartphone smartphone in linkedList)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }
            List<Smartphone> smartphoneList = new List<Smartphone>
            {
                new Smartphone(100001, "Pen ", "1234", 692.92m),
                new Smartphone(200002, " Book ", "S201", 74.99m),
                new Smartphone(300003, "Note  ", "KP", 696.92m),
                new Smartphone(400004, "OPPO 9 ", "OP9P", 899.99m),
                new Smartphone(500005, "Sim  ", "JP", 7426.76m)
            };

            Console.WriteLine("Smartphones before sorting:");
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }

            smartphones.Sort(); // Sorts the list based on the IComparable implementation in the Smartphone class

            Console.WriteLine("\nSmartphones after sorting by Name:");
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }

            // Create a sorted set and add smartphones
            SortedSet<Smartphone> sortedSet = new SortedSet<Smartphone>(smartphones);

            Console.WriteLine("\nSorted Set of Smartphones:");
            foreach (var smartphone in sortedSet)
            {
                Console.WriteLine($"IMEI: {smartphone.IMEINumber}, Name: {smartphone.Name}, Model: {smartphone.Model}, Price: ${smartphone.Price}");
            }
            Console.ReadLine();

        }
    }
}

