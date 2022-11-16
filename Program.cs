namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užpildyti sąrašą atsitiktiniais skaičiais. Išvesti visus lyginius skaičius..

            var rand = new Random();
            var list = new List<int>();


            for (int i = 0; i < 6; i++)
            {
                list.Add(rand.Next(1, 10));
            } 


            // galima naudoti foreach arba list
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }


            // galima naudoti list
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i] % 2 == 0)
            //        {
            //            Console.WriteLine(list[i]);
            //        }

            //    }
            }
        }
}