namespace Project.WelcomeScreen;

using Project.userCreateDialog;
using Project.userDialog;

public enum EnteringState
{
    Default,
    UserChanged
}

public partial class WelcomeScreen : Form
{
    public User.User User { get; private set; }
    public EnteringState _state { get; private set; }

    public WelcomeScreen()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {

    }

    private void createUser_Click(object sender, EventArgs e)
    {
        using (userCreateDialog dialog = new userCreateDialog())
        {
            dialog.FormClosed += OpenMain;
            dialog.ShowDialog();
        }
    }

    private void start_Click(object sender, EventArgs e)
    {
        using (userChangeDialog.Form1 dialog = new userChangeDialog.Form1())
        {
            dialog.FormClosed += OpenMain;
            dialog.ShowDialog();
        }
    }

    private void OpenMain(object o, EventArgs e)
    {
        User = (o as userDialog).User;
        Close();
    }
}
