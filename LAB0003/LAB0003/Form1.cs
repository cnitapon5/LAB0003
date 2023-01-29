using System.Xml.Linq;

namespace LAB0003
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBox5.Text;
            dataGridView1.Rows[n].Cells[5].Value = textBox6.Text;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }
    }
}