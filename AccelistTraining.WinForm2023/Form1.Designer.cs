namespace AccelistTraining.WinForm2023
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
            inputNameTextBox = new TextBox();
            inputNameButton = new Button();
            inputNameLabel = new Label();
            yourNameLabel = new Label();
            yourNameValueLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            label1 = new Label();
            genderRadioButtonGroupBox = new GroupBox();
            yourGenderLabel = new Label();
            yourGenderValueLabel = new Label();
            submittedDataPanel = new Panel();
            yourAddressValueLabel = new Label();
            yourAddressLabel = new Label();
            yourLuckyNumberValueLabel = new Label();
            yourLuckyNumberLabel = new Label();
            luckyNumberInput = new NumericUpDown();
            addressRichTextBox = new RichTextBox();
            luckyNumberLabel = new Label();
            addressLabel = new Label();
            submissionProgressBar = new ProgressBar();
            currentProgressLabel = new Label();
            maxProgressLabel = new Label();
            fetchApiButton = new Button();
            peopleBox = new ListBox();
            panel1 = new Panel();
            inputTxtFileTextBox = new RichTextBox();
            writeFileExampleLabel = new Label();
            readFileExampleLabel = new Label();
            writeTxtButton = new Button();
            writeTxtFilePathInput = new TextBox();
            txtFileTextBox = new RichTextBox();
            readTxtFilePathInput = new TextBox();
            readTxtFileButton = new Button();
            submitUserRequestButton = new Button();
            userRequrestJobInput = new TextBox();
            userRequestNameInput = new TextBox();
            userRequestJobLabel = new Label();
            userRequestNameLabel = new Label();
            genderRadioButtonGroupBox.SuspendLayout();
            submittedDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)luckyNumberInput).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // inputNameTextBox
            // 
            inputNameTextBox.Location = new Point(103, 6);
            inputNameTextBox.Name = "inputNameTextBox";
            inputNameTextBox.Size = new Size(322, 23);
            inputNameTextBox.TabIndex = 1;
            // 
            // inputNameButton
            // 
            inputNameButton.BackColor = SystemColors.Highlight;
            inputNameButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            inputNameButton.ForeColor = SystemColors.ControlLightLight;
            inputNameButton.Location = new Point(12, 262);
            inputNameButton.Name = "inputNameButton";
            inputNameButton.Size = new Size(413, 60);
            inputNameButton.TabIndex = 11;
            inputNameButton.Text = "Submit";
            inputNameButton.UseVisualStyleBackColor = false;
            inputNameButton.Click += inputNameButton_Click;
            // 
            // inputNameLabel
            // 
            inputNameLabel.AutoSize = true;
            inputNameLabel.Location = new Point(12, 9);
            inputNameLabel.Name = "inputNameLabel";
            inputNameLabel.Size = new Size(39, 15);
            inputNameLabel.TabIndex = 0;
            inputNameLabel.Text = "Name";
            // 
            // yourNameLabel
            // 
            yourNameLabel.AutoSize = true;
            yourNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourNameLabel.Location = new Point(3, 5);
            yourNameLabel.Name = "yourNameLabel";
            yourNameLabel.Size = new Size(137, 32);
            yourNameLabel.TabIndex = 16;
            yourNameLabel.Text = "Your Name:";
            // 
            // yourNameValueLabel
            // 
            yourNameValueLabel.AutoSize = true;
            yourNameValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourNameValueLabel.Location = new Point(146, 5);
            yourNameValueLabel.Name = "yourNameValueLabel";
            yourNameValueLabel.Size = new Size(24, 32);
            yourNameValueLabel.TabIndex = 17;
            yourNameValueLabel.Text = "-";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(9, 22);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(51, 19);
            maleRadioButton.TabIndex = 5;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(66, 22);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(63, 19);
            femaleRadioButton.TabIndex = 6;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Gender";
            // 
            // genderRadioButtonGroupBox
            // 
            genderRadioButtonGroupBox.Controls.Add(maleRadioButton);
            genderRadioButtonGroupBox.Controls.Add(femaleRadioButton);
            genderRadioButtonGroupBox.Location = new Point(103, 36);
            genderRadioButtonGroupBox.Name = "genderRadioButtonGroupBox";
            genderRadioButtonGroupBox.Size = new Size(133, 51);
            genderRadioButtonGroupBox.TabIndex = 4;
            genderRadioButtonGroupBox.TabStop = false;
            // 
            // yourGenderLabel
            // 
            yourGenderLabel.AutoSize = true;
            yourGenderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourGenderLabel.Location = new Point(3, 47);
            yourGenderLabel.Name = "yourGenderLabel";
            yourGenderLabel.Size = new Size(151, 32);
            yourGenderLabel.TabIndex = 18;
            yourGenderLabel.Text = "Your Gender:";
            // 
            // yourGenderValueLabel
            // 
            yourGenderValueLabel.AutoSize = true;
            yourGenderValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourGenderValueLabel.Location = new Point(160, 49);
            yourGenderValueLabel.Name = "yourGenderValueLabel";
            yourGenderValueLabel.Size = new Size(24, 32);
            yourGenderValueLabel.TabIndex = 19;
            yourGenderValueLabel.Text = "-";
            // 
            // submittedDataPanel
            // 
            submittedDataPanel.Controls.Add(yourAddressValueLabel);
            submittedDataPanel.Controls.Add(yourAddressLabel);
            submittedDataPanel.Controls.Add(yourLuckyNumberValueLabel);
            submittedDataPanel.Controls.Add(yourLuckyNumberLabel);
            submittedDataPanel.Controls.Add(yourNameLabel);
            submittedDataPanel.Controls.Add(yourGenderValueLabel);
            submittedDataPanel.Controls.Add(yourNameValueLabel);
            submittedDataPanel.Controls.Add(yourGenderLabel);
            submittedDataPanel.Location = new Point(431, 6);
            submittedDataPanel.Name = "submittedDataPanel";
            submittedDataPanel.Size = new Size(495, 432);
            submittedDataPanel.TabIndex = 15;
            // 
            // yourAddressValueLabel
            // 
            yourAddressValueLabel.AutoSize = true;
            yourAddressValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourAddressValueLabel.Location = new Point(166, 148);
            yourAddressValueLabel.Name = "yourAddressValueLabel";
            yourAddressValueLabel.Size = new Size(24, 32);
            yourAddressValueLabel.TabIndex = 23;
            yourAddressValueLabel.Text = "-";
            // 
            // yourAddressLabel
            // 
            yourAddressLabel.AutoSize = true;
            yourAddressLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourAddressLabel.Location = new Point(3, 145);
            yourAddressLabel.Name = "yourAddressLabel";
            yourAddressLabel.Size = new Size(157, 32);
            yourAddressLabel.TabIndex = 22;
            yourAddressLabel.Text = "Your Address:";
            // 
            // yourLuckyNumberValueLabel
            // 
            yourLuckyNumberValueLabel.AutoSize = true;
            yourLuckyNumberValueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourLuckyNumberValueLabel.Location = new Point(237, 93);
            yourLuckyNumberValueLabel.Name = "yourLuckyNumberValueLabel";
            yourLuckyNumberValueLabel.Size = new Size(24, 32);
            yourLuckyNumberValueLabel.TabIndex = 21;
            yourLuckyNumberValueLabel.Text = "-";
            // 
            // yourLuckyNumberLabel
            // 
            yourLuckyNumberLabel.AutoSize = true;
            yourLuckyNumberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            yourLuckyNumberLabel.Location = new Point(3, 93);
            yourLuckyNumberLabel.Name = "yourLuckyNumberLabel";
            yourLuckyNumberLabel.Size = new Size(228, 32);
            yourLuckyNumberLabel.TabIndex = 20;
            yourLuckyNumberLabel.Text = "Your Lucky Number:";
            // 
            // luckyNumberInput
            // 
            luckyNumberInput.Location = new Point(103, 111);
            luckyNumberInput.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            luckyNumberInput.Name = "luckyNumberInput";
            luckyNumberInput.Size = new Size(133, 23);
            luckyNumberInput.TabIndex = 8;
            // 
            // addressRichTextBox
            // 
            addressRichTextBox.Location = new Point(103, 151);
            addressRichTextBox.Name = "addressRichTextBox";
            addressRichTextBox.Size = new Size(322, 96);
            addressRichTextBox.TabIndex = 10;
            addressRichTextBox.Text = "";
            // 
            // luckyNumberLabel
            // 
            luckyNumberLabel.AutoSize = true;
            luckyNumberLabel.Location = new Point(12, 113);
            luckyNumberLabel.Name = "luckyNumberLabel";
            luckyNumberLabel.Size = new Size(85, 15);
            luckyNumberLabel.TabIndex = 7;
            luckyNumberLabel.Text = "Lucky Number";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 154);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address";
            // 
            // submissionProgressBar
            // 
            submissionProgressBar.Location = new Point(12, 377);
            submissionProgressBar.Name = "submissionProgressBar";
            submissionProgressBar.Size = new Size(413, 23);
            submissionProgressBar.TabIndex = 14;
            // 
            // currentProgressLabel
            // 
            currentProgressLabel.AutoSize = true;
            currentProgressLabel.Location = new Point(12, 359);
            currentProgressLabel.Name = "currentProgressLabel";
            currentProgressLabel.Size = new Size(12, 15);
            currentProgressLabel.TabIndex = 12;
            currentProgressLabel.Text = "-";
            // 
            // maxProgressLabel
            // 
            maxProgressLabel.AutoSize = true;
            maxProgressLabel.Location = new Point(43, 359);
            maxProgressLabel.Name = "maxProgressLabel";
            maxProgressLabel.Size = new Size(33, 15);
            maxProgressLabel.TabIndex = 13;
            maxProgressLabel.Text = "/ 100";
            // 
            // fetchApiButton
            // 
            fetchApiButton.Location = new Point(13, 148);
            fetchApiButton.Name = "fetchApiButton";
            fetchApiButton.Size = new Size(75, 23);
            fetchApiButton.TabIndex = 16;
            fetchApiButton.Text = "Fetch API";
            fetchApiButton.UseVisualStyleBackColor = true;
            fetchApiButton.Click += fetchApiButton_Click;
            // 
            // peopleBox
            // 
            peopleBox.FormattingEnabled = true;
            peopleBox.ItemHeight = 15;
            peopleBox.Location = new Point(107, 148);
            peopleBox.Name = "peopleBox";
            peopleBox.Size = new Size(309, 109);
            peopleBox.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(inputTxtFileTextBox);
            panel1.Controls.Add(writeFileExampleLabel);
            panel1.Controls.Add(readFileExampleLabel);
            panel1.Controls.Add(writeTxtButton);
            panel1.Controls.Add(writeTxtFilePathInput);
            panel1.Controls.Add(txtFileTextBox);
            panel1.Controls.Add(readTxtFilePathInput);
            panel1.Controls.Add(readTxtFileButton);
            panel1.Controls.Add(submitUserRequestButton);
            panel1.Controls.Add(peopleBox);
            panel1.Controls.Add(fetchApiButton);
            panel1.Controls.Add(userRequrestJobInput);
            panel1.Controls.Add(userRequestNameInput);
            panel1.Controls.Add(userRequestJobLabel);
            panel1.Controls.Add(userRequestNameLabel);
            panel1.Location = new Point(932, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 714);
            panel1.TabIndex = 18;
            // 
            // inputTxtFileTextBox
            // 
            inputTxtFileTextBox.Location = new Point(13, 503);
            inputTxtFileTextBox.Name = "inputTxtFileTextBox";
            inputTxtFileTextBox.Size = new Size(403, 96);
            inputTxtFileTextBox.TabIndex = 27;
            inputTxtFileTextBox.Text = "";
            // 
            // writeFileExampleLabel
            // 
            writeFileExampleLabel.AutoSize = true;
            writeFileExampleLabel.Location = new Point(13, 485);
            writeFileExampleLabel.Name = "writeFileExampleLabel";
            writeFileExampleLabel.Size = new Size(104, 15);
            writeFileExampleLabel.TabIndex = 26;
            writeFileExampleLabel.Text = "Write File Example";
            // 
            // readFileExampleLabel
            // 
            readFileExampleLabel.AutoSize = true;
            readFileExampleLabel.Location = new Point(13, 289);
            readFileExampleLabel.Name = "readFileExampleLabel";
            readFileExampleLabel.Size = new Size(102, 15);
            readFileExampleLabel.TabIndex = 25;
            readFileExampleLabel.Text = "Read File Example";
            // 
            // writeTxtButton
            // 
            writeTxtButton.Location = new Point(341, 605);
            writeTxtButton.Name = "writeTxtButton";
            writeTxtButton.Size = new Size(75, 23);
            writeTxtButton.TabIndex = 24;
            writeTxtButton.Text = "Write .txt File";
            writeTxtButton.UseVisualStyleBackColor = true;
            writeTxtButton.Click += writeTxtButton_Click;
            // 
            // writeTxtFilePathInput
            // 
            writeTxtFilePathInput.Location = new Point(13, 605);
            writeTxtFilePathInput.Name = "writeTxtFilePathInput";
            writeTxtFilePathInput.PlaceholderText = "Write your .txt file path to write";
            writeTxtFilePathInput.Size = new Size(322, 23);
            writeTxtFilePathInput.TabIndex = 23;
            // 
            // txtFileTextBox
            // 
            txtFileTextBox.Location = new Point(13, 336);
            txtFileTextBox.Name = "txtFileTextBox";
            txtFileTextBox.Size = new Size(403, 96);
            txtFileTextBox.TabIndex = 22;
            txtFileTextBox.Text = "";
            // 
            // readTxtFilePathInput
            // 
            readTxtFilePathInput.Location = new Point(13, 307);
            readTxtFilePathInput.Name = "readTxtFilePathInput";
            readTxtFilePathInput.PlaceholderText = "Write your .txt file path to read";
            readTxtFilePathInput.Size = new Size(322, 23);
            readTxtFilePathInput.TabIndex = 21;
            // 
            // readTxtFileButton
            // 
            readTxtFileButton.Location = new Point(341, 307);
            readTxtFileButton.Name = "readTxtFileButton";
            readTxtFileButton.Size = new Size(75, 23);
            readTxtFileButton.TabIndex = 20;
            readTxtFileButton.Text = "Read .txt File";
            readTxtFileButton.UseVisualStyleBackColor = true;
            readTxtFileButton.Click += readTxtFileButton_Click;
            // 
            // submitUserRequestButton
            // 
            submitUserRequestButton.BackColor = SystemColors.Highlight;
            submitUserRequestButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            submitUserRequestButton.ForeColor = SystemColors.ControlLightLight;
            submitUserRequestButton.Location = new Point(3, 80);
            submitUserRequestButton.Name = "submitUserRequestButton";
            submitUserRequestButton.Size = new Size(413, 60);
            submitUserRequestButton.TabIndex = 19;
            submitUserRequestButton.Text = "Submit";
            submitUserRequestButton.UseVisualStyleBackColor = false;
            submitUserRequestButton.Click += submitUserRequestButton_Click;
            // 
            // userRequrestJobInput
            // 
            userRequrestJobInput.Location = new Point(48, 34);
            userRequrestJobInput.Name = "userRequrestJobInput";
            userRequrestJobInput.Size = new Size(100, 23);
            userRequrestJobInput.TabIndex = 3;
            // 
            // userRequestNameInput
            // 
            userRequestNameInput.Location = new Point(48, 5);
            userRequestNameInput.Name = "userRequestNameInput";
            userRequestNameInput.Size = new Size(100, 23);
            userRequestNameInput.TabIndex = 2;
            // 
            // userRequestJobLabel
            // 
            userRequestJobLabel.AutoSize = true;
            userRequestJobLabel.Location = new Point(3, 37);
            userRequestJobLabel.Name = "userRequestJobLabel";
            userRequestJobLabel.Size = new Size(25, 15);
            userRequestJobLabel.TabIndex = 1;
            userRequestJobLabel.Text = "Job";
            // 
            // userRequestNameLabel
            // 
            userRequestNameLabel.AutoSize = true;
            userRequestNameLabel.Location = new Point(3, 8);
            userRequestNameLabel.Name = "userRequestNameLabel";
            userRequestNameLabel.Size = new Size(39, 15);
            userRequestNameLabel.TabIndex = 0;
            userRequestNameLabel.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 732);
            Controls.Add(panel1);
            Controls.Add(maxProgressLabel);
            Controls.Add(currentProgressLabel);
            Controls.Add(submissionProgressBar);
            Controls.Add(addressLabel);
            Controls.Add(luckyNumberLabel);
            Controls.Add(addressRichTextBox);
            Controls.Add(luckyNumberInput);
            Controls.Add(submittedDataPanel);
            Controls.Add(genderRadioButtonGroupBox);
            Controls.Add(label1);
            Controls.Add(inputNameLabel);
            Controls.Add(inputNameButton);
            Controls.Add(inputNameTextBox);
            Name = "Form1";
            Text = "Form1";
            genderRadioButtonGroupBox.ResumeLayout(false);
            genderRadioButtonGroupBox.PerformLayout();
            submittedDataPanel.ResumeLayout(false);
            submittedDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)luckyNumberInput).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNameTextBox;
        private Button inputNameButton;
        private Label inputNameLabel;
        private Label yourNameLabel;
        private Label yourNameValueLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Label label1;
        private GroupBox genderRadioButtonGroupBox;
        private Label yourGenderLabel;
        private Label yourGenderValueLabel;
        private Panel submittedDataPanel;
        private NumericUpDown luckyNumberInput;
        private RichTextBox addressRichTextBox;
        private Label luckyNumberLabel;
        private Label yourAddressLabel;
        private Label yourLuckyNumberValueLabel;
        private Label yourLuckyNumberLabel;
        private Label addressLabel;
        private Label yourAddressValueLabel;
        private ProgressBar submissionProgressBar;
        private Label currentProgressLabel;
        private Label maxProgressLabel;
        private Button fetchApiButton;
        private ListBox peopleBox;
        private Panel panel1;
        private TextBox userRequrestJobInput;
        private TextBox userRequestNameInput;
        private Label userRequestJobLabel;
        private Label userRequestNameLabel;
        private Button submitUserRequestButton;
        private TextBox readTxtFilePathInput;
        private Button readTxtFileButton;
        private RichTextBox txtFileTextBox;
        private Button writeTxtButton;
        private TextBox writeTxtFilePathInput;
        private RichTextBox inputTxtFileTextBox;
        private Label writeFileExampleLabel;
        private Label readFileExampleLabel;
    }
}