namespace Banking.Domain
{
    public static class BankingDriver
    {
        public static void Run()
        {
            Console.WriteLine("Banking Application has started");

            Login();
        }

        //This displays menu and handles interaction from user
        // It should probably call either the Bank Menu or Customer Menu as required
        // Then they should show sub menus as required
        public static void Login()
        {
            Console.WriteLine("Login Menu");
        }

        public static void BankMenu()
        {
            Console.WriteLine("Bank  Menu");
        }

        public static void BankSubMenu()
        {
            Console.WriteLine("BankSubMenu");
        }

        public static void CustomerMenu()
        {
            Console.WriteLine("CustomerMenu");
        }

        public static void CustomerSubMenu()
        {
            Console.WriteLine("CustomerSubMenu");
        }
    }
}
