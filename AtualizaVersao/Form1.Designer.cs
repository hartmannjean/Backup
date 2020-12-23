namespace AtualizaVersao
{
    partial class frmAtualizaVersao
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.checkBox_SIGDelta = new System.Windows.Forms.CheckBox();
            this.checkBox_DeltaNFe = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_OCX = new System.Windows.Forms.CheckBox();
            this.checkBox_SefazDLL = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_EnviarBackupNuvem = new System.Windows.Forms.CheckBox();
            this.checkBox_EnviarBackupPendrive = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_EmailCliente = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarConnetion = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(6, 143);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(297, 37);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Baixar Atualizações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // checkBox_SIGDelta
            // 
            this.checkBox_SIGDelta.AutoSize = true;
            this.checkBox_SIGDelta.Location = new System.Drawing.Point(6, 19);
            this.checkBox_SIGDelta.Name = "checkBox_SIGDelta";
            this.checkBox_SIGDelta.Size = new System.Drawing.Size(69, 17);
            this.checkBox_SIGDelta.TabIndex = 1;
            this.checkBox_SIGDelta.Text = "SIGDelta";
            this.checkBox_SIGDelta.UseVisualStyleBackColor = true;
            // 
            // checkBox_DeltaNFe
            // 
            this.checkBox_DeltaNFe.AutoSize = true;
            this.checkBox_DeltaNFe.Location = new System.Drawing.Point(6, 42);
            this.checkBox_DeltaNFe.Name = "checkBox_DeltaNFe";
            this.checkBox_DeltaNFe.Size = new System.Drawing.Size(71, 17);
            this.checkBox_DeltaNFe.TabIndex = 2;
            this.checkBox_DeltaNFe.Text = "DeltaNFe";
            this.checkBox_DeltaNFe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_OCX);
            this.groupBox1.Controls.Add(this.checkBox_SefazDLL);
            this.groupBox1.Controls.Add(this.checkBox_DeltaNFe);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.checkBox_SIGDelta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualização";
            // 
            // checkBox_OCX
            // 
            this.checkBox_OCX.AutoSize = true;
            this.checkBox_OCX.Location = new System.Drawing.Point(6, 88);
            this.checkBox_OCX.Name = "checkBox_OCX";
            this.checkBox_OCX.Size = new System.Drawing.Size(48, 17);
            this.checkBox_OCX.TabIndex = 4;
            this.checkBox_OCX.Text = "OCX";
            this.checkBox_OCX.UseVisualStyleBackColor = true;
            // 
            // checkBox_SefazDLL
            // 
            this.checkBox_SefazDLL.AutoSize = true;
            this.checkBox_SefazDLL.Location = new System.Drawing.Point(6, 65);
            this.checkBox_SefazDLL.Name = "checkBox_SefazDLL";
            this.checkBox_SefazDLL.Size = new System.Drawing.Size(76, 17);
            this.checkBox_SefazDLL.TabIndex = 3;
            this.checkBox_SefazDLL.Text = "Sefaz DLL";
            this.checkBox_SefazDLL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_EmailCliente);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox_EnviarBackupPendrive);
            this.groupBox2.Controls.Add(this.checkBox_EnviarBackupNuvem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnGerarBackup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // btnGerarBackup
            // 
            this.btnGerarBackup.Location = new System.Drawing.Point(6, 143);
            this.btnGerarBackup.Name = "btnGerarBackup";
            this.btnGerarBackup.Size = new System.Drawing.Size(303, 37);
            this.btnGerarBackup.TabIndex = 1;
            this.btnGerarBackup.Text = "Gerar Backup";
            this.btnGerarBackup.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações do último backup: 15/12/2020 - 11:45:14";
            // 
            // checkBox_EnviarBackupNuvem
            // 
            this.checkBox_EnviarBackupNuvem.AutoSize = true;
            this.checkBox_EnviarBackupNuvem.Location = new System.Drawing.Point(6, 44);
            this.checkBox_EnviarBackupNuvem.Name = "checkBox_EnviarBackupNuvem";
            this.checkBox_EnviarBackupNuvem.Size = new System.Drawing.Size(133, 17);
            this.checkBox_EnviarBackupNuvem.TabIndex = 3;
            this.checkBox_EnviarBackupNuvem.Text = "Enviar Backup Nuvem";
            this.checkBox_EnviarBackupNuvem.UseVisualStyleBackColor = true;
            // 
            // checkBox_EnviarBackupPendrive
            // 
            this.checkBox_EnviarBackupPendrive.AutoSize = true;
            this.checkBox_EnviarBackupPendrive.Location = new System.Drawing.Point(6, 68);
            this.checkBox_EnviarBackupPendrive.Name = "checkBox_EnviarBackupPendrive";
            this.checkBox_EnviarBackupPendrive.Size = new System.Drawing.Size(141, 17);
            this.checkBox_EnviarBackupPendrive.TabIndex = 4;
            this.checkBox_EnviarBackupPendrive.Text = "Enviar Backup Pendrive";
            this.checkBox_EnviarBackupPendrive.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Receber Email com aviso/erro de Backup";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_EmailCliente
            // 
            this.textBox_EmailCliente.Enabled = false;
            this.textBox_EmailCliente.Location = new System.Drawing.Point(6, 114);
            this.textBox_EmailCliente.Name = "textBox_EmailCliente";
            this.textBox_EmailCliente.Size = new System.Drawing.Size(303, 20);
            this.textBox_EmailCliente.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarConnetion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBarConnetion
            // 
            this.StatusBarConnetion.Name = "StatusBarConnetion";
            this.StatusBarConnetion.Size = new System.Drawing.Size(60, 17);
            this.StatusBarConnetion.Text = "Conexão: ";
            // 
            // frmAtualizaVersao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 218);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAtualizaVersao";
            this.Text = "Atualiza Versão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.CheckBox checkBox_SIGDelta;
        private System.Windows.Forms.CheckBox checkBox_DeltaNFe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_OCX;
        private System.Windows.Forms.CheckBox checkBox_SefazDLL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmailCliente;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_EnviarBackupPendrive;
        private System.Windows.Forms.CheckBox checkBox_EnviarBackupNuvem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarConnetion;
    }
}

