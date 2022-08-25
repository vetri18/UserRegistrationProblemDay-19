namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
           


            UserRegi user = new UserRegi();
           

            Console.WriteLine("Please enter password:  ");
            string pwd = Console.ReadLine();

            bool val = user.Password(pwd);
            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched, there must be 8 characters.");
            }

        }
    }
}