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
        label1 = new Label();
        changeUser = new Button();
        createUser = new Button();
        start = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(352, 202);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // changeUser
        // 
        changeUser.Location = new Point(336, 302);
        changeUser.Name = "changeUser";
        changeUser.Size = new Size(89, 27);
        changeUser.TabIndex = 2;
        changeUser.Text = "Change user";
        changeUser.UseVisualStyleBackColor = true;
        // 
        // createUser
        // 
        createUser.Location = new Point(338, 335);
        createUser.Name = "createUser";
        createUser.Size = new Size(87, 41);
        createUser.TabIndex = 3;
        createUser.Text = "Create new\r\nuser";
        createUser.UseVisualStyleBackColor = true;
        createUser.Click += createUser_Click;
        // 
        // start
        // 
        start.Location = new Point(332, 228);
        start.Name = "start";
        start.Size = new Size(94, 31);
        start.TabIndex = 4;
        start.Text = "Enter";
        start.UseVisualStyleBackColor = true;
        // 
        // WelcomeScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(start);
        Controls.Add(createUser);
        Controls.Add(changeUser);
        Controls.Add(label1);
        Name = "WelcomeScreen";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private Button changeUser;
    private Button createUser;
    private Button start;
}
