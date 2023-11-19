namespace InventoryMangm
{
    partial class ManageProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QtyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ProductIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DescriptionTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductsGV = new Guna.UI.WinForms.GunaDataGridView();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 100);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1071, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Organização de Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Organizador de Estoque";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 15);
            this.panel2.TabIndex = 20;
            // 
            // PriceTb
            // 
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTb.HintText = "";
            this.PriceTb.isPassword = false;
            this.PriceTb.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.PriceTb.LineIdleColor = System.Drawing.Color.Lavender;
            this.PriceTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.PriceTb.LineThickness = 4;
            this.PriceTb.Location = new System.Drawing.Point(33, 254);
            this.PriceTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(183, 33);
            this.PriceTb.TabIndex = 24;
            this.PriceTb.Text = "Preço do Produto";
            this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtyTb.HintForeColor = System.Drawing.Color.Empty;
            this.QtyTb.HintText = "";
            this.QtyTb.isPassword = false;
            this.QtyTb.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.QtyTb.LineIdleColor = System.Drawing.Color.Lavender;
            this.QtyTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.QtyTb.LineThickness = 4;
            this.QtyTb.Location = new System.Drawing.Point(33, 213);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(183, 33);
            this.QtyTb.TabIndex = 23;
            this.QtyTb.Text = "Quantidade do Produto";
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductNameTb.HintText = "";
            this.ProductNameTb.isPassword = false;
            this.ProductNameTb.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.ProductNameTb.LineIdleColor = System.Drawing.Color.Lavender;
            this.ProductNameTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.ProductNameTb.LineThickness = 4;
            this.ProductNameTb.Location = new System.Drawing.Point(33, 172);
            this.ProductNameTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.Size = new System.Drawing.Size(183, 33);
            this.ProductNameTb.TabIndex = 22;
            this.ProductNameTb.Text = "Nome do Produto";
            this.ProductNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductIdTb
            // 
            this.ProductIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductIdTb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProductIdTb.HintText = "";
            this.ProductIdTb.isPassword = false;
            this.ProductIdTb.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.ProductIdTb.LineIdleColor = System.Drawing.Color.Lavender;
            this.ProductIdTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.ProductIdTb.LineThickness = 4;
            this.ProductIdTb.Location = new System.Drawing.Point(33, 131);
            this.ProductIdTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ProductIdTb.Name = "ProductIdTb";
            this.ProductIdTb.Size = new System.Drawing.Size(183, 33);
            this.ProductIdTb.TabIndex = 21;
            this.ProductIdTb.Text = "ID do Produto";
            this.ProductIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionTb.HintForeColor = System.Drawing.Color.Empty;
            this.DescriptionTb.HintText = "";
            this.DescriptionTb.isPassword = false;
            this.DescriptionTb.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.DescriptionTb.LineIdleColor = System.Drawing.Color.Lavender;
            this.DescriptionTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.DescriptionTb.LineThickness = 4;
            this.DescriptionTb.Location = new System.Drawing.Point(33, 295);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(183, 33);
            this.DescriptionTb.TabIndex = 25;
            this.DescriptionTb.Text = "Descrição do Produto";
            this.DescriptionTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(33, 344);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(183, 27);
            this.CatCombo.TabIndex = 26;
            this.CatCombo.Text = " Categoria do Produto";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(129, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(222, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGV.EnableHeadersVisualStyles = false;
            this.ProductsGV.GridColor = System.Drawing.Color.Lavender;
            this.ProductsGV.Location = new System.Drawing.Point(386, 156);
            this.ProductsGV.Name = "ProductsGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsGV.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductsGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.ProductsGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.ProductsGV.RowTemplate.Height = 30;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(677, 445);
            this.ProductsGV.TabIndex = 31;
            this.ProductsGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Transparent;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Transparent;
            this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.Lavender;
            this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Lavender;
            this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProductsGV.ThemeStyle.ReadOnly = false;
            this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductsGV.ThemeStyle.RowsStyle.Height = 30;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Transparent;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(634, 111);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(183, 27);
            this.SearchCombo.TabIndex = 32;
            this.SearchCombo.Text = "Selecione a Categoria";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(823, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 34);
            this.button5.TabIndex = 33;
            this.button5.Text = "Procurar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(916, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 34);
            this.button6.TabIndex = 34;
            this.button6.Text = "Limpar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.ProductNameTb);
            this.Controls.Add(this.ProductIdTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QtyTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DescriptionTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaDataGridView ProductsGV;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}