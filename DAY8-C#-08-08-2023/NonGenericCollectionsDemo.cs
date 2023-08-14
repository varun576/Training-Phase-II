﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    internal class NonGenericCollectionsDemo
    {
        public void ArrayListElements()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add("hi");
            numbers.Add(241);
            numbers.Add(12);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Remove("241");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void StackElements()
        {
            Stack numbers = new Stack();
            numbers.Push(100);
            numbers.Push(287);
            numbers.Push(-100);
            numbers.Push(333);
            numbers.Push(8765);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Clear();
            Console.WriteLine("Pop" + numbers.Pop());
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void QueueElements()
        {
            Queue numbers = new Queue();
            numbers.Enqueue(100);
            numbers.Enqueue(287);
            numbers.Enqueue(-100);
            numbers.Enqueue(333);
            numbers.Enqueue(8765);
            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Sum());
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //       numbers.Clear();
            Console.WriteLine("Pop" + numbers.Dequeue());
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void HashElements()
        {
            Hashtable students =
                new Hashtable();
            students.Add("rno", "12");
            students.Add("name", "Varun");
            foreach (var k in students.Keys)
            {
                Console.WriteLine(k + " : "
                    + students[k]);
            }
        }
        public void SortedListElements()
        {
            SortedList students =
                new SortedList();
            students.Add("rno", "12");
            students.Add("name", "Varun");
            foreach (string k in students.Keys)
            {
                Console.WriteLine(k + " : "
                    + students[k]);
            }
        }

    }
}
