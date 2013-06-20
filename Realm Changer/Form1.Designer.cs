namespace Realm_Changer
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddServerButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddServerButton
            // 
            this.AddServerButton.Location = new System.Drawing.Point(12, 12);
            this.AddServerButton.Name = "AddServerButton";
            this.AddServerButton.Size = new System.Drawing.Size(160, 23);
            this.AddServerButton.TabIndex = 1;
            this.AddServerButton.Text = "Add Server";
            this.AddServerButton.UseVisualStyleBackColor = true;
            this.AddServerButton.Click += new System.EventHandler(this.AddServerButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 41);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(160, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Server Info";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveServerButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(389, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Launch Game";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 103);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddServerButton);
            this.Name = "MainForm";
            this.Text = "Server Changer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddServerButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

