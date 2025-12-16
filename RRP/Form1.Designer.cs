namespace RRP
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewLinkColumn();
            Column4 = new DataGridViewButtonColumn();
            Controles = new GroupBox();
            addServidor = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            addServidorBtn = new Button();
            revendaSelect = new ComboBox();
            label3 = new Label();
            nomeServidorTxt = new TextBox();
            enderecoServidorTxt = new TextBox();
            addRevenda = new GroupBox();
            nomeRevendaTxt = new TextBox();
            addRevendaBtn = new Button();
            label1 = new Label();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Controles.SuspendLayout();
            addServidor.SuspendLayout();
            addRevenda.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(treeView1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Controles
            // 
            resources.ApplyResources(Controles, "Controles");
            Controles.Controls.Add(addServidor);
            Controles.Controls.Add(addRevenda);
            Controles.Name = "Controles";
            Controles.TabStop = false;
            Controles.Enter += Controles_Enter;
            // 
            // addServidor
            // 
            resources.ApplyResources(addServidor, "addServidor");
            addServidor.Controls.Add(label5);
            addServidor.Controls.Add(label4);
            addServidor.Controls.Add(addServidorBtn);
            addServidor.Controls.Add(revendaSelect);
            addServidor.Controls.Add(label3);
            addServidor.Controls.Add(nomeServidorTxt);
            addServidor.Controls.Add(enderecoServidorTxt);
            addServidor.Name = "addServidor";
            addServidor.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // addServidorBtn
            // 
            resources.ApplyResources(addServidorBtn, "addServidorBtn");
            addServidorBtn.Name = "addServidorBtn";
            addServidorBtn.UseVisualStyleBackColor = true;
            // 
            // revendaSelect
            // 
            resources.ApplyResources(revendaSelect, "revendaSelect");
            revendaSelect.FormattingEnabled = true;
            revendaSelect.Name = "revendaSelect";
            revendaSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // nomeServidorTxt
            // 
            resources.ApplyResources(nomeServidorTxt, "nomeServidorTxt");
            nomeServidorTxt.Name = "nomeServidorTxt";
            nomeServidorTxt.TextChanged += textBox4_TextChanged;
            // 
            // enderecoServidorTxt
            // 
            resources.ApplyResources(enderecoServidorTxt, "enderecoServidorTxt");
            enderecoServidorTxt.Name = "enderecoServidorTxt";
            // 
            // addRevenda
            // 
            resources.ApplyResources(addRevenda, "addRevenda");
            addRevenda.Controls.Add(nomeRevendaTxt);
            addRevenda.Controls.Add(addRevendaBtn);
            addRevenda.Controls.Add(label1);
            addRevenda.Name = "addRevenda";
            addRevenda.TabStop = false;
            // 
            // nomeRevendaTxt
            // 
            resources.ApplyResources(nomeRevendaTxt, "nomeRevendaTxt");
            nomeRevendaTxt.Name = "nomeRevendaTxt";
            // 
            // addRevendaBtn
            // 
            resources.ApplyResources(addRevendaBtn, "addRevendaBtn");
            addRevendaBtn.Name = "addRevendaBtn";
            addRevendaBtn.UseVisualStyleBackColor = true;
            addRevendaBtn.Click += addRevendaBtn_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // treeView1
            // 
            resources.ApplyResources(treeView1, "treeView1");
            treeView1.Name = "treeView1";
            treeView1.Nodes.AddRange(new TreeNode[] { (TreeNode)resources.GetObject("treeView1.Nodes"), (TreeNode)resources.GetObject("treeView1.Nodes1"), (TreeNode)resources.GetObject("treeView1.Nodes2") });
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Controles);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Controles.ResumeLayout(false);
            addServidor.ResumeLayout(false);
            addServidor.PerformLayout();
            addRevenda.ResumeLayout(false);
            addRevenda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox Controles;
        private Label label1;
        private TextBox nomeRevendaTxt;
        private Button addRevendaBtn;
        private GroupBox addRevenda;
        private GroupBox addServidor;
        private Button addServidorBtn;
        private Label label4;
        private Label label3;
        private TextBox enderecoServidorTxt;
        private TextBox nomeServidorTxt;
        private ComboBox revendaSelect;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewLinkColumn Column3;
        private DataGridViewButtonColumn Column4;
        private TreeView treeView1;
    }
}
