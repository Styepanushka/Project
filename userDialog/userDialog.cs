namespace Project.userDialog;

using Project.User;

public partial class userDialog : Form
{
    public User? User { get; protected set; }
    public userDialog()
    {
        InitializeComponent();
    }

}
