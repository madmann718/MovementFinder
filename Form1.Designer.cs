namespace MovementFinder
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
            this.largeLabel = new System.Windows.Forms.LinkLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            this.outputMessage = new System.Windows.Forms.Label();
            this.tryLabel = new System.Windows.Forms.Label();
            this.testPicBox = new System.Windows.Forms.PictureBox();
            this.devLabel = new System.Windows.Forms.Label();
            this.brightLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.LinkLabel();
            this.feedbackBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // largeLabel
            // 
            this.largeLabel.AutoSize = true;
            this.largeLabel.Location = new System.Drawing.Point(12, 22);
            this.largeLabel.Name = "largeLabel";
            this.largeLabel.Size = new System.Drawing.Size(94, 13);
            this.largeLabel.TabIndex = 0;
            this.largeLabel.TabStop = true;
            this.largeLabel.Text = "Select input image";
            this.largeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLarge_Clicked);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // largePicBox
            // 
            this.largePicBox.Location = new System.Drawing.Point(12, 94);
            this.largePicBox.Name = "largePicBox";
            this.largePicBox.Size = new System.Drawing.Size(250, 250);
            this.largePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePicBox.TabIndex = 4;
            this.largePicBox.TabStop = false;
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessage.Location = new System.Drawing.Point(8, 428);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(225, 24);
            this.outputMessage.TabIndex = 5;
            this.outputMessage.Text = "Result will be shown here";
            // 
            // tryLabel
            // 
            this.tryLabel.Location = new System.Drawing.Point(496, 22);
            this.tryLabel.Name = "tryLabel";
            this.tryLabel.Size = new System.Drawing.Size(253, 13);
            this.tryLabel.TabIndex = 6;
            this.tryLabel.Text = "Attempt: 0, 0";
            // 
            // testPicBox
            // 
            this.testPicBox.Location = new System.Drawing.Point(499, 94);
            this.testPicBox.Name = "testPicBox";
            this.testPicBox.Size = new System.Drawing.Size(250, 250);
            this.testPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testPicBox.TabIndex = 7;
            this.testPicBox.TabStop = false;
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Location = new System.Drawing.Point(496, 50);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(104, 13);
            this.devLabel.TabIndex = 8;
            this.devLabel.Text = "Standard Deviation: ";
            // 
            // brightLabel
            // 
            this.brightLabel.AutoSize = true;
            this.brightLabel.Location = new System.Drawing.Point(496, 78);
            this.brightLabel.Name = "brightLabel";
            this.brightLabel.Size = new System.Drawing.Size(62, 13);
            this.brightLabel.TabIndex = 10;
            this.brightLabel.Text = "Brightness: ";
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 61);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(95, 13);
            this.folderLabel.TabIndex = 11;
            this.folderLabel.TabStop = true;
            this.folderLabel.Text = "Select entire folder";
            this.folderLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.folderLabel_LinkClicked);
            // 
            // feedbackBox
            // 
            this.feedbackBox.Location = new System.Drawing.Point(354, 417);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.Size = new System.Drawing.Size(30, 30);
            this.feedbackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedbackBox.TabIndex = 13;
            this.feedbackBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 471);
            this.Controls.Add(this.feedbackBox);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.brightLabel);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.testPicBox);
            this.Controls.Add(this.tryLabel);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.largePicBox);
            this.Controls.Add(this.largeLabel);
            this.Name = "Form1";
            this.Text = "Look For Movement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel largeLabel;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.Label tryLabel;
        private System.Windows.Forms.PictureBox testPicBox;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.Label brightLabel;
        private System.Windows.Forms.LinkLabel folderLabel;
        private System.Windows.Forms.PictureBox feedbackBox;
    }
}

