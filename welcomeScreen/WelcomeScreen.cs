namespace Project.WelcomeScreen;

using Project.userCreateDialog;

public partial class WelcomeScreen : Form
{
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
        using(userCreateDialog dialog =  new userCreateDialog())
        {
            dialog.ShowDialog();
        }
    }
}
