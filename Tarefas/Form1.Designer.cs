namespace Tarefas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkedListBoxTarefas = new CheckedListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnCarregar = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            txtTarefa = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            pictureBox1 = new PictureBox();
            btnSait = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBoxTarefas
            // 
            checkedListBoxTarefas.BackColor = Color.LightCoral;
            checkedListBoxTarefas.Cursor = Cursors.Hand;
            checkedListBoxTarefas.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            checkedListBoxTarefas.ForeColor = Color.White;
            checkedListBoxTarefas.FormattingEnabled = true;
            checkedListBoxTarefas.HorizontalScrollbar = true;
            checkedListBoxTarefas.ImeMode = ImeMode.NoControl;
            checkedListBoxTarefas.Location = new Point(392, 96);
            checkedListBoxTarefas.Margin = new Padding(4, 3, 4, 3);
            checkedListBoxTarefas.Name = "checkedListBoxTarefas";
            checkedListBoxTarefas.Size = new Size(432, 524);
            checkedListBoxTarefas.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.IndianRed;
            btnAdicionar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(15, 176);
            btnAdicionar.Margin = new Padding(4, 3, 4, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(354, 48);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar tarefa";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.IndianRed;
            btnRemover.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(15, 296);
            btnRemover.Margin = new Padding(4, 3, 4, 3);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(354, 48);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover tarefa";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.BackColor = Color.IndianRed;
            btnCarregar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnCarregar.ForeColor = Color.White;
            btnCarregar.Location = new Point(15, 412);
            btnCarregar.Margin = new Padding(4, 3, 4, 3);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(354, 48);
            btnCarregar.TabIndex = 3;
            btnCarregar.Text = "Carregar tarefas";
            btnCarregar.UseVisualStyleBackColor = false;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.IndianRed;
            btnLimpar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(15, 521);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(354, 48);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar tudo";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Salmon;
            label1.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 23);
            label1.TabIndex = 5;
            label1.Text = "Digite uma nova tarefa abaixo:";
            // 
            // txtTarefa
            // 
            txtTarefa.BackColor = Color.Salmon;
            txtTarefa.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTarefa.ForeColor = Color.White;
            txtTarefa.Location = new Point(15, 96);
            txtTarefa.Margin = new Padding(4, 3, 4, 3);
            txtTarefa.Multiline = true;
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(352, 62);
            txtTarefa.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 233);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(326, 58);
            label2.TabIndex = 7;
            label2.Text = "Selecione a tarefa que deseja remover na lista";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.IndianRed;
            btnSalvar.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(15, 467);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(354, 48);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar tudo";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.um_bloco_de_notas_com_um_check_list_sendo_marcado_e_um_estilo_animado__cor_principal_salmon;
            pictureBox1.Image = Properties.Resources.um_bloco_de_notas_com_um_check_list_sendo_marcado_e_um_estilo_animado__cor_principal_salmon;
            pictureBox1.InitialImage = Properties.Resources.um_bloco_de_notas_com_um_check_list_sendo_marcado_e_um_estilo_animado__cor_principal_salmon;
            pictureBox1.Location = new Point(392, -270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnSait
            // 
            btnSait.BackColor = Color.IndianRed;
            btnSait.Font = new Font("Ink Free", 14.25F, FontStyle.Bold);
            btnSait.ForeColor = Color.White;
            btnSait.Location = new Point(15, 575);
            btnSait.Margin = new Padding(4, 3, 4, 3);
            btnSait.Name = "btnSait";
            btnSait.Size = new Size(354, 48);
            btnSait.TabIndex = 10;
            btnSait.Text = "Sair";
            btnSait.UseVisualStyleBackColor = false;
            btnSait.Click += btnSait_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Salmon;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(841, 647);
            Controls.Add(btnSait);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtTarefa);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnCarregar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(checkedListBoxTarefas);
            Controls.Add(pictureBox1);
            Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas";
            TransparencyKey = Color.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxTarefas;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnCarregar;
        private Button btnLimpar;
        private Label label1;
        private TextBox txtTarefa;
        private Label label2;
        private Button btnSalvar;
        private PictureBox pictureBox1;
        private Button btnSait;
    }
}
