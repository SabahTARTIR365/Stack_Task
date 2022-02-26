using System;
namespace StackTask
{
    public class STACK <T>
    {   private readonly T[] _items;
        private int _currentIndex=-1;


        public STACK() =>_items = new T[1000000];
       public int Count=> _currentIndex +1; 
        public void Push(T item)=> _items[++_currentIndex]=item;
      

      
        // it's a return statment indirictly
          public T Pop()=>  _items[_currentIndex--];
          public void Print ()
          {
              System.Console.WriteLine("[");
            for(int i=0; i<=_currentIndex;i++) System.Console.WriteLine($"{_items[i]},");
              System.Console.WriteLine("]");
          }
           public void Peak ()
           {
               if (_currentIndex<0) {System.Console.WriteLine("The stack is empty");}
               else { System.Console.WriteLine(_items[_currentIndex]);}

           }
            public void Clear()
            {   if (_currentIndex<0) {System.Console.WriteLine("The stack is empty");}
                 else{ while (Count>0)  { T item = Pop();
              System.Console.WriteLine($"Item removed: {item}");}}
            }

        
    }
}
