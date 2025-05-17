namespace Project.userCreateDialog;

using LibrarySim.FileWork;
using Project.User;
using userDialog;

public partial class userCreateDialog : userDialog
{
    public User User { get; private set; }

    public userCreateDialog()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            throw new ArgumentException("Name can't be empty");
        }
        if (string.IsNullOrWhiteSpace(textBox2.Text))
        {
            throw new ArgumentException("Password can't be empty");
        }

        FileWork users_file = new FileWork("Users.txt");
        List<User> users = new List<User>();

        foreach (var i in users_file.ReadAll().Split('\n'))
        {
            if (string.IsNullOrWhiteSpace(i)) continue;

            string[] parts = i.Split(';');
            User preloaded = new User(parts[0], parts[1]);
            users.Add(preloaded);
            Console.WriteLine(preloaded);
        }

        User u = new User(textBox1.Text, textBox2.Text);

        if (users.Contains(u))
        {
            MessageBox.Show("User exsist");
            Close();
            return;
        }

        users_file.Write(u.ToString() + "\n");
        Close();
        this.User = u;
    }
}
