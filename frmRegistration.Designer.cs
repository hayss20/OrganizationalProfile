namespace OrganizationalProfile
{
    partial class frmRegistration
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
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            txtContactNo = new TextBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label = new Label();
            mi = new Label();
            txt = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(131, 113);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(137, 23);
            txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 153);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(137, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 197);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(356, 153);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(131, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(537, 153);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(82, 23);
            txtMiddleInitial.TabIndex = 4;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(356, 113);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(263, 23);
            cbPrograms.TabIndex = 5;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(356, 197);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(100, 23);
            cbGender.TabIndex = 6;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(423, 243);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(131, 23);
            txtContactNo.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(131, 243);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(286, 330);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 29);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 116);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 10;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 116);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 11;
            label2.Text = "Program";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 156);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(286, 156);
            label.Name = "label";
            label.Size = new Size(64, 15);
            label.TabIndex = 13;
            label.Text = "First Name";
            // 
            // mi
            // 
            mi.AutoSize = true;
            mi.Location = new Point(504, 156);
            mi.Name = "mi";
            mi.Size = new Size(27, 15);
            mi.TabIndex = 14;
            mi.Text = "M.I.";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(97, 200);
            txt.Name = "txt";
            txt.Size = new Size(28, 15);
            txt.TabIndex = 15;
            txt.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 200);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 16;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 246);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 17;
            label8.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 249);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 18;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(50, 63);
            label10.Name = "label10";
            label10.Size = new Size(159, 37);
            label10.TabIndex = 19;
            label10.Text = "Registration";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 398);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt);
            Controls.Add(mi);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(txtContactNo);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Name = "frmRegistration";
            Text = "Form1";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private TextBox txtContactNo;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label;
        private Label mi;
        private Label txt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
