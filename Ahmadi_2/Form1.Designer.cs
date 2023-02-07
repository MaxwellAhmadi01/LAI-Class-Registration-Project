namespace Ahmadi_2
{
    partial class LAIRegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.termInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.courseOrderInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.pricePerCourseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOrderPriceLabel = new System.Windows.Forms.Label();
            this.coursesPurchasedLabel = new System.Windows.Forms.Label();
            this.tOPLabel = new System.Windows.Forms.Label();
            this.cPLabel = new System.Windows.Forms.Label();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.cardNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LAIPictureBox = new System.Windows.Forms.PictureBox();
            this.termInformationGroupBox.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.courseOrderInformationGroupBox.SuspendLayout();
            this.paymentInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAIPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // termInformationGroupBox
            // 
            this.termInformationGroupBox.Controls.Add(this.yearLabel);
            this.termInformationGroupBox.Controls.Add(this.yearComboBox);
            this.termInformationGroupBox.Controls.Add(this.springRadioButton);
            this.termInformationGroupBox.Controls.Add(this.fallRadioButton);
            this.termInformationGroupBox.Location = new System.Drawing.Point(42, 333);
            this.termInformationGroupBox.Name = "termInformationGroupBox";
            this.termInformationGroupBox.Size = new System.Drawing.Size(478, 170);
            this.termInformationGroupBox.TabIndex = 0;
            this.termInformationGroupBox.TabStop = false;
            this.termInformationGroupBox.Text = "Term Information";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(199, 45);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 25);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.yearComboBox.Location = new System.Drawing.Point(172, 94);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 33);
            this.yearComboBox.TabIndex = 3;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(18, 94);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(105, 29);
            this.springRadioButton.TabIndex = 2;
            this.springRadioButton.TabStop = true;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Location = new System.Drawing.Point(18, 45);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(78, 29);
            this.fallRadioButton.TabIndex = 1;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailAddressLabel);
            this.studentInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.studentIDLabel);
            this.studentInformationGroupBox.Controls.Add(this.emailAddressTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(42, 543);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(478, 379);
            this.studentInformationGroupBox.TabIndex = 1;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(22, 330);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(163, 29);
            this.outOfStateRadioButton.TabIndex = 9;
            this.outOfStateRadioButton.TabStop = true;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.outOfStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(22, 284);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(117, 29);
            this.inStateRadioButton.TabIndex = 8;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(193, 46);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(129, 31);
            this.studentIDMaskedTextBox.TabIndex = 4;
            this.studentIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(17, 229);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(156, 25);
            this.emailAddressLabel.TabIndex = 7;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 171);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(17, 108);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(17, 52);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(118, 25);
            this.studentIDLabel.TabIndex = 4;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(193, 229);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(255, 31);
            this.emailAddressTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(193, 168);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(149, 31);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(193, 105);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(149, 31);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // courseOrderInformationGroupBox
            // 
            this.courseOrderInformationGroupBox.Controls.Add(this.pricePerCourseLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.label1);
            this.courseOrderInformationGroupBox.Controls.Add(this.totalOrderPriceLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.coursesPurchasedLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.tOPLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.cPLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInformationGroupBox.Location = new System.Drawing.Point(596, 333);
            this.courseOrderInformationGroupBox.Name = "courseOrderInformationGroupBox";
            this.courseOrderInformationGroupBox.Size = new System.Drawing.Size(553, 323);
            this.courseOrderInformationGroupBox.TabIndex = 0;
            this.courseOrderInformationGroupBox.TabStop = false;
            this.courseOrderInformationGroupBox.Text = "Course Order Information";
            // 
            // pricePerCourseLabel
            // 
            this.pricePerCourseLabel.AutoSize = true;
            this.pricePerCourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePerCourseLabel.Location = new System.Drawing.Point(345, 70);
            this.pricePerCourseLabel.Name = "pricePerCourseLabel";
            this.pricePerCourseLabel.Size = new System.Drawing.Size(131, 27);
            this.pricePerCourseLabel.TabIndex = 10;
            this.pricePerCourseLabel.Text = "Dollar Value";
            this.pricePerCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price Per Course:";
            // 
            // totalOrderPriceLabel
            // 
            this.totalOrderPriceLabel.AutoSize = true;
            this.totalOrderPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrderPriceLabel.Location = new System.Drawing.Point(340, 256);
            this.totalOrderPriceLabel.Name = "totalOrderPriceLabel";
            this.totalOrderPriceLabel.Size = new System.Drawing.Size(131, 27);
            this.totalOrderPriceLabel.TabIndex = 8;
            this.totalOrderPriceLabel.Text = "Dollar Value";
            this.totalOrderPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coursesPurchasedLabel
            // 
            this.coursesPurchasedLabel.AutoSize = true;
            this.coursesPurchasedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coursesPurchasedLabel.Location = new System.Drawing.Point(340, 158);
            this.coursesPurchasedLabel.Name = "coursesPurchasedLabel";
            this.coursesPurchasedLabel.Size = new System.Drawing.Size(154, 27);
            this.coursesPurchasedLabel.TabIndex = 7;
            this.coursesPurchasedLabel.Text = "Numeric Value";
            this.coursesPurchasedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tOPLabel
            // 
            this.tOPLabel.AutoSize = true;
            this.tOPLabel.Location = new System.Drawing.Point(335, 210);
            this.tOPLabel.Name = "tOPLabel";
            this.tOPLabel.Size = new System.Drawing.Size(181, 25);
            this.tOPLabel.TabIndex = 6;
            this.tOPLabel.Text = "Total Order Price:";
            // 
            // cPLabel
            // 
            this.cPLabel.AutoSize = true;
            this.cPLabel.Location = new System.Drawing.Point(335, 119);
            this.cPLabel.Name = "cPLabel";
            this.cPLabel.Size = new System.Drawing.Size(207, 25);
            this.cPLabel.TabIndex = 5;
            this.cPLabel.Text = "Courses Purchased:";
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(7, 232);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(203, 29);
            this.italianCheckBox.TabIndex = 14;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.italianCheckBox_CheckedChanged);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(7, 186);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(224, 29);
            this.russianCheckBox.TabIndex = 13;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.russianCheckBox_CheckedChanged);
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(7, 141);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(224, 29);
            this.spanishCheckBox.TabIndex = 12;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.spanishCheckBox_CheckedChanged);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(7, 94);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(222, 29);
            this.germanCheckBox.TabIndex = 11;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.germanCheckBox_CheckedChanged);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(7, 45);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(213, 29);
            this.frenchCheckBox.TabIndex = 10;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.frenchCheckBox_CheckedChanged);
            // 
            // paymentInformationGroupBox
            // 
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberMaskedTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.expirationDateMaskedTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.expirationDateLabel);
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentInformationGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInformationGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInformationGroupBox.Location = new System.Drawing.Point(596, 672);
            this.paymentInformationGroupBox.Name = "paymentInformationGroupBox";
            this.paymentInformationGroupBox.Size = new System.Drawing.Size(553, 250);
            this.paymentInformationGroupBox.TabIndex = 3;
            this.paymentInformationGroupBox.TabStop = false;
            this.paymentInformationGroupBox.Text = "Payment Information";
            // 
            // cardNumberMaskedTextBox
            // 
            this.cardNumberMaskedTextBox.Location = new System.Drawing.Point(208, 133);
            this.cardNumberMaskedTextBox.Mask = "0000-0000-0000-0000";
            this.cardNumberMaskedTextBox.Name = "cardNumberMaskedTextBox";
            this.cardNumberMaskedTextBox.Size = new System.Drawing.Size(219, 31);
            this.cardNumberMaskedTextBox.TabIndex = 17;
            this.cardNumberMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expirationDateMaskedTextBox
            // 
            this.expirationDateMaskedTextBox.Location = new System.Drawing.Point(208, 182);
            this.expirationDateMaskedTextBox.Mask = "00/00/0000";
            this.expirationDateMaskedTextBox.Name = "expirationDateMaskedTextBox";
            this.expirationDateMaskedTextBox.Size = new System.Drawing.Size(114, 31);
            this.expirationDateMaskedTextBox.TabIndex = 18;
            this.expirationDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expirationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Location = new System.Drawing.Point(7, 182);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(165, 25);
            this.expirationDateLabel.TabIndex = 3;
            this.expirationDateLabel.Text = "Expiration Date:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(7, 139);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(145, 25);
            this.cardNumberLabel.TabIndex = 2;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(7, 85);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(85, 29);
            this.visaRadioButton.TabIndex = 16;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(6, 38);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(155, 29);
            this.masterCardRadioButton.TabIndex = 15;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(596, 960);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 55);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "&Save";
            this.toolTip1.SetToolTip(this.saveButton, "Clicking this button will save progress made on completing the form up to the cur" +
        "rent time.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(763, 960);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 55);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Cl&ear";
            this.toolTip1.SetToolTip(this.clearButton, "Clicking this button will clear the contents of any typed information from the fo" +
        "rm\'s user.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(941, 960);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 55);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Clicking this button will end the program.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LAIPictureBox
            // 
            this.LAIPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LAIPictureBox.Image = global::Ahmadi_2.Properties.Resources.Language_Image;
            this.LAIPictureBox.ImageLocation = "";
            this.LAIPictureBox.Location = new System.Drawing.Point(261, 12);
            this.LAIPictureBox.Name = "LAIPictureBox";
            this.LAIPictureBox.Size = new System.Drawing.Size(610, 291);
            this.LAIPictureBox.TabIndex = 7;
            this.LAIPictureBox.TabStop = false;
            // 
            // LAIRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 1181);
            this.Controls.Add(this.LAIPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentInformationGroupBox);
            this.Controls.Add(this.courseOrderInformationGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.termInformationGroupBox);
            this.Name = "LAIRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAI Class Registration";
            this.Load += new System.EventHandler(this.LAIRegistrationForm_Load);
            this.termInformationGroupBox.ResumeLayout(false);
            this.termInformationGroupBox.PerformLayout();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.courseOrderInformationGroupBox.ResumeLayout(false);
            this.courseOrderInformationGroupBox.PerformLayout();
            this.paymentInformationGroupBox.ResumeLayout(false);
            this.paymentInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LAIPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox termInformationGroupBox;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.GroupBox courseOrderInformationGroupBox;
        private System.Windows.Forms.GroupBox paymentInformationGroupBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.MaskedTextBox expirationDateMaskedTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.PictureBox LAIPictureBox;
        private System.Windows.Forms.Label tOPLabel;
        private System.Windows.Forms.Label cPLabel;
        private System.Windows.Forms.Label totalOrderPriceLabel;
        private System.Windows.Forms.Label coursesPurchasedLabel;
        private System.Windows.Forms.MaskedTextBox cardNumberMaskedTextBox;
        private System.Windows.Forms.Label pricePerCourseLabel;
        private System.Windows.Forms.Label label1;
    }
}

