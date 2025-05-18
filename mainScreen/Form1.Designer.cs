namespace Project.mainScreen
{
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
            vScrollBar1 = new VScrollBar();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(9, 9);
            vScrollBar1.Maximum = 30;
            vScrollBar1.Minimum = 1;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.ScaleScrollBarForDpiChange = false;
            vScrollBar1.Size = new Size(25, 432);
            vScrollBar1.TabIndex = 0;
            vScrollBar1.Value = 1;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(37, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 432);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "All";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(vScrollBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private VScrollBar vScrollBar1;
        private GroupBox groupBox1;
    }
}