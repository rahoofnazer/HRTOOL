namespace WindowsFormsApp2
{
    partial class Holse
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
            this.txtboxfirstname = new System.Windows.Forms.TextBox();
            this.txtboxexperience = new System.Windows.Forms.TextBox();
            this.txtboxlastname = new System.Windows.Forms.TextBox();
            this.txtboxage = new System.Windows.Forms.TextBox();
            this.txtboxphonenumber = new System.Windows.Forms.TextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxhighqualification = new System.Windows.Forms.TextBox();
            this.txtboxprecompany = new System.Windows.Forms.TextBox();
            this.fullnamel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.highqualify = new System.Windows.Forms.Label();
            this.precomp = new System.Windows.Forms.Label();
            this.expl = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.addinfo = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.txtboxadditionalinfo = new System.Windows.Forms.RichTextBox();
            this.txtboxaddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxfirstname
            // 
            this.txtboxfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxfirstname.Location = new System.Drawing.Point(97, 73);
            this.txtboxfirstname.Name = "txtboxfirstname";
            this.txtboxfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtboxfirstname.TabIndex = 0;
            this.txtboxfirstname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // txtboxexperience
            // 
            this.txtboxexperience.Location = new System.Drawing.Point(324, 73);
            this.txtboxexperience.Name = "txtboxexperience";
            this.txtboxexperience.Size = new System.Drawing.Size(100, 20);
            this.txtboxexperience.TabIndex = 1;
            this.txtboxexperience.TextChanged += new System.EventHandler(this.txtboxexperience_TextChanged);
            // 
            // txtboxlastname
            // 
            this.txtboxlastname.Location = new System.Drawing.Point(97, 131);
            this.txtboxlastname.Name = "txtboxlastname";
            this.txtboxlastname.Size = new System.Drawing.Size(100, 20);
            this.txtboxlastname.TabIndex = 2;
            // 
            // txtboxage
            // 
            this.txtboxage.Location = new System.Drawing.Point(97, 199);
            this.txtboxage.Name = "txtboxage";
            this.txtboxage.Size = new System.Drawing.Size(100, 20);
            this.txtboxage.TabIndex = 3;
            this.txtboxage.TextChanged += new System.EventHandler(this.txtboxage_TextChanged);
            // 
            // txtboxphonenumber
            // 
            this.txtboxphonenumber.Location = new System.Drawing.Point(97, 324);
            this.txtboxphonenumber.Name = "txtboxphonenumber";
            this.txtboxphonenumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxphonenumber.TabIndex = 4;
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(97, 262);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(100, 20);
            this.txtboxemail.TabIndex = 5;
            // 
            // txtboxhighqualification
            // 
            this.txtboxhighqualification.Location = new System.Drawing.Point(324, 199);
            this.txtboxhighqualification.Name = "txtboxhighqualification";
            this.txtboxhighqualification.Size = new System.Drawing.Size(100, 20);
            this.txtboxhighqualification.TabIndex = 8;
            // 
            // txtboxprecompany
            // 
            this.txtboxprecompany.Location = new System.Drawing.Point(324, 131);
            this.txtboxprecompany.Name = "txtboxprecompany";
            this.txtboxprecompany.Size = new System.Drawing.Size(100, 20);
            this.txtboxprecompany.TabIndex = 9;
            // 
            // fullnamel
            // 
            this.fullnamel.AutoSize = true;
            this.fullnamel.Location = new System.Drawing.Point(28, 76);
            this.fullnamel.Name = "fullnamel";
            this.fullnamel.Size = new System.Drawing.Size(63, 13);
            this.fullnamel.TabIndex = 10;
            this.fullnamel.Text = "First Name :";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(232, 265);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(51, 13);
            this.add.TabIndex = 11;
            this.add.Text = "Address :";
            // 
            // highqualify
            // 
            this.highqualify.AutoSize = true;
            this.highqualify.Location = new System.Drawing.Point(247, 202);
            this.highqualify.Name = "highqualify";
            this.highqualify.Size = new System.Drawing.Size(71, 13);
            this.highqualify.TabIndex = 12;
            this.highqualify.Text = "Qualification :";
            // 
            // precomp
            // 
            this.precomp.AutoSize = true;
            this.precomp.Location = new System.Drawing.Point(227, 125);
            this.precomp.Name = "precomp";
            this.precomp.Size = new System.Drawing.Size(95, 26);
            this.precomp.TabIndex = 13;
            this.precomp.Text = "Previous Company\r\nName :";
            // 
            // expl
            // 
            this.expl.AutoSize = true;
            this.expl.Location = new System.Drawing.Point(258, 76);
            this.expl.Name = "expl";
            this.expl.Size = new System.Drawing.Size(60, 13);
            this.expl.TabIndex = 14;
            this.expl.Text = "Exp Level :";
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.Location = new System.Drawing.Point(8, 327);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(84, 13);
            this.phonenumber.TabIndex = 15;
            this.phonenumber.Text = "Phone Number :";
            this.phonenumber.Click += new System.EventHandler(this.label6_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(54, 265);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 16;
            this.email.Text = "Email :";
            this.email.Click += new System.EventHandler(this.label7_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(60, 202);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 13);
            this.age.TabIndex = 17;
            this.age.Text = "Age :";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(28, 134);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(64, 13);
            this.lastname.TabIndex = 18;
            this.lastname.Text = "Last Name :";
            this.lastname.Click += new System.EventHandler(this.label9_Click);
            // 
            // addinfo
            // 
            this.addinfo.AutoSize = true;
            this.addinfo.Location = new System.Drawing.Point(203, 327);
            this.addinfo.Name = "addinfo";
            this.addinfo.Size = new System.Drawing.Size(80, 13);
            this.addinfo.TabIndex = 19;
            this.addinfo.Text = "Additional Info :";
            // 
            // Register
            // 
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.Location = new System.Drawing.Point(654, 401);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(134, 37);
            this.Register.TabIndex = 20;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // txtboxadditionalinfo
            // 
            this.txtboxadditionalinfo.Location = new System.Drawing.Point(289, 324);
            this.txtboxadditionalinfo.Name = "txtboxadditionalinfo";
            this.txtboxadditionalinfo.Size = new System.Drawing.Size(135, 84);
            this.txtboxadditionalinfo.TabIndex = 22;
            this.txtboxadditionalinfo.Text = "";
            // 
            // txtboxaddress
            // 
            this.txtboxaddress.Location = new System.Drawing.Point(290, 262);
            this.txtboxaddress.Name = "txtboxaddress";
            this.txtboxaddress.Size = new System.Drawing.Size(134, 56);
            this.txtboxaddress.TabIndex = 23;
            this.txtboxaddress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gender :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBoxgender.Location = new System.Drawing.Point(97, 374);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(100, 21);
            this.comboBoxgender.TabIndex = 26;
            // 
            // dgvlist
            // 
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.Location = new System.Drawing.Point(442, 18);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.Size = new System.Drawing.Size(346, 372);
            this.dgvlist.TabIndex = 27;
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(514, 401);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 37);
            this.ClearButton.TabIndex = 30;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Holse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.dgvlist);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxaddress);
            this.Controls.Add(this.txtboxadditionalinfo);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.addinfo);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.age);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.expl);
            this.Controls.Add(this.precomp);
            this.Controls.Add(this.highqualify);
            this.Controls.Add(this.add);
            this.Controls.Add(this.fullnamel);
            this.Controls.Add(this.txtboxprecompany);
            this.Controls.Add(this.txtboxhighqualification);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.txtboxphonenumber);
            this.Controls.Add(this.txtboxage);
            this.Controls.Add(this.txtboxlastname);
            this.Controls.Add(this.txtboxexperience);
            this.Controls.Add(this.txtboxfirstname);
            this.Name = "Holse";
            this.Text = "Holse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxfirstname;
        private System.Windows.Forms.TextBox txtboxexperience;
        private System.Windows.Forms.TextBox txtboxlastname;
        private System.Windows.Forms.TextBox txtboxage;
        private System.Windows.Forms.TextBox txtboxphonenumber;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxhighqualification;
        private System.Windows.Forms.TextBox txtboxprecompany;
        private System.Windows.Forms.Label fullnamel;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label highqualify;
        private System.Windows.Forms.Label precomp;
        private System.Windows.Forms.Label expl;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label addinfo;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.RichTextBox txtboxadditionalinfo;
        private System.Windows.Forms.RichTextBox txtboxaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Button ClearButton;
    }
}

