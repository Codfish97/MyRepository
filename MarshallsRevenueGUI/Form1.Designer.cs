namespace MarshallsRevenueGUI
{
    partial class marshallsRevenue
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(288, 118);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Total";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interior Murals";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(12, 25);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exterior Murals";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(118, 25);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 20);
            this.txtExt.TabIndex = 2;
            this.txtExt.TextChanged += new System.EventHandler(this.txtExt_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 63);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 1;
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.Location = new System.Drawing.Point(12, 90);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(0, 13);
            this.lblMore.TabIndex = 1;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(224, 25);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(100, 20);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtExt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Month (1-12)";
            // 
            // marshallsRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 153);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "marshallsRevenue";
            this.Text = "Marshalls Murals";
            this.Load += new System.EventHandler(this.marshallsRevenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMore;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label3;
    }
}

