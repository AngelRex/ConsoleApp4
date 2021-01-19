using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<int> ob = new GenericClass<int>();

            
            ob.Add(1);
            ob.Add(2);
            ob.Add(3);     
            ob.Add(4);
            ob.Add(5);

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ob[i]);   
            }
          
        }
    }

    public class GenericClass<T>
        {
            
            T[] obj = new T[5];


        int i = 0;
            public void Add(T item)
            {
             
            
                    obj[i++] = item;

               
            }
            
            public T this[int index]
            {
                get { return obj[index]; }
                set { obj[index] = value; }
            }
        }
       
    


}
