

     using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static void Main() {
                for(int i = 1; i <= 100; i++)
                {
                    string result = "";
     
                    if(i % 3 == 0)
                    {
                        result += "Fizz";
                    }
                  
                    if(i % 5 == 0)
                    {
                        result += "Buzz";
                    }
                    
                 
                    if(result == "")
                    {
                        result = i.ToString();
                    }
     
                    Console.WriteLine(result);
                }
            }
        }
    }