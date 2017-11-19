using System;

namespace StackImplementation
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Integer Stack.\n");

      //Create an integer stack
      Stack<int> intStack = new Stack<int>();
      intStack.Push(1);
      intStack.Push(2);
      intStack.PrintStack();


      Console.WriteLine("\nString Stack.\n");
      Stack<string> stringStack = new Stack<string>();
      stringStack.Push("Hi");
      stringStack.Push("Hello");
      stringStack.PrintStack();

      stringStack.Pop();
      stringStack.PrintStack();
    }
  }
}
