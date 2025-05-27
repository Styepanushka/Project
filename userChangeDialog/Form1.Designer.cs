using LibrarySim.FileWork;


namespace Project.userChangeDialog;

using Project.User;
using Project.userDialog;

public enum ChangeState
{
    UserNotChanged,
    UserChanged
}

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(114, 80);
        button1.Text = "Подтвердить";
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.Location = new Point(23, 51);
        label2.Size = new Size(49, 15);
        label2.Text = "Пароль";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(87, 51);
        // 
        // label1
        // 
        label1.Location = new Point(23, 8);
        label1.Size = new Size(31, 15);
        label1.Text = "Имя";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(87, 8);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(210, 116);
        Name = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

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

        if (!users.Contains(u))
        {
            MessageBox.Show("User doesn't exsist");
            return;
        }
        User = u;
        Close();
    }
}