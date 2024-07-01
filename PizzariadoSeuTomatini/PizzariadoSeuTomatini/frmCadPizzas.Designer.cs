
namespace PizzariadoSeuTomatini
{
    partial class frmCadPizzas
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
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.cmbTipoPizzas = new System.Windows.Forms.ComboBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.lblComposicao = new System.Windows.Forms.Label();
            this.txtComposicao = new System.Windows.Forms.TextBox();
            this.grpbPermiteBorda = new System.Windows.Forms.GroupBox();
            this.rdBordaNao = new System.Windows.Forms.RadioButton();
            this.rdBordaSim = new System.Windows.Forms.RadioButton();
            this.grpbTipoBordas = new System.Windows.Forms.GroupBox();
            this.chkBordaMista = new System.Windows.Forms.CheckBox();
            this.chkBordaVulcao = new System.Windows.Forms.CheckBox();
            this.chkBordaCatupiry = new System.Windows.Forms.CheckBox();
            this.chkBordaCheddar = new System.Windows.Forms.CheckBox();
            this.grpbTamanhoPizza = new System.Windows.Forms.GroupBox();
            this.chkTamanhoFamilia = new System.Windows.Forms.CheckBox();
            this.chkTamanhoPequena = new System.Windows.Forms.CheckBox();
            this.lblValorPequena = new System.Windows.Forms.Label();
            this.txtValorTamanhoPequena = new System.Windows.Forms.TextBox();
            this.txtValorTamanhoFamilia = new System.Windows.Forms.TextBox();
            this.lblValorFamilia = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListarPizzas = new System.Windows.Forms.Button();
            this.grpbPermiteBorda.SuspendLayout();
            this.grpbTipoBordas.SuspendLayout();
            this.grpbTamanhoPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPizza.Location = new System.Drawing.Point(12, 16);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(163, 27);
            this.lblTipoPizza.TabIndex = 0;
            this.lblTipoPizza.Text = "Tipo da Pizza:";
            // 
            // cmbTipoPizzas
            // 
            this.cmbTipoPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPizzas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPizzas.FormattingEnabled = true;
            this.cmbTipoPizzas.Items.AddRange(new object[] {
            "Doce",
            "Salgada"});
            this.cmbTipoPizzas.Location = new System.Drawing.Point(181, 8);
            this.cmbTipoPizzas.Name = "cmbTipoPizzas";
            this.cmbTipoPizzas.Size = new System.Drawing.Size(188, 35);
            this.cmbTipoPizzas.TabIndex = 1;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(12, 69);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(83, 27);
            this.lblSabor.TabIndex = 2;
            this.lblSabor.Text = "Sabor:";
            // 
            // txtSabor
            // 
            this.txtSabor.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabor.Location = new System.Drawing.Point(101, 62);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(362, 34);
            this.txtSabor.TabIndex = 3;
            // 
            // lblComposicao
            // 
            this.lblComposicao.AutoSize = true;
            this.lblComposicao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposicao.Location = new System.Drawing.Point(12, 105);
            this.lblComposicao.Name = "lblComposicao";
            this.lblComposicao.Size = new System.Drawing.Size(151, 27);
            this.lblComposicao.TabIndex = 4;
            this.lblComposicao.Text = "Composição:";
            // 
            // txtComposicao
            // 
            this.txtComposicao.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComposicao.Location = new System.Drawing.Point(17, 135);
            this.txtComposicao.Multiline = true;
            this.txtComposicao.Name = "txtComposicao";
            this.txtComposicao.Size = new System.Drawing.Size(446, 69);
            this.txtComposicao.TabIndex = 5;
            // 
            // grpbPermiteBorda
            // 
            this.grpbPermiteBorda.Controls.Add(this.rdBordaNao);
            this.grpbPermiteBorda.Controls.Add(this.rdBordaSim);
            this.grpbPermiteBorda.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPermiteBorda.Location = new System.Drawing.Point(17, 210);
            this.grpbPermiteBorda.Name = "grpbPermiteBorda";
            this.grpbPermiteBorda.Size = new System.Drawing.Size(446, 78);
            this.grpbPermiteBorda.TabIndex = 6;
            this.grpbPermiteBorda.TabStop = false;
            this.grpbPermiteBorda.Text = "A Pizza permite adicionar Borda?";
            // 
            // rdBordaNao
            // 
            this.rdBordaNao.AutoSize = true;
            this.rdBordaNao.Location = new System.Drawing.Point(194, 33);
            this.rdBordaNao.Name = "rdBordaNao";
            this.rdBordaNao.Size = new System.Drawing.Size(70, 33);
            this.rdBordaNao.TabIndex = 1;
            this.rdBordaNao.Text = "Não";
            this.rdBordaNao.UseVisualStyleBackColor = true;
            this.rdBordaNao.CheckedChanged += new System.EventHandler(this.rdBordaNao_CheckedChanged);
            // 
            // rdBordaSim
            // 
            this.rdBordaSim.AutoSize = true;
            this.rdBordaSim.Checked = true;
            this.rdBordaSim.Location = new System.Drawing.Point(52, 33);
            this.rdBordaSim.Name = "rdBordaSim";
            this.rdBordaSim.Size = new System.Drawing.Size(67, 33);
            this.rdBordaSim.TabIndex = 0;
            this.rdBordaSim.TabStop = true;
            this.rdBordaSim.Text = "Sim";
            this.rdBordaSim.UseVisualStyleBackColor = true;
            this.rdBordaSim.CheckedChanged += new System.EventHandler(this.rdBordaSim_CheckedChanged);
            // 
            // grpbTipoBordas
            // 
            this.grpbTipoBordas.Controls.Add(this.chkBordaMista);
            this.grpbTipoBordas.Controls.Add(this.chkBordaVulcao);
            this.grpbTipoBordas.Controls.Add(this.chkBordaCatupiry);
            this.grpbTipoBordas.Controls.Add(this.chkBordaCheddar);
            this.grpbTipoBordas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTipoBordas.Location = new System.Drawing.Point(17, 294);
            this.grpbTipoBordas.Name = "grpbTipoBordas";
            this.grpbTipoBordas.Size = new System.Drawing.Size(446, 193);
            this.grpbTipoBordas.TabIndex = 7;
            this.grpbTipoBordas.TabStop = false;
            this.grpbTipoBordas.Text = "Tipos de Borda que a Pizza aceita";
            // 
            // chkBordaMista
            // 
            this.chkBordaMista.AutoSize = true;
            this.chkBordaMista.Location = new System.Drawing.Point(6, 150);
            this.chkBordaMista.Name = "chkBordaMista";
            this.chkBordaMista.Size = new System.Drawing.Size(321, 33);
            this.chkBordaMista.TabIndex = 3;
            this.chkBordaMista.Text = "Borda Mista (cheddar + catupiry)";
            this.chkBordaMista.UseVisualStyleBackColor = true;
            // 
            // chkBordaVulcao
            // 
            this.chkBordaVulcao.AutoSize = true;
            this.chkBordaVulcao.Location = new System.Drawing.Point(6, 111);
            this.chkBordaVulcao.Name = "chkBordaVulcao";
            this.chkBordaVulcao.Size = new System.Drawing.Size(153, 33);
            this.chkBordaVulcao.TabIndex = 2;
            this.chkBordaVulcao.Text = "Borda Vulcão";
            this.chkBordaVulcao.UseVisualStyleBackColor = true;
            // 
            // chkBordaCatupiry
            // 
            this.chkBordaCatupiry.AutoSize = true;
            this.chkBordaCatupiry.Location = new System.Drawing.Point(6, 72);
            this.chkBordaCatupiry.Name = "chkBordaCatupiry";
            this.chkBordaCatupiry.Size = new System.Drawing.Size(264, 33);
            this.chkBordaCatupiry.TabIndex = 1;
            this.chkBordaCatupiry.Text = "Borda de Catupiry Original";
            this.chkBordaCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkBordaCheddar
            // 
            this.chkBordaCheddar.AutoSize = true;
            this.chkBordaCheddar.Location = new System.Drawing.Point(6, 33);
            this.chkBordaCheddar.Name = "chkBordaCheddar";
            this.chkBordaCheddar.Size = new System.Drawing.Size(196, 33);
            this.chkBordaCheddar.TabIndex = 0;
            this.chkBordaCheddar.Text = "Borda de Cheddar";
            this.chkBordaCheddar.UseVisualStyleBackColor = true;
            // 
            // grpbTamanhoPizza
            // 
            this.grpbTamanhoPizza.Controls.Add(this.chkTamanhoFamilia);
            this.grpbTamanhoPizza.Controls.Add(this.chkTamanhoPequena);
            this.grpbTamanhoPizza.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTamanhoPizza.Location = new System.Drawing.Point(17, 493);
            this.grpbTamanhoPizza.Name = "grpbTamanhoPizza";
            this.grpbTamanhoPizza.Size = new System.Drawing.Size(446, 76);
            this.grpbTamanhoPizza.TabIndex = 8;
            this.grpbTamanhoPizza.TabStop = false;
            this.grpbTamanhoPizza.Text = "Em qual tamanho(s) a Pizza será vendida?";
            // 
            // chkTamanhoFamilia
            // 
            this.chkTamanhoFamilia.AutoSize = true;
            this.chkTamanhoFamilia.Location = new System.Drawing.Point(255, 33);
            this.chkTamanhoFamilia.Name = "chkTamanhoFamilia";
            this.chkTamanhoFamilia.Size = new System.Drawing.Size(97, 33);
            this.chkTamanhoFamilia.TabIndex = 1;
            this.chkTamanhoFamilia.Text = "Família";
            this.chkTamanhoFamilia.UseVisualStyleBackColor = true;
            this.chkTamanhoFamilia.CheckedChanged += new System.EventHandler(this.chkTamanhoFamilia_CheckedChanged);
            // 
            // chkTamanhoPequena
            // 
            this.chkTamanhoPequena.AutoSize = true;
            this.chkTamanhoPequena.Location = new System.Drawing.Point(32, 33);
            this.chkTamanhoPequena.Name = "chkTamanhoPequena";
            this.chkTamanhoPequena.Size = new System.Drawing.Size(114, 33);
            this.chkTamanhoPequena.TabIndex = 0;
            this.chkTamanhoPequena.Text = "Pequena";
            this.chkTamanhoPequena.UseVisualStyleBackColor = true;
            this.chkTamanhoPequena.CheckedChanged += new System.EventHandler(this.chkTamanhoPequena_CheckedChanged);
            // 
            // lblValorPequena
            // 
            this.lblValorPequena.AutoSize = true;
            this.lblValorPequena.Enabled = false;
            this.lblValorPequena.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPequena.Location = new System.Drawing.Point(18, 584);
            this.lblValorPequena.Name = "lblValorPequena";
            this.lblValorPequena.Size = new System.Drawing.Size(281, 27);
            this.lblValorPequena.TabIndex = 9;
            this.lblValorPequena.Text = "Valor Tamanho Pequena:";
            // 
            // txtValorTamanhoPequena
            // 
            this.txtValorTamanhoPequena.Enabled = false;
            this.txtValorTamanhoPequena.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTamanhoPequena.Location = new System.Drawing.Point(305, 575);
            this.txtValorTamanhoPequena.Name = "txtValorTamanhoPequena";
            this.txtValorTamanhoPequena.Size = new System.Drawing.Size(100, 34);
            this.txtValorTamanhoPequena.TabIndex = 10;
            // 
            // txtValorTamanhoFamilia
            // 
            this.txtValorTamanhoFamilia.Enabled = false;
            this.txtValorTamanhoFamilia.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTamanhoFamilia.Location = new System.Drawing.Point(305, 620);
            this.txtValorTamanhoFamilia.Name = "txtValorTamanhoFamilia";
            this.txtValorTamanhoFamilia.Size = new System.Drawing.Size(100, 34);
            this.txtValorTamanhoFamilia.TabIndex = 12;
            // 
            // lblValorFamilia
            // 
            this.lblValorFamilia.AutoSize = true;
            this.lblValorFamilia.Enabled = false;
            this.lblValorFamilia.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFamilia.Location = new System.Drawing.Point(18, 627);
            this.lblValorFamilia.Name = "lblValorFamilia";
            this.lblValorFamilia.Size = new System.Drawing.Size(262, 27);
            this.lblValorFamilia.TabIndex = 11;
            this.lblValorFamilia.Text = "Valor Tamanho Família:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(17, 664);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(181, 38);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListarPizzas
            // 
            this.btnListarPizzas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPizzas.Location = new System.Drawing.Point(272, 664);
            this.btnListarPizzas.Name = "btnListarPizzas";
            this.btnListarPizzas.Size = new System.Drawing.Size(181, 38);
            this.btnListarPizzas.TabIndex = 14;
            this.btnListarPizzas.Text = "LISTAR PIZZAS";
            this.btnListarPizzas.UseVisualStyleBackColor = true;
            this.btnListarPizzas.Click += new System.EventHandler(this.btnListarPizzas_Click);
            // 
            // frmCadPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 714);
            this.Controls.Add(this.btnListarPizzas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorTamanhoFamilia);
            this.Controls.Add(this.lblValorFamilia);
            this.Controls.Add(this.txtValorTamanhoPequena);
            this.Controls.Add(this.lblValorPequena);
            this.Controls.Add(this.grpbTamanhoPizza);
            this.Controls.Add(this.grpbTipoBordas);
            this.Controls.Add(this.grpbPermiteBorda);
            this.Controls.Add(this.txtComposicao);
            this.Controls.Add(this.lblComposicao);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.cmbTipoPizzas);
            this.Controls.Add(this.lblTipoPizza);
            this.Name = "frmCadPizzas";
            this.Text = "Cadastro de Pizzas";
            this.grpbPermiteBorda.ResumeLayout(false);
            this.grpbPermiteBorda.PerformLayout();
            this.grpbTipoBordas.ResumeLayout(false);
            this.grpbTipoBordas.PerformLayout();
            this.grpbTamanhoPizza.ResumeLayout(false);
            this.grpbTamanhoPizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.ComboBox cmbTipoPizzas;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Label lblComposicao;
        private System.Windows.Forms.TextBox txtComposicao;
        private System.Windows.Forms.GroupBox grpbPermiteBorda;
        private System.Windows.Forms.RadioButton rdBordaNao;
        private System.Windows.Forms.RadioButton rdBordaSim;
        private System.Windows.Forms.GroupBox grpbTipoBordas;
        private System.Windows.Forms.CheckBox chkBordaMista;
        private System.Windows.Forms.CheckBox chkBordaVulcao;
        private System.Windows.Forms.CheckBox chkBordaCatupiry;
        private System.Windows.Forms.CheckBox chkBordaCheddar;
        private System.Windows.Forms.GroupBox grpbTamanhoPizza;
        private System.Windows.Forms.CheckBox chkTamanhoFamilia;
        private System.Windows.Forms.CheckBox chkTamanhoPequena;
        private System.Windows.Forms.Label lblValorPequena;
        private System.Windows.Forms.TextBox txtValorTamanhoPequena;
        private System.Windows.Forms.TextBox txtValorTamanhoFamilia;
        private System.Windows.Forms.Label lblValorFamilia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListarPizzas;
    }
}

