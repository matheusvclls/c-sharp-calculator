namespace app 
{
    class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi, let's learn C#!\n");
            Console.Write("Enter a number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What mathematical operation do you want to calculate?: ");
            string math_op =  Console.ReadLine();

            Console.Write("Enter another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if(math_op == "+")
            {
                Console.WriteLine(number1+number2);
            } 
            else if(math_op=="-") 
            {
                Console.WriteLine(number1-number2);
            } 
            else if(math_op=="*")
            {
                Console.WriteLine(number1-number2);
            } 
            else if(math_op=="/")
            {
                Console.WriteLine(number1/number2);
            }
        }
    }
}