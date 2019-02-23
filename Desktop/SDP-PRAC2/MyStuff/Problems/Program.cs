using System;

namespace Problems
{
   public class Program
    {
          //method that prefixes string with  its length, number of words, and a colon.
        public string Prefix(string input)
        {
                //counter to keep track of chars in string
                int count = 1;
               int ii = 0; 
                //output string
               
            for(int i=0;i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == '\n' || input[i] == '\t')     //sentences are made up of different chars
                {
                    count++;
                }
                 
            }    
               ii++;
                int count2 = 0;
                foreach (char c in input)
                {
                    count2++;
                }
               string sam = $"{count2},{count}:{input}";
            
           
             return sam;
        }
       
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Prefix("Enter a sentence"));           // enter an input       
            //Console.WriteLine(Prefix();          //read input
            //Console.ReadLine();   
        }
    }
}
