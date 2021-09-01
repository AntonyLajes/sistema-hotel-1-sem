
namespace ProjetoHotel.Apresentacao
{
    partial class BemVindo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.exibirClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.editarClienteToolStripMenuItem,
            this.excluirClienteToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.exibirClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o Programa";
            this.sobreOProgramaToolStripMenuItem.Click += new System.EventHandler(this.sobreOProgramaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarClienteToolStripMenuItem.Click += new System.EventHandler(this.editarClienteToolStripMenuItem_Click);
            // 
            // excluirClienteToolStripMenuItem
            // 
            this.excluirClienteToolStripMenuItem.Name = "excluirClienteToolStripMenuItem";
            this.excluirClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirClienteToolStripMenuItem.Text = "Excluir Cliente";
            this.excluirClienteToolStripMenuItem.Click += new System.EventHandler(this.excluirClienteToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 27);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(336, 224);
            this.dgvDados.TabIndex = 1;
            // 
            // exibirClientesToolStripMenuItem
            // 
            this.exibirClientesToolStripMenuItem.Name = "exibirClientesToolStripMenuItem";
            this.exibirClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirClientesToolStripMenuItem.Text = "Exibir Clientes";
            this.exibirClientesToolStripMenuItem.Click += new System.EventHandler(this.exibirClientesToolStripMenuItem_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 263);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStripMenuItem exibirClientesToolStripMenuItem;
    }
}