namespace Project.mainScreen;

using LibrarySim.FileWork;
using Project.Statya;
using Project.User;

public partial class Form1 : Form
{
    private readonly int _size = 20;
    public Form1()
    {
        InitializeComponent();

        for(int i= 0 ; i < 30; i++)
        {
            Label a = new Label();
            a.Text = i.ToString();
            a.Location = new Point(0, i * _size);

            groupBox1.Controls.Add(a);
        }

        if(groupBox1.Controls.Count >= 20)
            vScrollBar1.Maximum = (groupBox1.Controls.Count - 20) * _size;
        else vScrollBar1.Maximum = 0;

        FileWork f = new FileWork("a.txt");

        ComboStatya c = new ComboStatya(f.ReadAll());
    }

    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
        int c = -groupBox1.Controls.Count;
        foreach(Control control in groupBox1.Controls)
        {
            control.Location = new Point(0, (vScrollBar1.Value + c++) * -_size);
            
        }
    }
}
