namespace RRP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Controles_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRevendaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nomeRevendaTxt.Text == string.Empty ? "True" : "False");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
