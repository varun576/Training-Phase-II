using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    internal class GenericCollectionExamples
    {
        List<int> numbers=new List<int>();
        public void AddNewElements()
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
        }
        public int FindAnElement()
        {
            return numbers.ElementAt(2);
        }
    }
}
