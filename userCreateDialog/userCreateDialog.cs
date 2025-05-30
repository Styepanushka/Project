﻿namespace Project.userCreateDialog;

using LibrarySim.FileWork;
using Newtonsoft.Json;
using Project.User;
using System.Data;
using System.Text.Json;
using userDialog;

public partial class userCreateDialog : userDialog
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
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            MessageBox.Show("Name can't be empty");
            return;
        }
        if (string.IsNullOrWhiteSpace(textBox2.Text))
        {
            MessageBox.Show("Password can't be empty");
            return;
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
        User = u;

        FileWork json = new FileWork(u.Name + ".json");

        DataTable dataTable = new DataTable();

        dataTable.Columns.Add("MyName", typeof(string));
        dataTable.Columns.Add("Value", typeof(int));
        dataTable.Columns.Add("Desc", typeof(string));

        dataTable.Rows.Add("All", 0, "");

        json.Write(JsonConvert.SerializeObject(dataTable, Formatting.Indented));

        Close();
    }
}
