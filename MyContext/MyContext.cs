namespace Project.MyContext;

using Project.WelcomeScreen;
using Project.mainScreen;
using Project.User;
using System.Text.Json;
using LibrarySim.FileWork;
using System.Data;
using Newtonsoft.Json;

enum State
{
    OnWelcomeScreen,
    OnMainScreen
};

public class MyContext : ApplicationContext
{
    private User? user;
    private Form1 main_form;

    private FileWork source;
    public MyContext()
    {
        WelcomeScreen _welcome_screen;
        _welcome_screen = new WelcomeScreen();
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
        user = (sender as WelcomeScreen).User;
        InitMainScreen();
    }

    private void InitMainScreen()
    {
        main_form = new Form1();

        source = new FileWork(user.Name+".json");
        var a = JsonConvert.DeserializeObject<DataTable>(source.ReadAll());
        main_form.SetDataSource(a);

        main_form.Show();

        main_form.FormClosing += MainScreenClosingHandler;
    }

    private void MainScreenClosingHandler(object? sender, FormClosingEventArgs e)
    {
        main_form.EndEdit();
        source.Rewrite(JsonConvert.SerializeObject(main_form.GetDataSource(), Formatting.Indented));
        ExitThread();
    }
}