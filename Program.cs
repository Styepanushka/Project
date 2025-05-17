using Project.WelcomeScreen;
using Project.mainScreen;
using LibrarySim.FileWork;
using Project.MyContext;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MyContext());
    }
}