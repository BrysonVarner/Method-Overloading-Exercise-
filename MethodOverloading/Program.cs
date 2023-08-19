 namespace MethodOverloading
{
    public class Program
    {
        
        public static int Add(int num1, int num2) 
            { 
            return num1 + num2;
            }
        public static decimal Add(decimal num1, decimal num2) 
        {
            return num1 + num2;
        }
        public static string Add(int num1,int num2, bool isTrue) 
        {
            var response = "";

            if (isTrue) 
            {
                ///Normal if statement
                var sum = num1 + num2;
                //if (sum == 1 || sum == -1) 
                //{
                //    response = $"{sum} dollar.";       
                //}
                //else
                //{
                //    response = $"{sum} dollars.";
                //}

                ///Ternary operator
                response = (sum == 1 || sum == -1) ? $"{sum} dollar." : $"{sum} dollars";
            }

            return response;

        }
       
        static void Main(string[] args)
        {
           

            Console.WriteLine(Add(0, 1, true));

            

            Console.WriteLine(Add(4, 2, true));

            Console.WriteLine(Add(-5, 8, true));

            Console.WriteLine(Add(-5, 4, true));

        }
    }
}
