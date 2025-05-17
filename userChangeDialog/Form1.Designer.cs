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
        button1.Name = "button1";
        button1.Size = new Size(73, 29);
        button1.TabIndex = 9;
        button1.Text = "Confirm";
        button1.UseVisualStyleBackColor = true;
        button1.Click += this.button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(23, 51);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 8;
        label2.Text = "Password";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(87, 51);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 23);
        textBox2.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(23, 8);
        label1.Name = "label1";
        label1.Size = new Size(39, 15);
        label1.TabIndex = 6;
        label1.Text = "Name";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(87, 8);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(210, 116);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Name = "Form1";
        Text = "Form1";
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