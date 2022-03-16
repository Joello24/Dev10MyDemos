namespace PasswordGeneratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO ui = new ConsoleIO();

            Menu m = new Menu("Main Menu", ui);
            m.AddCommand(new StrongPasswordGeneratorCommand(ui));
            m.AddCommand(new OkPasswordGeneratorCommand(ui));
            m.AddCommand(new WeakPasswordGeneratorCommand(ui));
            m.AddCommand(new ExitCommand(ui));
            m.Run();
        }
    }
}
