namespace Checkout
{
    partial class frmPagamentos
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
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameBuyer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailBuyer = new System.Windows.Forms.TextBox();
            this.Buyer = new System.Windows.Forms.GroupBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.GroupBox();
            this.mtbCVV = new System.Windows.Forms.MaskedTextBox();
            this.mtbCard = new System.Windows.Forms.MaskedTextBox();
            this.mtbExpData = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeCard = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.GroupBox();
            this.txtBandeira = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCard = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Buyer.SuspendLayout();
            this.Client.SuspendLayout();
            this.Card.SuspendLayout();
            this.Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Location = new System.Drawing.Point(12, 429);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(83, 38);
            this.btnPagamentos.TabIndex = 7;
            this.btnPagamentos.Text = "Pagar";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtNameBuyer
            // 
            this.txtNameBuyer.Location = new System.Drawing.Point(87, 23);
            this.txtNameBuyer.MaxLength = 100;
            this.txtNameBuyer.Name = "txtNameBuyer";
            this.txtNameBuyer.Size = new System.Drawing.Size(226, 20);
            this.txtNameBuyer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // txtEmailBuyer
            // 
            this.txtEmailBuyer.Location = new System.Drawing.Point(87, 49);
            this.txtEmailBuyer.MaxLength = 100;
            this.txtEmailBuyer.Name = "txtEmailBuyer";
            this.txtEmailBuyer.Size = new System.Drawing.Size(226, 20);
            this.txtEmailBuyer.TabIndex = 3;
            // 
            // Buyer
            // 
            this.Buyer.Controls.Add(this.mtbCPF);
            this.Buyer.Controls.Add(this.label4);
            this.Buyer.Controls.Add(this.txtEmailBuyer);
            this.Buyer.Controls.Add(this.label3);
            this.Buyer.Controls.Add(this.txtNameBuyer);
            this.Buyer.Controls.Add(this.label2);
            this.Buyer.Location = new System.Drawing.Point(14, 69);
            this.Buyer.Name = "Buyer";
            this.Buyer.Size = new System.Drawing.Size(324, 103);
            this.Buyer.TabIndex = 0;
            this.Buyer.TabStop = false;
            this.Buyer.Text = "Buyer";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(90, 77);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(94, 20);
            this.mtbCPF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // Client
            // 
            this.Client.Controls.Add(this.txtClient);
            this.Client.Controls.Add(this.label1);
            this.Client.Location = new System.Drawing.Point(15, 10);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(323, 53);
            this.Client.TabIndex = 8;
            this.Client.TabStop = false;
            this.Client.Text = "Client";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(87, 19);
            this.txtClient.MaxLength = 100;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(226, 20);
            this.txtClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // Card
            // 
            this.Card.Controls.Add(this.mtbCVV);
            this.Card.Controls.Add(this.mtbCard);
            this.Card.Controls.Add(this.mtbExpData);
            this.Card.Controls.Add(this.label12);
            this.Card.Controls.Add(this.label11);
            this.Card.Controls.Add(this.label10);
            this.Card.Controls.Add(this.txtNomeCard);
            this.Card.Controls.Add(this.label9);
            this.Card.Location = new System.Drawing.Point(14, 288);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(323, 135);
            this.Card.TabIndex = 9;
            this.Card.TabStop = false;
            this.Card.Text = "Card";
            // 
            // mtbCVV
            // 
            this.mtbCVV.Location = new System.Drawing.Point(87, 101);
            this.mtbCVV.Mask = "000";
            this.mtbCVV.Name = "mtbCVV";
            this.mtbCVV.Size = new System.Drawing.Size(29, 20);
            this.mtbCVV.TabIndex = 11;
            // 
            // mtbCard
            // 
            this.mtbCard.Location = new System.Drawing.Point(88, 47);
            this.mtbCard.Mask = "0000 0000 0000 0000";
            this.mtbCard.Name = "mtbCard";
            this.mtbCard.Size = new System.Drawing.Size(149, 20);
            this.mtbCard.TabIndex = 9;
            // 
            // mtbExpData
            // 
            this.mtbExpData.Location = new System.Drawing.Point(87, 75);
            this.mtbExpData.Mask = "00/00/0000";
            this.mtbExpData.Name = "mtbExpData";
            this.mtbExpData.Size = new System.Drawing.Size(76, 20);
            this.mtbExpData.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "CVV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Expiration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Number";
            // 
            // txtNomeCard
            // 
            this.txtNomeCard.Location = new System.Drawing.Point(87, 21);
            this.txtNomeCard.MaxLength = 100;
            this.txtNomeCard.Name = "txtNomeCard";
            this.txtNomeCard.Size = new System.Drawing.Size(212, 20);
            this.txtNomeCard.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.txtBandeira);
            this.Payment.Controls.Add(this.label7);
            this.Payment.Controls.Add(this.label6);
            this.Payment.Controls.Add(this.cboCard);
            this.Payment.Controls.Add(this.txtAmount);
            this.Payment.Controls.Add(this.label5);
            this.Payment.Location = new System.Drawing.Point(14, 178);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(323, 104);
            this.Payment.TabIndex = 10;
            this.Payment.TabStop = false;
            this.Payment.Text = "Payment";
            // 
            // txtBandeira
            // 
            this.txtBandeira.Location = new System.Drawing.Point(87, 72);
            this.txtBandeira.MaxLength = 100;
            this.txtBandeira.Name = "txtBandeira";
            this.txtBandeira.Size = new System.Drawing.Size(97, 20);
            this.txtBandeira.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Card";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type";
            // 
            // cboCard
            // 
            this.cboCard.FormattingEnabled = true;
            this.cboCard.Items.AddRange(new object[] {
            "Cartao",
            "Boleto"});
            this.cboCard.Location = new System.Drawing.Point(87, 45);
            this.cboCard.Name = "cboCard";
            this.cboCard.Size = new System.Drawing.Size(97, 21);
            this.cboCard.TabIndex = 6;
            this.cboCard.SelectedValueChanged += new System.EventHandler(this.cboCard_SelectedValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(87, 19);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(97, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 474);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.Buyer);
            this.MaximizeBox = false;
            this.Name = "frmPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.frmPagamentos_Load);
            this.Buyer.ResumeLayout(false);
            this.Buyer.PerformLayout();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameBuyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailBuyer;
        private System.Windows.Forms.GroupBox Buyer;
        private System.Windows.Forms.GroupBox Client;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Payment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCVV;
        private System.Windows.Forms.MaskedTextBox mtbCard;
        private System.Windows.Forms.MaskedTextBox mtbExpData;
        private System.Windows.Forms.TextBox txtBandeira;
    }
}

