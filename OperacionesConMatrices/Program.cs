using System;

namespace OperacionesConMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] pallets = { "B14", "A11", "B12", "A13" };

            //Console.WriteLine("Sorted...");
            //Array.Sort(pallets);

            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            //Console.WriteLine("");
            //Console.WriteLine("Reverse...");
            //Array.Reverse(pallets);
            //foreach (var pallet in pallets)
            //{
            //    Console.WriteLine($"-- {pallet}");
            //}

            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Console.WriteLine($"Before: {pallets[0].ToLower()}");
            Array.Clear(pallets, 0, 2);
            if (pallets[0] != null)
                Console.WriteLine($"After: {pallets[0].ToLower()}");

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");

            }


            // Métodos de string
            //string value = "abc123";
            //char[] valueArray = value.ToCharArray();

            //Array.Reverse(valueArray);
            //// string result = new string(valueArray);
            //string result = String.Join(",", valueArray);
            //Console.WriteLine(result);

            //string[] items = result.Split(',');
            //foreach (string item in items)
            //{
            //    Console.WriteLine($"-- {item}");
            //}


            // Ejercicio resuelto
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] items = pangram.Split(' ');
            char[] word;
            int count = 0;
            string result;
            foreach (string item in items)
            {

                // Console.WriteLine(item);
                word = item.ToCharArray();
                Array.Reverse(word);
                items[count] = new String(word);
                count++;
            }
            result = String.Join(" ", items);
            Console.WriteLine(result);

            //Sugerencia de resolución
            //string pangram = "The quick brown fox jumps over the lazy dog";

            //string[] message = pangram.Split(' ');
            //string[] newMessage = new string[message.Length];

            //for (int i = 0; i < message.Length; i++)
            //{
            //    char[] letters = message[i].ToCharArray();
            //    Array.Reverse(letters);
            //    newMessage[i] = new string(letters);
            //}

            //string result = String.Join(" ", newMessage);
            //Console.WriteLine(result);


            //Segundo ejercicio resuelto 
            //string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            //string[] orders = orderStream.Split(',');
            //char[] orderCharArray;

            //for (int i = 0; i < orders.Length; i++)
            //{
            //    orderCharArray = orders[i].ToCharArray();
            //    if (orderCharArray[0] == 'B')
            //        Console.WriteLine(orders[i]);
            //    i++;
            //}

            //Segundo ejercicio resuelto ejemplo
            //string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            //string[] items = orderStream.Split(',');

            //foreach (var item in items)
            //{
            //    if (item.StartsWith("B"))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }
    }
}
