namespace BusBoardApp
{
    class UserInput
    {
        public static string GetUsersPostCodeInput()
        {
            Console.WriteLine("Enter postcode:");
            string userInput = Console.ReadLine().Replace(" ", "");
            return userInput;
        }
    }
}