using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    internal class GenericCollectionsDemo
    {
        public void ListElements()
        {
            List<string> numbers = new List<string>();
            numbers.Add("343");
            numbers.Add("35");
            numbers.Add("21");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Remove("230");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void StackElements()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(34);
            numbers.Push(423);
            numbers.Push(300);
            numbers.Push(24);
            numbers.Push(8);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void QueueElements()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(43);
            numbers.Enqueue(431);
            numbers.Enqueue(-123);
            numbers.Enqueue(2);
            numbers.Enqueue(65);
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Sum());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //       numbers.Clear();
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbers.First());
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void HashElements() 
        {
            Dictionary<string, string> students =
                new Dictionary<string, string>();
            students.Add("rno", "100");
            students.Add("name", "Varun");
            foreach ( string k in students.Keys)
            { 
                Console.WriteLine(k + " : "
                    + students[k]);
            } 
        }
        public void SortedListElements()
        {
            SortedList<string, string> students =
                new SortedList<string, string>();
            students.Add("rno", "100");
            students.Add("name", "Varun");
            foreach (string k in students.Keys)
            {
                Console.WriteLine(k + " : "
                    + students[k]);
            }
        }


    }
}
