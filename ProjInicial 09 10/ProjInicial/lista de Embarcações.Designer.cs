namespace ProjInicial
{
    partial class lista_de_Embarcações
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idBarcosLabel;
            System.Windows.Forms.Label descrBarcosLabel;
            System.Windows.Forms.Label barcoslocalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lista_de_Embarcações));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plataformasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.idBarcosTextBox = new System.Windows.Forms.TextBox();
            this.descrBarcosTextBox = new System.Windows.Forms.TextBox();
            this.barcoslocalTextBox = new System.Windows.Forms.TextBox();
            this.barcosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basetesteDataSet = new ProjInicial.basetesteDataSet();
            this.barcosTableAdapter = new ProjInicial.basetesteDataSetTableAdapters.barcosTableAdapter();
            this.tableAdapterManager = new ProjInicial.basetesteDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBarcosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrBarcosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcoslocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CampoPesquisa = new System.Windows.Forms.TextBox();
            idBarcosLabel = new System.Windows.Forms.Label();
            descrBarcosLabel = new System.Windows.Forms.Label();
            barcoslocalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumoToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.plataformasToolStripMenuItem,
            this.produtosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consumoToolStripMenuItem
            // 
            this.consumoToolStripMenuItem.Name = "consumoToolStripMenuItem";
            this.consumoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consumoToolStripMenuItem.Text = "Consumo";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.cadastrarNovaToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.produtosToolStripMenuItem.Text = "Embarcações ";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // cadastrarNovaToolStripMenuItem
            // 
            this.cadastrarNovaToolStripMenuItem.Name = "cadastrarNovaToolStripMenuItem";
            this.cadastrarNovaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cadastrarNovaToolStripMenuItem.Text = "Cadastrar Nova";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // plataformasToolStripMenuItem
            // 
            this.plataformasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1,
            this.cadastrarNovaToolStripMenuItem1,
            this.excluirToolStripMenuItem1});
            this.plataformasToolStripMenuItem.Name = "plataformasToolStripMenuItem";
            this.plataformasToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.plataformasToolStripMenuItem.Text = "Plataformas";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            // 
            // cadastrarNovaToolStripMenuItem1
            // 
            this.cadastrarNovaToolStripMenuItem1.Name = "cadastrarNovaToolStripMenuItem1";
            this.cadastrarNovaToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.cadastrarNovaToolStripMenuItem1.Text = "Cadastrar Nova";
            // 
            // excluirToolStripMenuItem1
            // 
            this.excluirToolStripMenuItem1.Name = "excluirToolStripMenuItem1";
            this.excluirToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.excluirToolStripMenuItem1.Text = "Excluir";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem2,
            this.cadastrarToolStripMenuItem,
            this.excluirToolStripMenuItem2});
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.buscarToolStripMenuItem2.Text = "Buscar";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // excluirToolStripMenuItem2
            // 
            this.excluirToolStripMenuItem2.Name = "excluirToolStripMenuItem2";
            this.excluirToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.excluirToolStripMenuItem2.Text = "Excluir";
            // 
            // idBarcosLabel
            // 
            idBarcosLabel.AutoSize = true;
            idBarcosLabel.BackColor = System.Drawing.Color.Transparent;
            idBarcosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idBarcosLabel.ForeColor = System.Drawing.SystemColors.Info;
            idBarcosLabel.Location = new System.Drawing.Point(23, 15);
            idBarcosLabel.Name = "idBarcosLabel";
            idBarcosLabel.Size = new System.Drawing.Size(103, 26);
            idBarcosLabel.TabIndex = 10;
            idBarcosLabel.Text = "Número:";
            idBarcosLabel.Click += new System.EventHandler(this.idBarcosLabel_Click);
            // 
            // idBarcosTextBox
            // 
            this.idBarcosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBarcosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcosBindingSource, "idBarcos", true));
            this.idBarcosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBarcosTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idBarcosTextBox.Location = new System.Drawing.Point(150, 15);
            this.idBarcosTextBox.Name = "idBarcosTextBox";
            this.idBarcosTextBox.Size = new System.Drawing.Size(266, 23);
            this.idBarcosTextBox.TabIndex = 11;
            this.idBarcosTextBox.TextChanged += new System.EventHandler(this.idBarcosTextBox_TextChanged);
            // 
            // descrBarcosLabel
            // 
            descrBarcosLabel.AutoSize = true;
            descrBarcosLabel.BackColor = System.Drawing.Color.Transparent;
            descrBarcosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descrBarcosLabel.ForeColor = System.Drawing.SystemColors.Info;
            descrBarcosLabel.Location = new System.Drawing.Point(35, 79);
            descrBarcosLabel.Name = "descrBarcosLabel";
            descrBarcosLabel.Size = new System.Drawing.Size(82, 26);
            descrBarcosLabel.TabIndex = 12;
            descrBarcosLabel.Text = "Nome:";
            // 
            // descrBarcosTextBox
            // 
            this.descrBarcosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrBarcosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcosBindingSource, "descrBarcos", true));
            this.descrBarcosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrBarcosTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descrBarcosTextBox.Location = new System.Drawing.Point(150, 82);
            this.descrBarcosTextBox.Name = "descrBarcosTextBox";
            this.descrBarcosTextBox.Size = new System.Drawing.Size(266, 23);
            this.descrBarcosTextBox.TabIndex = 13;
            this.descrBarcosTextBox.TextChanged += new System.EventHandler(this.descrBarcosTextBox_TextChanged);
            // 
            // barcoslocalLabel
            // 
            barcoslocalLabel.AutoSize = true;
            barcoslocalLabel.BackColor = System.Drawing.Color.Transparent;
            barcoslocalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barcoslocalLabel.ForeColor = System.Drawing.SystemColors.Info;
            barcoslocalLabel.Location = new System.Drawing.Point(3, 156);
            barcoslocalLabel.Name = "barcoslocalLabel";
            barcoslocalLabel.Size = new System.Drawing.Size(145, 26);
            barcoslocalLabel.TabIndex = 14;
            barcoslocalLabel.Text = "Localização:";
            // 
            // barcoslocalTextBox
            // 
            this.barcoslocalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcoslocalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcosBindingSource, "barcoslocal", true));
            this.barcoslocalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcoslocalTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barcoslocalTextBox.Location = new System.Drawing.Point(150, 159);
            this.barcoslocalTextBox.Name = "barcoslocalTextBox";
            this.barcoslocalTextBox.Size = new System.Drawing.Size(266, 23);
            this.barcoslocalTextBox.TabIndex = 15;
            // 
            // barcosBindingSource
            // 
            this.barcosBindingSource.DataMember = "barcos";
            this.barcosBindingSource.DataSource = this.basetesteDataSet;
            // 
            // basetesteDataSet
            // 
            this.basetesteDataSet.DataSetName = "basetesteDataSet";
            this.basetesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barcosTableAdapter
            // 
            this.barcosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barcosTableAdapter = this.barcosTableAdapter;
            this.tableAdapterManager.plataformasTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjInicial.basetesteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjInicial.Properties.Resources.Logo_Fenix;
            this.pictureBox2.Location = new System.Drawing.Point(784, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(idBarcosLabel);
            this.panel1.Controls.Add(this.idBarcosTextBox);
            this.panel1.Controls.Add(descrBarcosLabel);
            this.panel1.Controls.Add(this.barcoslocalTextBox);
            this.panel1.Controls.Add(barcoslocalLabel);
            this.panel1.Controls.Add(this.descrBarcosTextBox);
            this.panel1.Location = new System.Drawing.Point(679, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 183);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(250, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Busca de Embarcações";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 50);
            this.button2.TabIndex = 30;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarcosDataGridViewTextBoxColumn,
            this.descrBarcosDataGridViewTextBoxColumn,
            this.barcoslocalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barcosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(156, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(431, 149);
            this.dataGridView1.TabIndex = 31;
            // 
            // idBarcosDataGridViewTextBoxColumn
            // 
            this.idBarcosDataGridViewTextBoxColumn.DataPropertyName = "idBarcos";
            this.idBarcosDataGridViewTextBoxColumn.HeaderText = "idBarcos";
            this.idBarcosDataGridViewTextBoxColumn.Name = "idBarcosDataGridViewTextBoxColumn";
            this.idBarcosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrBarcosDataGridViewTextBoxColumn
            // 
            this.descrBarcosDataGridViewTextBoxColumn.DataPropertyName = "descrBarcos";
            this.descrBarcosDataGridViewTextBoxColumn.HeaderText = "descrBarcos";
            this.descrBarcosDataGridViewTextBoxColumn.Name = "descrBarcosDataGridViewTextBoxColumn";
            this.descrBarcosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcoslocalDataGridViewTextBoxColumn
            // 
            this.barcoslocalDataGridViewTextBoxColumn.DataPropertyName = "barcoslocal";
            this.barcoslocalDataGridViewTextBoxColumn.HeaderText = "barcoslocal";
            this.barcoslocalDataGridViewTextBoxColumn.Name = "barcoslocalDataGridViewTextBoxColumn";
            this.barcoslocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "idBarcos",
            "descrBarcos",
            "barcoslocal"});
            this.comboBox1.Location = new System.Drawing.Point(240, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Campo:";
            // 
            // CampoPesquisa
            // 
            this.CampoPesquisa.Location = new System.Drawing.Point(510, 118);
            this.CampoPesquisa.Name = "CampoPesquisa";
            this.CampoPesquisa.Size = new System.Drawing.Size(140, 20);
            this.CampoPesquisa.TabIndex = 34;
            this.CampoPesquisa.TextChanged += new System.EventHandler(this.CampoPesquisa_TextChanged);
            // 
            // lista_de_Embarcações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.CampoPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "lista_de_Embarcações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lista_de_Embarcações";
            this.Load += new System.EventHandler(this.lista_de_Embarcações_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plataformasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem2;
        private basetesteDataSet basetesteDataSet;
        private System.Windows.Forms.BindingSource barcosBindingSource;
        private basetesteDataSetTableAdapters.barcosTableAdapter barcosTableAdapter;
        private basetesteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idBarcosTextBox;
        private System.Windows.Forms.TextBox descrBarcosTextBox;
        private System.Windows.Forms.TextBox barcoslocalTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarcosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrBarcosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcoslocalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CampoPesquisa;
    }
}