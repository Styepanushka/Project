namespace Project.userCreateDialog;

using Project.userDialog;

partial class userCreateDialog : userDialog
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
        button1.Location = new Point(105, 84);
        button1.TabIndex = 4;
        button1.Text = "Подтвердить";
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.Location = new Point(14, 55);
        label2.Size = new Size(49, 15);
        label2.TabIndex = 3;
        label2.Text = "Пароль";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(78, 55);
        textBox2.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new Point(14, 12);
        label1.Size = new Size(31, 15);
        label1.TabIndex = 1;
        label1.Text = "Имя";
        label1.Click += label1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(78, 12);
        textBox1.TabIndex = 0;
        // 
        // userCreateDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(210, 116);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "userCreateDialog";
        Text = "userCreateDialog";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

}