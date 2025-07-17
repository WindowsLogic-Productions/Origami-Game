namespace Origami_Game
{
    partial class Main
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
            this.Label1 = new System.Windows.Forms.Label();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.OrigamiButton4 = new System.Windows.Forms.Button();
            this.OrigamiButton3 = new System.Windows.Forms.Button();
            this.OrigamiButton2 = new System.Windows.Forms.Button();
            this.OrigamiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 221);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(13, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "0";
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Location = new System.Drawing.Point(142, 221);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(35, 13);
            this.LinkLabel2.TabIndex = 12;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Reset";
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(183, 221);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(35, 13);
            this.LinkLabel1.TabIndex = 11;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "About";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // OrigamiButton4
            // 
            this.OrigamiButton4.Location = new System.Drawing.Point(118, 118);
            this.OrigamiButton4.Name = "OrigamiButton4";
            this.OrigamiButton4.Size = new System.Drawing.Size(100, 100);
            this.OrigamiButton4.TabIndex = 10;
            this.OrigamiButton4.Text = "3";
            this.OrigamiButton4.UseVisualStyleBackColor = true;
            this.OrigamiButton4.Click += new System.EventHandler(this.OrigamiButton4_Click);
            // 
            // OrigamiButton3
            // 
            this.OrigamiButton3.Location = new System.Drawing.Point(12, 118);
            this.OrigamiButton3.Name = "OrigamiButton3";
            this.OrigamiButton3.Size = new System.Drawing.Size(100, 100);
            this.OrigamiButton3.TabIndex = 9;
            this.OrigamiButton3.Text = "2";
            this.OrigamiButton3.UseVisualStyleBackColor = true;
            this.OrigamiButton3.Click += new System.EventHandler(this.OrigamiButton3_Click);
            // 
            // OrigamiButton2
            // 
            this.OrigamiButton2.Location = new System.Drawing.Point(118, 12);
            this.OrigamiButton2.Name = "OrigamiButton2";
            this.OrigamiButton2.Size = new System.Drawing.Size(100, 100);
            this.OrigamiButton2.TabIndex = 8;
            this.OrigamiButton2.Text = "4";
            this.OrigamiButton2.UseVisualStyleBackColor = true;
            this.OrigamiButton2.Click += new System.EventHandler(this.OrigamiButton2_Click);
            // 
            // OrigamiButton
            // 
            this.OrigamiButton.Location = new System.Drawing.Point(12, 12);
            this.OrigamiButton.Name = "OrigamiButton";
            this.OrigamiButton.Size = new System.Drawing.Size(100, 100);
            this.OrigamiButton.TabIndex = 7;
            this.OrigamiButton.Text = "1";
            this.OrigamiButton.UseVisualStyleBackColor = true;
            this.OrigamiButton.Click += new System.EventHandler(this.OrigamiButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 255);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.OrigamiButton4);
            this.Controls.Add(this.OrigamiButton3);
            this.Controls.Add(this.OrigamiButton2);
            this.Controls.Add(this.OrigamiButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Origami Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Button OrigamiButton4;
        internal System.Windows.Forms.Button OrigamiButton3;
        internal System.Windows.Forms.Button OrigamiButton2;
        internal System.Windows.Forms.Button OrigamiButton;
    }
}

