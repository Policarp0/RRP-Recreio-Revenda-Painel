using System.Security.Cryptography.X509Certificates;

namespace RRP.Interface
{
    public partial class Form1 : Form
    {
        public static int countAbas = 0;


        public void CriarRevenda(string nomeAba)
        {
            TabPage novaAba = new TabPage();



            TabControle.Controls.Add(novaAba);
            TabControle.Location = new Point(6, 31);
            TabControle.SelectedIndex = 0;
            TabControle.Size = new Size(476, 327);
            TabControle.TabIndex = 1;

            //novaAba.Controls.Add();
            novaAba.Location = new Point(4, 24);
            novaAba.Name = nomeAba;
            novaAba.Padding = new Padding(3);
            novaAba.Size = new Size(500, 396);
            novaAba.TabIndex = 0;
            novaAba.Text = nomeAba;
            novaAba.UseVisualStyleBackColor = true;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void AddRevendaBtn_Click(object sender, EventArgs e)
        {
            CriarRevenda(TxtNomeRevenda.Text);
        }

        private void ExcluirRevendaBtn_Click(object sender, EventArgs e)
        {
            TabControle.Controls.RemoveAt(TabControle.SelectedIndex);
        }
    }
}
