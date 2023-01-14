namespace RaftEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Modo = new System.Windows.Forms.Label();
            this.Cb_Modos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Lb_Msg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(180, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.abrirToolStripMenuItem.Text = "Selecionar .rgd";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODO ATUAL:";
            // 
            // Lb_Modo
            // 
            this.Lb_Modo.AutoSize = true;
            this.Lb_Modo.Location = new System.Drawing.Point(91, 88);
            this.Lb_Modo.Name = "Lb_Modo";
            this.Lb_Modo.Size = new System.Drawing.Size(46, 13);
            this.Lb_Modo.TabIndex = 2;
            this.Lb_Modo.Text = "<Modo>";
            // 
            // Cb_Modos
            // 
            this.Cb_Modos.FormattingEnabled = true;
            this.Cb_Modos.Location = new System.Drawing.Point(12, 48);
            this.Cb_Modos.Name = "Cb_Modos";
            this.Cb_Modos.Size = new System.Drawing.Size(156, 21);
            this.Cb_Modos.TabIndex = 3;
            this.Cb_Modos.SelectedIndexChanged += new System.EventHandler(this.Cb_Modos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modos";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(93, 134);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 5;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Lb_Msg
            // 
            this.Lb_Msg.AutoSize = true;
            this.Lb_Msg.Location = new System.Drawing.Point(69, 106);
            this.Lb_Msg.Name = "Lb_Msg";
            this.Lb_Msg.Size = new System.Drawing.Size(100, 13);
            this.Lb_Msg.TabIndex = 6;
            this.Lb_Msg.Text = "Nenhuma mudança";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Depurador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(180, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_Msg);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_Modos);
            this.Controls.Add(this.Lb_Modo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor - Raft Survive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Modo;
        private System.Windows.Forms.ComboBox Cb_Modos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Label Lb_Msg;
        private System.Windows.Forms.Label label3;
    }
}

