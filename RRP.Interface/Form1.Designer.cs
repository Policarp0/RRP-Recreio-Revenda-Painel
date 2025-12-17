namespace RRP.Interface
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            AddRevendaBtn = new Button();
            TxtNomeRevenda = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            TabControle = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            PingBtn = new Button();
            ExcluirRevendaBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            TabControle.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ferramentas de Controle";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(AddRevendaBtn);
            groupBox3.Controls.Add(TxtNomeRevenda);
            groupBox3.Location = new Point(6, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(271, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Adicionar servidor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 54);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome da revenda";
            // 
            // AddRevendaBtn
            // 
            AddRevendaBtn.Location = new Point(190, 72);
            AddRevendaBtn.Name = "AddRevendaBtn";
            AddRevendaBtn.Size = new Size(75, 23);
            AddRevendaBtn.TabIndex = 1;
            AddRevendaBtn.Text = "Adicionar";
            AddRevendaBtn.UseVisualStyleBackColor = true;
            AddRevendaBtn.Click += AddRevendaBtn_Click;
            // 
            // TxtNomeRevenda
            // 
            TxtNomeRevenda.Location = new Point(6, 72);
            TxtNomeRevenda.Name = "TxtNomeRevenda";
            TxtNomeRevenda.Size = new Size(171, 23);
            TxtNomeRevenda.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(6, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 242);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adicionar revenda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome do servidor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Revenda";
            // 
            // button2
            // 
            button2.Location = new Point(190, 158);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 7;
            label3.Text = "Endereço do servidor";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 8;
            // 
            // TabControle
            // 
            TabControle.Controls.Add(tabPage1);
            TabControle.Location = new Point(6, 31);
            TabControle.Name = "TabControle";
            TabControle.SelectedIndex = 0;
            TabControle.Size = new Size(495, 358);
            TabControle.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(487, 330);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(481, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PingBtn);
            groupBox4.Controls.Add(ExcluirRevendaBtn);
            groupBox4.Controls.Add(TabControle);
            groupBox4.Location = new Point(301, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(508, 424);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "View";
            // 
            // PingBtn
            // 
            PingBtn.Location = new Point(242, 395);
            PingBtn.Name = "PingBtn";
            PingBtn.Size = new Size(123, 23);
            PingBtn.TabIndex = 3;
            PingBtn.Text = "Ping para todos";
            PingBtn.UseVisualStyleBackColor = true;
            // 
            // ExcluirRevendaBtn
            // 
            ExcluirRevendaBtn.Location = new Point(371, 395);
            ExcluirRevendaBtn.Name = "ExcluirRevendaBtn";
            ExcluirRevendaBtn.Size = new Size(123, 23);
            ExcluirRevendaBtn.TabIndex = 2;
            ExcluirRevendaBtn.Text = "Excluir Revenda";
            ExcluirRevendaBtn.UseVisualStyleBackColor = true;
            ExcluirRevendaBtn.Click += ExcluirRevendaBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RRP - Recreio Revenda Painel";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TabControle.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button AddRevendaBtn;
        private TextBox TxtNomeRevenda;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TabControl TabControle;
        private GroupBox groupBox4;
        private Button PingBtn;
        private Button ExcluirRevendaBtn;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
