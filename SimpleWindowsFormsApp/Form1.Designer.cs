namespace SimpleWindowsFormsApp
{
    partial class Form1
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excludeCharacters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfPasswords = new System.Windows.Forms.NumericUpDown();
            this.History = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.warnLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(10, 193);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPassword.Size = new System.Drawing.Size(650, 121);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.WordWrap = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "regeneration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(669, 245);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.CheckOnClick = true;
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(27, 23);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(402, 123);
            this.checkedListBoxOptions.TabIndex = 4;
            this.checkedListBoxOptions.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exclude Characters: ";
            // 
            // excludeCharacters
            // 
            this.excludeCharacters.Location = new System.Drawing.Point(593, 37);
            this.excludeCharacters.Name = "excludeCharacters";
            this.excludeCharacters.Size = new System.Drawing.Size(100, 22);
            this.excludeCharacters.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password Length: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of passwords: ";
            // 
            // numberOfPasswords
            // 
            this.numberOfPasswords.Location = new System.Drawing.Point(593, 70);
            this.numberOfPasswords.Name = "numberOfPasswords";
            this.numberOfPasswords.Size = new System.Drawing.Size(120, 22);
            this.numberOfPasswords.TabIndex = 10;
            this.numberOfPasswords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(91, 336);
            this.History.Multiline = true;
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.History.Size = new System.Drawing.Size(338, 102);
            this.History.TabIndex = 11;
            this.History.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "History: ";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 392);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.ForeColor = System.Drawing.Color.Red;
            this.warnLabel.Location = new System.Drawing.Point(459, 356);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(311, 16);
            this.warnLabel.TabIndex = 14;
            this.warnLabel.Text = "At least one password option needs to be selected!";
            this.warnLabel.Click += new System.EventHandler(this.warnLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Passwords: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.warnLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.History);
            this.Controls.Add(this.numberOfPasswords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excludeCharacters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Random-Password-Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox excludeCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfPasswords;
        private System.Windows.Forms.TextBox History;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.Label label5;
    }
}

