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
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Controles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home";
            Load += Home_Load;
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
    }
}
