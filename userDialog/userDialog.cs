namespace Project.userDialog;

using Project.User;

public partial class userDialog : Form
{
    public User? User { get; protected set; }
    public userDialog()
    {
        InitializeComponent();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            textBox2.Focus();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            button1.Focus();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}
