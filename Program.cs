namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the First Name ");
            //string firstname = Console.ReadLine();


            UserRegi user = new UserRegi();
       

            Console.WriteLine("Please enter email address:  ");
            string email = Console.ReadLine();

            bool val = user.Email(email);
            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern Not Matched");
            }
        }
    }
}
