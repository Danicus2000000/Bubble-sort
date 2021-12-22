using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    class Program
    {
        public static void write_num(List<int> data)//a function that writes out all values in the given list
        {
            foreach(int value in data)
            {
                Console.WriteLine(value);
            }
        }
        static void Main(string[] args)
        {
            // this region fetches ten random numbers between 1 and 100
            #region Get numbers
            List<int> numbers = new List<int>();
            Random RNG = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(RNG.Next(0, 1000));
            }
            #endregion
            int temp;//holds value of number that gets overwritten
            bool swap = false;//sees whether looping agin is nessasary

            Console.WriteLine("Before:");//shows numbers before
            write_num(numbers);
            Console.ReadLine();
            do
            {
                swap = false;//sets swap to false so it will stop looping if a swap doesnt occur
                for (int i = 0; i < numbers.Count-1; i++)//loops through all values in list
                {

                    if (numbers[i] > numbers[i+1])//checks if a value is larger than the next
                    {
                        temp = numbers[i];//moves it
                        numbers[i] = numbers[i+1];
                        numbers[i + 1] = temp;
                        swap = true;//ensures looping continues
                    }
                }
            } while (swap == true);//condition to loop
            Console.WriteLine();//shows list after
            Console.WriteLine("After:");
            write_num(numbers);
            Console.ReadLine();
        }
    }
}
