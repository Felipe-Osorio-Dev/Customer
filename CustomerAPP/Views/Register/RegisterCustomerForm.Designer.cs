namespace CustomerAPP.Views.Register
{
    partial class RegisterCustomerForm
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
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtState = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtZipCode = new TextBox();
            txtDocNumber = new TextBox();
            cbbDocument = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCity = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtNeighborhood = new TextBox();
            txtHouseNumber = new TextBox();
            txtStreet = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 37);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 84);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(205, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(298, 205);
            label3.Name = "label3";
            label3.Size = new Size(135, 37);
            label3.TabIndex = 3;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(244, 129);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 4;
            label4.Text = "Numero Doc";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 5;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(474, 60);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 6;
            label6.Text = "Telefone/Cel";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(244, 60);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 7;
            label7.Text = "Email";
            // 
            // txtState
            // 
            txtState.Location = new Point(244, 294);
            txtState.Name = "txtState";
            txtState.Size = new Size(205, 23);
            txtState.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(474, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(12, 294);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(205, 23);
            txtZipCode.TabIndex = 11;
            // 
            // txtDocNumber
            // 
            txtDocNumber.Location = new Point(244, 153);
            txtDocNumber.Name = "txtDocNumber";
            txtDocNumber.Size = new Size(205, 23);
            txtDocNumber.TabIndex = 12;
            // 
            // cbbDocument
            // 
            cbbDocument.FormattingEnabled = true;
            cbbDocument.Items.AddRange(new object[] { "CPF", "CNPJ" });
            cbbDocument.Location = new Point(12, 153);
            cbbDocument.Name = "cbbDocument";
            cbbDocument.Size = new Size(205, 23);
            cbbDocument.TabIndex = 13;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 270);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 14;
            label8.Text = "CEP";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(244, 270);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 15;
            label9.Text = "Estado";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(474, 270);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 16;
            label10.Text = "Cidade";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(474, 294);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(205, 23);
            txtCity.TabIndex = 17;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(12, 343);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 18;
            label11.Text = "Bairro";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(474, 343);
            label12.Name = "label12";
            label12.Size = new Size(68, 21);
            label12.TabIndex = 19;
            label12.Text = "Numero";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(244, 343);
            label13.Name = "label13";
            label13.Size = new Size(37, 21);
            label13.TabIndex = 20;
            label13.Text = "Rua";
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.Location = new Point(12, 367);
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.Size = new Size(205, 23);
            txtNeighborhood.TabIndex = 21;
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(474, 367);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(205, 23);
            txtHouseNumber.TabIndex = 22;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(244, 367);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(205, 23);
            txtStreet.TabIndex = 23;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(605, 470);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 505);
            Controls.Add(btnRegister);
            Controls.Add(txtStreet);
            Controls.Add(txtHouseNumber);
            Controls.Add(txtNeighborhood);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtCity);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cbbDocument);
            Controls.Add(txtDocNumber);
            Controls.Add(txtZipCode);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "RegisterCustomerForm";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtState;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtZipCode;
        private TextBox txtDocNumber;
        private ComboBox cbbDocument;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCity;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtNeighborhood;
        private TextBox txtHouseNumber;
        private TextBox txtStreet;
        private Button btnRegister;
    }
}