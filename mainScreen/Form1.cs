namespace Project.mainScreen;

using System.Data;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        dataGridView1.DataSource = new BindingSource();
    }


    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.Value == null) return;
        if (e.ColumnIndex != 1) return;
        if (e.Value.ToString() == "") return;
        int? i = int.Parse(e.Value.ToString());
        if (i > 0)
        {
            e.CellStyle.ForeColor = Color.Blue;
        }
        else if (int.Parse(e.Value.ToString()) < 0)
        {
            e.CellStyle.ForeColor = Color.Red;
        }
    }

    public void SetDataSource(DataTable dt)
    {
        (dataGridView1.DataSource as BindingSource).DataSource = dt;

        dataGridView1.Columns[0].HeaderText = "Название";
        dataGridView1.Columns[1].HeaderText = "Сумма";
        dataGridView1.Columns[2].HeaderText = "Описание";

        dataGridView1.EndEdit();

    }

    public DataTable GetDataSource()
    {
        return ((dataGridView1.DataSource as BindingSource).DataSource as DataTable);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        (dataGridView1.DataSource as BindingSource).EndEdit();
    }

    private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        dataGridView1.EndEdit();
        var a = (dataGridView1.DataSource as BindingSource);
        a?.EndEdit();
    }

    public void EndEdit()
    {
        dataGridView1.EndEdit();
        var a = (dataGridView1.DataSource as BindingSource);
        a?.EndEdit();
    }
}
