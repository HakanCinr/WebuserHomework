namespace Webuser
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
            txtname = new TextBox();
            txtsurname = new TextBox();
            txtphone = new TextBox();
            txteposta = new TextBox();
            button1 = new Button();
            txtpassword = new TextBox();
            lblname = new Label();
            lblsurname = new Label();
            label3 = new Label();
            lblphone = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            txtget = new TextBox();
            btnget = new Button();
            lblcnname = new Label();
            lblctnar = new Label();
            lblctttl = new Label();
            adres = new Label();
            btndel = new Button();
            cmbcity = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(122, 72);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 0;
            // 
            // txtsurname
            // 
            txtsurname.Location = new Point(122, 101);
            txtsurname.Name = "txtsurname";
            txtsurname.Size = new Size(100, 23);
            txtsurname.TabIndex = 1;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(122, 130);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(100, 23);
            txtphone.TabIndex = 2;
            // 
            // txteposta
            // 
            txteposta.Location = new Point(122, 159);
            txteposta.Name = "txteposta";
            txteposta.Size = new Size(100, 23);
            txteposta.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(122, 243);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 4;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(122, 188);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(100, 23);
            txtpassword.TabIndex = 5;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(32, 75);
            lblname.Name = "lblname";
            lblname.Size = new Size(39, 15);
            lblname.TabIndex = 6;
            lblname.Text = "Name";
            // 
            // lblsurname
            // 
            lblsurname.AutoSize = true;
            lblsurname.Location = new Point(32, 104);
            lblsurname.Name = "lblsurname";
            lblsurname.Size = new Size(54, 15);
            lblsurname.TabIndex = 7;
            lblsurname.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // lblphone
            // 
            lblphone.AutoSize = true;
            lblphone.Location = new Point(32, 133);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(41, 15);
            lblphone.TabIndex = 9;
            lblphone.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 162);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "E-Posta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(487, 351);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtget
            // 
            txtget.Location = new Point(12, 286);
            txtget.Name = "txtget";
            txtget.Size = new Size(100, 23);
            txtget.TabIndex = 12;
            // 
            // btnget
            // 
            btnget.Location = new Point(122, 286);
            btnget.Name = "btnget";
            btnget.Size = new Size(100, 23);
            btnget.TabIndex = 13;
            btnget.Text = "Product çağır";
            btnget.UseVisualStyleBackColor = true;
            btnget.Click += btnget_Click;
            // 
            // lblcnname
            // 
            lblcnname.AutoSize = true;
            lblcnname.Location = new Point(15, 327);
            lblcnname.Name = "lblcnname";
            lblcnname.Size = new Size(0, 15);
            lblcnname.TabIndex = 14;
            // 
            // lblctnar
            // 
            lblctnar.AutoSize = true;
            lblctnar.Location = new Point(16, 342);
            lblctnar.Name = "lblctnar";
            lblctnar.Size = new Size(0, 15);
            lblctnar.TabIndex = 15;
            // 
            // lblctttl
            // 
            lblctttl.AutoSize = true;
            lblctttl.Location = new Point(15, 357);
            lblctttl.Name = "lblctttl";
            lblctttl.Size = new Size(0, 15);
            lblctttl.TabIndex = 16;
            // 
            // adres
            // 
            adres.AutoSize = true;
            adres.Location = new Point(15, 372);
            adres.Name = "adres";
            adres.Size = new Size(0, 15);
            adres.TabIndex = 17;
            // 
            // btndel
            // 
            btndel.Location = new Point(122, 327);
            btndel.Name = "btndel";
            btndel.Size = new Size(100, 30);
            btndel.TabIndex = 18;
            btndel.Text = "Product Id Sil";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += button2_Click;
            // 
            // cmbcity
            // 
            cmbcity.FormattingEnabled = true;
            cmbcity.Location = new Point(122, 33);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(100, 23);
            cmbcity.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 20;
            label1.Text = "City";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbcity);
            Controls.Add(btndel);
            Controls.Add(adres);
            Controls.Add(lblctttl);
            Controls.Add(lblctnar);
            Controls.Add(lblcnname);
            Controls.Add(btnget);
            Controls.Add(txtget);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(lblphone);
            Controls.Add(label3);
            Controls.Add(lblsurname);
            Controls.Add(lblname);
            Controls.Add(txtpassword);
            Controls.Add(button1);
            Controls.Add(txteposta);
            Controls.Add(txtphone);
            Controls.Add(txtsurname);
            Controls.Add(txtname);
            Name = "Form1";
            Text = "lblcmname";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private TextBox txtsurname;
        private TextBox txtphone;
        private TextBox txteposta;
        private Button button1;
        private TextBox txtpassword;
        private Label lblname;
        private Label lblsurname;
        private Label label3;
        private Label lblphone;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox txtget;
        private Button btnget;
        private Label lblcnname;
        private Label lblctnar;
        private Label lblctttl;
        private Label adres;
        private Button btndel;
        private ComboBox cmbcity;
        private Label label1;
    }
}