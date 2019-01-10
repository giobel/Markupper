namespace WindowsFormsApp
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.markupFolder = new System.Windows.Forms.TextBox();
            this.completedFolder = new System.Windows.Forms.TextBox();
            this.listBoxWip = new System.Windows.Forms.ListBox();
            this.textBoxInitials = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(495, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 49);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Start.Location = new System.Drawing.Point(16, 271);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(161, 49);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start working on it!  \r\n(add initials to filename)";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinish.Location = new System.Drawing.Point(250, 271);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(172, 49);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "I\'ve finished working on it \r\n(move it  to the Completed folder)";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(16, 109);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 147);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // markupFolder
            // 
            this.markupFolder.Location = new System.Drawing.Point(16, 41);
            this.markupFolder.Name = "markupFolder";
            this.markupFolder.Size = new System.Drawing.Size(640, 20);
            this.markupFolder.TabIndex = 5;
            this.markupFolder.Text = "Markup to do filepath";
            this.markupFolder.Leave += new System.EventHandler(this.markupFolder_Leave);
            // 
            // completedFolder
            // 
            this.completedFolder.Location = new System.Drawing.Point(16, 80);
            this.completedFolder.Name = "completedFolder";
            this.completedFolder.Size = new System.Drawing.Size(640, 20);
            this.completedFolder.TabIndex = 6;
            this.completedFolder.Text = "Markup completed filepath";
            // 
            // listBoxWip
            // 
            this.listBoxWip.FormattingEnabled = true;
            this.listBoxWip.Location = new System.Drawing.Point(336, 109);
            this.listBoxWip.Name = "listBoxWip";
            this.listBoxWip.Size = new System.Drawing.Size(320, 147);
            this.listBoxWip.TabIndex = 7;
            // 
            // textBoxInitials
            // 
            this.textBoxInitials.Location = new System.Drawing.Point(16, 12);
            this.textBoxInitials.Name = "textBoxInitials";
            this.textBoxInitials.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitials.TabIndex = 8;
            this.textBoxInitials.Text = "Enter your initials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInitials);
            this.Controls.Add(this.listBoxWip);
            this.Controls.Add(this.completedFolder);
            this.Controls.Add(this.markupFolder);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btnCancel);
            this.Name = "Form1";
            this.Text = "Markups Manager";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox markupFolder;
        private System.Windows.Forms.TextBox completedFolder;
        private System.Windows.Forms.ListBox listBoxWip;
        private System.Windows.Forms.TextBox textBoxInitials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

