namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Console.WriteLine("Hello,Please Enter A Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your Number is { number}");
            #endregion

            #region Question 2

            //string word = "Alaa37";
            //int word02 = Convert.ToInt32(word);
            //Console.WriteLine(word02);
            // will throw exception because we can't convert string to integer 
            #endregion

            #region Question 3
            //float a, b,c;
            //a = 0.5f;
            //b = 1.2f;
            //c = a + b;
            //Console.WriteLine($"The Sum of a and b is {c}");
            //the operation is done without any exception.
            #endregion

            #region Question 4

            //string word = "AlaaElSoghair";
            //string SubstringWord = word.Substring(4,9);
            //Console.WriteLine($"The Substringword is ({SubstringWord})");

            #endregion

            #region Question 5
            //int x, y;
            //x = 5;
            //y = 10;
            //Console.WriteLine($"Before Assigning Assigning Value of X is {x} and Value of Y is {y}");
            //x = y;
            //Console.WriteLine($"After Assigning Value of X is {x} and Value of Y is {y}");
            //x = 2;
            //Console.WriteLine($"After Modifying X The new Value of X is {x} and Value of Y is {y}");
            /* After Modifying X, the value of Y doesn't change because they are value type so when we assign one to another 
             * it takes an instance of the other value unlike reference type 
            */
            #endregion
        }
    }
}
