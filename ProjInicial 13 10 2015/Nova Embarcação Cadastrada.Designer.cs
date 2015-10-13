using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjInicial
{
    partial class Nova_Embarcação_Cadastrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nova_Embarcação_Cadastrada));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basetesteDataSet = new ProjInicial.basetesteDataSet();
            this.barcosTableAdapter = new ProjInicial.basetesteDataSetTableAdapters.barcosTableAdapter();
            this.idBarcosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrBarcosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcoslocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjInicial.Properties.Resources.Logo_Fenix;
            this.pictureBox2.Location = new System.Drawing.Point(784, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarcosDataGridViewTextBoxColumn,
            this.descrBarcosDataGridViewTextBoxColumn,
            this.barcoslocalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.barcosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(61, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(343, 178);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // idBarcosDataGridViewTextBoxColumn
            // 
            this.idBarcosDataGridViewTextBoxColumn.DataPropertyName = "idBarcos";
            this.idBarcosDataGridViewTextBoxColumn.HeaderText = "Número";
            this.idBarcosDataGridViewTextBoxColumn.Name = "idBarcosDataGridViewTextBoxColumn";
            this.idBarcosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrBarcosDataGridViewTextBoxColumn
            // 
            this.descrBarcosDataGridViewTextBoxColumn.DataPropertyName = "descrBarcos";
            this.descrBarcosDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.descrBarcosDataGridViewTextBoxColumn.Name = "descrBarcosDataGridViewTextBoxColumn";
            this.descrBarcosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcoslocalDataGridViewTextBoxColumn
            // 
            this.barcoslocalDataGridViewTextBoxColumn.DataPropertyName = "barcoslocal";
            this.barcoslocalDataGridViewTextBoxColumn.HeaderText = "Localização";
            this.barcoslocalDataGridViewTextBoxColumn.Name = "barcoslocalDataGridViewTextBoxColumn";
            this.barcoslocalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nova_Embarcação_Cadastrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Nova_Embarcação_Cadastrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova_Embarcação_Cadastrada";
            this.Load += new System.EventHandler(this.Nova_Embarcação_Cadastrada_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basetesteDataSet)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    //    private System.Windows.Forms.DataGridView dataGridView1;

      /*  public void carregarEmbarcacoesCadastradas()
        {
            DataSet meuDataSet = new DataSet();
            Barco b2 = new Barco();
            b2.connectionBarcos();
            MySqlCommand queryBarcos = new MySqlCommand();
            queryBarcos.CommandText = "Select * from barcos;";
            MySqlDataReader leitor = queryBarcos.ExecuteReader();
            MySqlDataAdapter adapter = new MySqlDataAdapter(queryBarcos);
           
            //preenche o dataset via adapter
            adapter.Fill(meuDataSet, "Nome Qualquer");
            //atribui a resultado a propriedade DataSource do DataGrid
            dataGridView1.DataSource = meuDataSet;
            dataGridView1.DataMember = "Nome Qualquer";
                
        }*/

        private DataGridView dataGridView2;
        private basetesteDataSet basetesteDataSet;
        private BindingSource barcosBindingSource;
        private basetesteDataSetTableAdapters.barcosTableAdapter barcosTableAdapter;
        private DataGridViewTextBoxColumn idBarcosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descrBarcosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcoslocalDataGridViewTextBoxColumn;
           
    
    
    
    
    
    
    
    
    
    }
}