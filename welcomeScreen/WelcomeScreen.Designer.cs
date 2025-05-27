namespace Project.WelcomeScreen;

partial class WelcomeScreen : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        createUser = new Button();
        start = new Button();
        SuspendLayout();
        // 
        // createUser
        // 
        createUser.Location = new Point(319, 328);
        createUser.Name = "createUser";
        createUser.Size = new Size(119, 41);
        createUser.TabIndex = 3;
        createUser.Text = "Создать нового пользователя";
        createUser.UseVisualStyleBackColor = true;
        createUser.Click += createUser_Click;
        // 
        // start
        // 
        start.Location = new Point(332, 228);
        start.Name = "start";
        start.Size = new Size(94, 31);
        start.TabIndex = 4;
        start.Text = "Вход";
        start.UseVisualStyleBackColor = true;
        start.Click += start_Click;
        // 
        // WelcomeScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(start);
        Controls.Add(createUser);
        Name = "WelcomeScreen";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion
    private Button createUser;
    private Button start;
}
