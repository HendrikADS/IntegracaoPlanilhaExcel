namespace integraExcel
{
    partial class frmIntegra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDespAdm = new System.Windows.Forms.TextBox();
            this.txtCustoP = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResultOper = new System.Windows.Forms.Label();
            this.lblTotDesp = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblTotrec = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.txtFaturamento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Controls.Add(this.txtDespAdm);
            this.groupBox1.Controls.Add(this.txtCustoP);
            this.groupBox1.Controls.Add(this.txtCom);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblResultOper);
            this.groupBox1.Controls.Add(this.lblTotDesp);
            this.groupBox1.Controls.Add(this.lblImposto);
            this.groupBox1.Controls.Add(this.lblTotrec);
            this.groupBox1.Controls.Add(this.lblDev);
            this.groupBox1.Controls.Add(this.txtFaturamento);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(471, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado operacional Julho 20223";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDespAdm
            // 
            this.txtDespAdm.Location = new System.Drawing.Point(246, 369);
            this.txtDespAdm.Name = "txtDespAdm";
            this.txtDespAdm.Size = new System.Drawing.Size(200, 29);
            this.txtDespAdm.TabIndex = 24;
            // 
            // txtCustoP
            // 
            this.txtCustoP.Location = new System.Drawing.Point(246, 262);
            this.txtCustoP.Name = "txtCustoP";
            this.txtCustoP.Size = new System.Drawing.Size(200, 29);
            this.txtCustoP.TabIndex = 23;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(246, 205);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(200, 29);
            this.txtCom.TabIndex = 22;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(272, 545);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 31);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.BorderSize = 5;
            this.btnAbrir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Black;
            this.btnAbrir.Location = new System.Drawing.Point(81, 545);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(102, 31);
            this.btnAbrir.TabIndex = 20;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(111, 611);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(315, 30);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "                                              ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblResultOper
            // 
            this.lblResultOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultOper.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultOper.ForeColor = System.Drawing.Color.Black;
            this.lblResultOper.Location = new System.Drawing.Point(246, 483);
            this.lblResultOper.Name = "lblResultOper";
            this.lblResultOper.Size = new System.Drawing.Size(200, 31);
            this.lblResultOper.TabIndex = 18;
            this.lblResultOper.Text = "                                             ";
            this.lblResultOper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotDesp
            // 
            this.lblTotDesp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotDesp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDesp.ForeColor = System.Drawing.Color.Black;
            this.lblTotDesp.Location = new System.Drawing.Point(246, 424);
            this.lblTotDesp.Name = "lblTotDesp";
            this.lblTotDesp.Size = new System.Drawing.Size(200, 31);
            this.lblTotDesp.TabIndex = 17;
            this.lblTotDesp.Text = "                                             ";
            this.lblTotDesp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImposto
            // 
            this.lblImposto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImposto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposto.ForeColor = System.Drawing.Color.Black;
            this.lblImposto.Location = new System.Drawing.Point(246, 315);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(200, 31);
            this.lblImposto.TabIndex = 15;
            this.lblImposto.Text = "                                             ";
            this.lblImposto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotrec
            // 
            this.lblTotrec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotrec.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotrec.ForeColor = System.Drawing.Color.Black;
            this.lblTotrec.Location = new System.Drawing.Point(246, 148);
            this.lblTotrec.Name = "lblTotrec";
            this.lblTotrec.Size = new System.Drawing.Size(200, 31);
            this.lblTotrec.TabIndex = 12;
            this.lblTotrec.Text = "                                             ";
            this.lblTotrec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDev
            // 
            this.lblDev.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblDev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDev.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.Color.Black;
            this.lblDev.Location = new System.Drawing.Point(246, 96);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(200, 31);
            this.lblDev.TabIndex = 11;
            this.lblDev.Text = "                                             ";
            this.lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFaturamento
            // 
            this.txtFaturamento.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFaturamento.Location = new System.Drawing.Point(246, 49);
            this.txtFaturamento.Name = "txtFaturamento";
            this.txtFaturamento.Size = new System.Drawing.Size(200, 29);
            this.txtFaturamento.TabIndex = 10;
            this.txtFaturamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(35, 618);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 23);
            this.label19.TabIndex = 9;
            this.label19.Text = "STATUS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(27, 492);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 22);
            this.label17.TabIndex = 8;
            this.label17.Text = "Resultado Operacional";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(27, 433);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Total das Despesas";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(27, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 22);
            this.label13.TabIndex = 6;
            this.label13.Text = "Despesas Administrativas";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(27, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Impostos";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(27, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Custos dos Produtos";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Comissões";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Receitas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Devoluções";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturamento";
            // 
            // frmIntegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 681);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIntegra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTEGRAÇÃO PLANILHA EXCEL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIntegra_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFaturamento;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblResultOper;
        private System.Windows.Forms.Label lblTotDesp;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblTotrec;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtDespAdm;
        private System.Windows.Forms.TextBox txtCustoP;
        private System.Windows.Forms.TextBox txtCom;
    }
}

