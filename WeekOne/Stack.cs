using System;
using System.Collections.Generic;

namespace StackImplementation
{
  class Stack<T>
  {
    private List<T> _stackList;
    private int _seek;
    public Stack()
    {
      _seek = 0;
      _stackList = new List<T>();
    }

    public void Push(T item)
    {
      _stackList.Add(item);
    }

    public T Pop()
    {
      if(_stackList.Count > 0)
      {
        T item = _stackList[_stackList.Count - 1];
        _stackList.RemoveAt(_stackList.Count - 1);
        return item;
      }
      else
      {
        return default(T);
      }
    }

    public T Peek()
    {
      if(_stackList.Count > 0)
      {
        return _stackList[_stackList.Count - 1];
      }
      else
      {
        return default(T);
      }
    }

    public List<T> ToList()
    {
      return _stackList;
    }

    public void PrintStack()
    {
      Console.Write("Stack : ");
      Console.ForegroundColor = ConsoleColor.Green;
      foreach (T i in ToList())
      {
          Console.Write(i + " ");
      }
      Console.WriteLine();
      Console.ResetColor();
    }
  }
}