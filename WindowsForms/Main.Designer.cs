namespace WindowsForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnReS = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(268, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome. Which table will be processed? ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 26);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.btnList);
            this.panel4.Controls.Add(this.btnReS);
            this.panel4.Controls.Add(this.btnexit);
            this.panel4.Controls.Add(this.btnBuy);
            this.panel4.Controls.Add(this.btntt);
            this.panel4.Controls.Add(this.btnT);
            this.panel4.Controls.Add(this.btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 42);
            this.panel4.TabIndex = 3;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Silver;
            this.btnList.Location = new System.Drawing.Point(521, 8);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(83, 23);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Item List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReS
            // 
            this.btnReS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReS.Location = new System.Drawing.Point(299, 8);
            this.btnReS.Name = "btnReS";
            this.btnReS.Size = new System.Drawing.Size(77, 23);
            this.btnReS.TabIndex = 7;
            this.btnReS.Text = "Receipt Sell";
            this.btnReS.UseVisualStyleBackColor = false;
            this.btnReS.Click += new System.EventHandler(this.btnReS_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DarkRed;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(676, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 33);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Close";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuy.Location = new System.Drawing.Point(382, 8);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Receipt Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntt.Location = new System.Drawing.Point(200, 8);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(93, 23);
            this.btntt.TabIndex = 2;
            this.btntt.Text = "Transaction Sell";
            this.btntt.UseVisualStyleBackColor = false;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnT.Location = new System.Drawing.Point(93, 8);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(101, 23);
            this.btnT.TabIndex = 1;
            this.btnT.Text = "Transaction Buy";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn.Location = new System.Drawing.Point(12, 8);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Item";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 382);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReS;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnList;
    }
}