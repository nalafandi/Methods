/*Programmer: Mhd Nidal Alafandi
 * Projrct: Deliverable5
 * Date: 09/22/2022
 */


namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15");
                int input = int.Parse(Console.ReadLine());

                if ((input >= 5) && (input <= 15))
                {
                    int[] Array = PopArray(input);
                    Console.Write("All the elements in the new array ");
                    foreach (int i in Array)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Total " + sum(Array));
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Stay between 5 and 15 please!!");
                    Console.ReadKey(true);
                }


            }
            catch
            {
                Console.WriteLine("Only Integers please!!");
                Console.ReadKey(true);
            }

        }

        static int[] PopArray(int array_len)
        {
            Random random = new Random();
            int[] array = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                array[i] = random.Next(10, 50);
            }
            return array;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
