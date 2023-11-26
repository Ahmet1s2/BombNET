namespace BombNET
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
            this.label1 = new System.Windows.Forms.Label();
            this.IPBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PORTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MODEBOX = new System.Windows.Forms.ComboBox();
            this.START = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.THREAD_SIZE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP/DNS:";
            // 
            // IPBOX
            // 
            this.IPBOX.Location = new System.Drawing.Point(67, 13);
            this.IPBOX.Name = "IPBOX";
            this.IPBOX.Size = new System.Drawing.Size(182, 20);
            this.IPBOX.TabIndex = 1;
            this.IPBOX.TextChanged += new System.EventHandler(this.IPBOX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PORT:";
            // 
            // PORTBOX
            // 
            this.PORTBOX.Location = new System.Drawing.Point(67, 40);
            this.PORTBOX.Name = "PORTBOX";
            this.PORTBOX.Size = new System.Drawing.Size(182, 20);
            this.PORTBOX.TabIndex = 1;
            this.PORTBOX.TextChanged += new System.EventHandler(this.PORTBOX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODE:";
            // 
            // MODEBOX
            // 
            this.MODEBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MODEBOX.FormattingEnabled = true;
            this.MODEBOX.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.MODEBOX.Location = new System.Drawing.Point(67, 66);
            this.MODEBOX.Name = "MODEBOX";
            this.MODEBOX.Size = new System.Drawing.Size(182, 21);
            this.MODEBOX.TabIndex = 2;
            this.MODEBOX.SelectedIndexChanged += new System.EventHandler(this.MODEBOX_SelectedIndexChanged);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(24, 176);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(88, 61);
            this.START.TabIndex = 3;
            this.START.Text = "Start Bomb";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(161, 176);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(88, 61);
            this.STOP.TabIndex = 3;
            this.STOP.Text = "Stop Bomb";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "THREADS:";
            // 
            // THREAD_SIZE
            // 
            this.THREAD_SIZE.Location = new System.Drawing.Point(68, 95);
            this.THREAD_SIZE.Name = "THREAD_SIZE";
            this.THREAD_SIZE.Size = new System.Drawing.Size(181, 20);
            this.THREAD_SIZE.TabIndex = 4;
            this.THREAD_SIZE.TextChanged += new System.EventHandler(this.THREAD_SIZE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Written By: -nu11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.THREAD_SIZE);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.START);
            this.Controls.Add(this.MODEBOX);
            this.Controls.Add(this.PORTBOX);
            this.Controls.Add(this.IPBOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BombNET 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PORTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MODEBOX;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox THREAD_SIZE;
        private System.Windows.Forms.Label label5;
    }
}

