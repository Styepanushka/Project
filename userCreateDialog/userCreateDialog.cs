using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.userCreateDialog;

using LibrarySim.FileWork;
using Project.User;

public partial class userCreateDialog : Form
{
    public userCreateDialog()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if(textBox1.Text.Length == 0)
        {
            throw new ArgumentNullException("Name can't be empty");
        }
        if (textBox2.Text.Length == 0)
        {
            throw new ArgumentNullException("Password can't be empty");
        }
        FileWork users = new FileWork("Users.txt");
        users.Write(new User(textBox1.Text, textBox2.Text).ToString()+'\n');
        Close();
    }
}
