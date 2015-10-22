namespace ProjInicial
{
    partial class Painel_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel_Estoque));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basetesteDataSet = new ProjInicial.basetesteDataSet();
            this.basetesteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new ProjInicial.basetesteDataSetTableAdapters.estoqueTableAdapter();
            this.tableAdapterManager = new ProjInicial.basetesteDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLinhaEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeItemPlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePlataformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantTotalProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBarcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeBarcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CampoPesquisa = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::ProjInicial.Properties.Resources.Logo_Fenix;
            this.pictureBox2.Location = new System.Drawing.Point(908, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumoToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.plataformasToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 26;
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
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // basetesteDataSet
            // 
            this.basetesteDataSet.DataSetName = "basetesteDataSet";
            this.basetesteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basetesteDataSetBindingSource
            // 
            this.basetesteDataSetBindingSource.DataSource = this.basetesteDataSet;
            this.basetesteDataSetBindingSource.Position = 0;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            this.estoqueBindingSource.DataSource = this.basetesteDataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.barcosTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.plataformasTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjInicial.basetesteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLinhaEstoqueDataGridViewTextBoxColumn,
            this.idPlatDataGridViewTextBoxColumn,
            this.idProdutoDataGridViewTextBoxColumn,
            this.quantidadeItemPlatDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.nomePlataformaDataGridViewTextBoxColumn,
            this.quantTotalProdDataGridViewTextBoxColumn,
            this.movimentacaoDataGridViewTextBoxColumn,
            this.idBarcoDataGridViewTextBoxColumn,
            this.nomeBarcoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(920, 244);
            this.dataGridView1.TabIndex = 46;
            // 
            // idLinhaEstoqueDataGridViewTextBoxColumn
            // 
            this.idLinhaEstoqueDataGridViewTextBoxColumn.DataPropertyName = "idLinhaEstoque";
            this.idLinhaEstoqueDataGridViewTextBoxColumn.HeaderText = "Nº Linha Estoque";
            this.idLinhaEstoqueDataGridViewTextBoxColumn.Name = "idLinhaEstoqueDataGridViewTextBoxColumn";
            this.idLinhaEstoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlatDataGridViewTextBoxColumn
            // 
            this.idPlatDataGridViewTextBoxColumn.DataPropertyName = "idPlat";
            this.idPlatDataGridViewTextBoxColumn.HeaderText = "Nº Plataforma";
            this.idPlatDataGridViewTextBoxColumn.Name = "idPlatDataGridViewTextBoxColumn";
            this.idPlatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Nº Produto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeItemPlatDataGridViewTextBoxColumn
            // 
            this.quantidadeItemPlatDataGridViewTextBoxColumn.DataPropertyName = "quantidadeItemPlat";
            this.quantidadeItemPlatDataGridViewTextBoxColumn.HeaderText = "Quant Na Plataforma";
            this.quantidadeItemPlatDataGridViewTextBoxColumn.Name = "quantidadeItemPlatDataGridViewTextBoxColumn";
            this.quantidadeItemPlatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomePlataformaDataGridViewTextBoxColumn
            // 
            this.nomePlataformaDataGridViewTextBoxColumn.DataPropertyName = "nomePlataforma";
            this.nomePlataformaDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.nomePlataformaDataGridViewTextBoxColumn.Name = "nomePlataformaDataGridViewTextBoxColumn";
            this.nomePlataformaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantTotalProdDataGridViewTextBoxColumn
            // 
            this.quantTotalProdDataGridViewTextBoxColumn.DataPropertyName = "quantTotalProd";
            this.quantTotalProdDataGridViewTextBoxColumn.HeaderText = "Quantidade Total Produto";
            this.quantTotalProdDataGridViewTextBoxColumn.Name = "quantTotalProdDataGridViewTextBoxColumn";
            this.quantTotalProdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimentacaoDataGridViewTextBoxColumn
            // 
            this.movimentacaoDataGridViewTextBoxColumn.DataPropertyName = "movimentacao";
            this.movimentacaoDataGridViewTextBoxColumn.HeaderText = "Movimentacao";
            this.movimentacaoDataGridViewTextBoxColumn.Name = "movimentacaoDataGridViewTextBoxColumn";
            this.movimentacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idBarcoDataGridViewTextBoxColumn
            // 
            this.idBarcoDataGridViewTextBoxColumn.DataPropertyName = "idBarco";
            this.idBarcoDataGridViewTextBoxColumn.HeaderText = "Nº Barco";
            this.idBarcoDataGridViewTextBoxColumn.Name = "idBarcoDataGridViewTextBoxColumn";
            this.idBarcoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeBarcoDataGridViewTextBoxColumn
            // 
            this.nomeBarcoDataGridViewTextBoxColumn.DataPropertyName = "nomeBarco";
            this.nomeBarcoDataGridViewTextBoxColumn.HeaderText = "Barco";
            this.nomeBarcoDataGridViewTextBoxColumn.Name = "nomeBarcoDataGridViewTextBoxColumn";
            this.nomeBarcoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(414, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 43);
            this.label1.TabIndex = 47;
            this.label1.Text = "Estoque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(68, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pesquisar Por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nº Linha Estoque",
            "Nº Plataforma",
            "Nº Produto",
            "Quant Na Plataforma",
            "Produto",
            "Plataforma",
            "Quantidade Total Produto",
            "Movimentação",
            "Nº Barco",
            "Barco"});
            this.comboBox1.Location = new System.Drawing.Point(235, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(504, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Texto Pesquisa:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CampoPesquisa
            // 
            this.CampoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CampoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampoPesquisa.Location = new System.Drawing.Point(696, 146);
            this.CampoPesquisa.Name = "CampoPesquisa";
            this.CampoPesquisa.Size = new System.Drawing.Size(140, 30);
            this.CampoPesquisa.TabIndex = 51;
            this.CampoPesquisa.TextChanged += new System.EventHandler(this.CampoPesquisa_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 52;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Painel_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CampoPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Painel_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel_Estoque";
            this.Load += new System.EventHandler(this.Painel_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private basetesteDataSet basetesteDataSet;
        private System.Windows.Forms.BindingSource basetesteDataSetBindingSource;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private basetesteDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private basetesteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLinhaEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeItemPlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePlataformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantTotalProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeBarcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CampoPesquisa;
        private System.Windows.Forms.Button button3;
    }
}