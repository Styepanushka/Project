using Project.WelcomeScreen;
using LibrarySim.FileWork;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        FileWork u = new FileWork("Users.txt");
        ApplicationConfiguration.Initialize();
        Application.Run(new WelcomeScreen());
    }
}