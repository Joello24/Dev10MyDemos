namespace PasswordGeneratorDemo
{
    interface ICommand
    {
        string Label();
        string Key();
        bool Execute(); //Return true if continue program, false if exit
    }
}
