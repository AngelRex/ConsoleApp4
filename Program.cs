using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<int> intObj = new GenericClass<int>();

            
            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);     
            intObj.Add(4);
            intObj.Add(5);

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intObj[i]);   
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
