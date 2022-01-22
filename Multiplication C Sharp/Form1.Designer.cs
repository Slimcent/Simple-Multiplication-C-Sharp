namespace Multiplication_C_Sharp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblmultiplier = new System.Windows.Forms.Label();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtstop = new System.Windows.Forms.TextBox();
            this.txtmultiply = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmultiply);
            this.groupBox2.Controls.Add(this.txtstop);
            this.groupBox2.Controls.Add(this.txtstart);
            this.groupBox2.Controls.Add(this.lblmultiplier);
            this.groupBox2.Controls.Add(this.lblend);
            this.groupBox2.Controls.Add(this.lblstart);
            this.groupBox2.Location = new System.Drawing.Point(32, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(6, 16);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(77, 15);
            this.lblstart.TabIndex = 0;
            this.lblstart.Text = "Start Value";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(6, 45);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(72, 15);
            this.lblend.TabIndex = 2;
            this.lblend.Text = "End Value";
            // 
            // lblmultiplier
            // 
            this.lblmultiplier.AutoSize = true;
            this.lblmultiplier.Location = new System.Drawing.Point(6, 74);
            this.lblmultiplier.Name = "lblmultiplier";
            this.lblmultiplier.Size = new System.Drawing.Size(68, 15);
            this.lblmultiplier.TabIndex = 4;
            this.lblmultiplier.Text = "Multiplier";
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(100, 16);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(100, 21);
            this.txtstart.TabIndex = 5;
            // 
            // txtstop
            // 
            this.txtstop.Location = new System.Drawing.Point(100, 45);
            this.txtstop.Name = "txtstop";
            this.txtstop.Size = new System.Drawing.Size(100, 21);
            this.txtstop.TabIndex = 7;
            // 
            // txtmultiply
            // 
            this.txtmultiply.Location = new System.Drawing.Point(100, 74);
            this.txtmultiply.Name = "txtmultiply";
            this.txtmultiply.Size = new System.Drawing.Size(100, 21);
            this.txtmultiply.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnexit);
            this.groupBox3.Controls.Add(this.btnclear);
            this.groupBox3.Controls.Add(this.btnmultiply);
            this.groupBox3.Controls.Add(this.listbox);
            this.groupBox3.Location = new System.Drawing.Point(32, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(49, 10);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(132, 154);
            this.listbox.TabIndex = 0;
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(201, 20);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 23);
            this.btnmultiply.TabIndex = 10;
            this.btnmultiply.Text = "&Multiply";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(201, 49);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(201, 78);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 383);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TextBox txtmultiply;
        private System.Windows.Forms.TextBox txtstop;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.Label lblmultiplier;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
    }
}

