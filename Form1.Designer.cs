namespace Academia_GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReceitasDespesas = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnAlunos = new FontAwesome.Sharp.IconButton();
            this.btnFuncionarios = new FontAwesome.Sharp.IconButton();
            this.btnPlanos = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDescktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDescktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnReceitasDespesas);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnAlunos);
            this.panelMenu.Controls.Add(this.btnFuncionarios);
            this.panelMenu.Controls.Add(this.btnPlanos);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 567);
            this.panelMenu.TabIndex = 1;
            // 
            // btnReceitasDespesas
            // 
            this.btnReceitasDespesas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceitasDespesas.FlatAppearance.BorderSize = 0;
            this.btnReceitasDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitasDespesas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReceitasDespesas.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.btnReceitasDespesas.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReceitasDespesas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceitasDespesas.IconSize = 32;
            this.btnReceitasDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitasDespesas.Location = new System.Drawing.Point(0, 440);
            this.btnReceitasDespesas.Name = "btnReceitasDespesas";
            this.btnReceitasDespesas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReceitasDespesas.Size = new System.Drawing.Size(220, 60);
            this.btnReceitasDespesas.TabIndex = 6;
            this.btnReceitasDespesas.Text = "Receitas/Despesas";
            this.btnReceitasDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitasDespesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceitasDespesas.UseVisualStyleBackColor = true;
            this.btnReceitasDespesas.Click += new System.EventHandler(this.btnReceitasDespesas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btnInventario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 32;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 380);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 60);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlunos.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnAlunos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAlunos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlunos.IconSize = 32;
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(0, 320);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlunos.Size = new System.Drawing.Size(220, 60);
            this.btnAlunos.TabIndex = 4;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionarios.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnFuncionarios.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFuncionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuncionarios.IconSize = 32;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 260);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(220, 60);
            this.btnFuncionarios.TabIndex = 3;
            this.btnFuncionarios.Text = "Funcionarios";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnPlanos
            // 
            this.btnPlanos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanos.FlatAppearance.BorderSize = 0;
            this.btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlanos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnPlanos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlanos.IconSize = 32;
            this.btnPlanos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanos.Location = new System.Drawing.Point(0, 200);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlanos.Size = new System.Drawing.Size(220, 60);
            this.btnPlanos.TabIndex = 2;
            this.btnPlanos.Text = "Planos";
            this.btnPlanos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanos.UseVisualStyleBackColor = true;
            this.btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 112);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.iconMinimize);
            this.panelTitle.Controls.Add(this.iconMaximize);
            this.panelTitle.Controls.Add(this.iconExit);
            this.panelTitle.Controls.Add(this.lblTitleChildForm);
            this.panelTitle.Controls.Add(this.iconCurrentChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(877, 80);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 23;
            this.iconMinimize.Location = new System.Drawing.Point(784, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(27, 23);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximize.IconSize = 23;
            this.iconMaximize.Location = new System.Drawing.Point(817, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(27, 23);
            this.iconMaximize.TabIndex = 3;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 23;
            this.iconExit.Location = new System.Drawing.Point(850, 3);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(27, 23);
            this.iconExit.TabIndex = 2;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(79, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(41, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(877, 9);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDescktop
            // 
            this.panelDescktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDescktop.Controls.Add(this.pictureBox1);
            this.panelDescktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescktop.Location = new System.Drawing.Point(220, 89);
            this.panelDescktop.Name = "panelDescktop";
            this.panelDescktop.Size = new System.Drawing.Size(877, 478);
            this.panelDescktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 567);
            this.Controls.Add(this.panelDescktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "GERENCIAMENTO ACADEMIA";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDescktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnReceitasDespesas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnAlunos;
        private FontAwesome.Sharp.IconButton btnFuncionarios;
        private FontAwesome.Sharp.IconButton btnPlanos;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDescktop;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

