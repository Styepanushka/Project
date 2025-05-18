namespace Project.MyContext;

using Project.WelcomeScreen;
using Project.mainScreen;
using Project.User;

enum State
{
    OnWelcomeScreen,
    OnMainScreen
};

public class MyContext : ApplicationContext
{

    private State _current;
    private User? _user;
    public MyContext()
    {
        WelcomeScreen _welcome_screen;
        _welcome_screen = new WelcomeScreen();
        _current = State.OnWelcomeScreen;
        _welcome_screen.FormClosing += FormClosingHandler;
        _welcome_screen.Show();
        
    }

    private void FormClosingHandler(object? sender, FormClosingEventArgs e)
    {
        if((sender as WelcomeScreen).User == null)
        {
            ExitThread();
            return;
        }
        _user = (sender as WelcomeScreen).User;
        _current = State.OnMainScreen;
        Form1 main_form = new Form1();
        main_form.Show();
        main_form.FormClosed += (o, e) => ExitThread();
    }
}