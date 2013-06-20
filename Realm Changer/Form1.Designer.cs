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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddServerButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LaunchGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddServerButton
            // 
            this.AddServerButton.BackColor = System.Drawing.Color.White;
            this.AddServerButton.Location = new System.Drawing.Point(9, 10);
            this.AddServerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddServerButton.Name = "AddServerButton";
            this.AddServerButton.Size = new System.Drawing.Size(120, 19);
            this.AddServerButton.TabIndex = 1;
            this.AddServerButton.Text = "Add Server";
            this.AddServerButton.UseVisualStyleBackColor = false;
            this.AddServerButton.Click += new System.EventHandler(this.AddServerButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(9, 33);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 19);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Server Info";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Server";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RemoveServerButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // LaunchGameButton
            // 
            this.LaunchGameButton.BackColor = System.Drawing.Color.White;
            this.LaunchGameButton.Location = new System.Drawing.Point(148, 33);
            this.LaunchGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LaunchGameButton.Name = "LaunchGameButton";
            this.LaunchGameButton.Size = new System.Drawing.Size(292, 41);
            this.LaunchGameButton.TabIndex = 5;
            this.LaunchGameButton.Text = "Launch Game";
            this.LaunchGameButton.UseVisualStyleBackColor = false;
            this.LaunchGameButton.Click += new System.EventHandler(this.LaunchGameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(458, 84);
            this.Controls.Add(this.LaunchGameButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddServerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button LaunchGameButton;
    }
}

