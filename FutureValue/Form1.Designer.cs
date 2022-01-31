
namespace FutureValue
{
    partial class FutureValueForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblFuture = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMontly = new System.Windows.Forms.TextBox();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtFuture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(25, 29);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(165, 25);
            this.lblMonthly.TabIndex = 0;
            this.lblMonthly.Text = "Montly Investment:";
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(25, 70);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(165, 25);
            this.lblAPR.TabIndex = 1;
            this.lblAPR.Text = "Yearly Interest Rate:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(25, 110);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(148, 25);
            this.lblYears.TabIndex = 2;
            this.lblYears.Text = "Number of Years:";
            // 
            // lblFuture
            // 
            this.lblFuture.AutoSize = true;
            this.lblFuture.Location = new System.Drawing.Point(25, 149);
            this.lblFuture.Name = "lblFuture";
            this.lblFuture.Size = new System.Drawing.Size(113, 25);
            this.lblFuture.TabIndex = 3;
            this.lblFuture.Text = "Future Value:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 201);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 34);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(196, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMontly
            // 
            this.txtMontly.Location = new System.Drawing.Point(196, 26);
            this.txtMontly.Name = "txtMontly";
            this.txtMontly.Size = new System.Drawing.Size(150, 31);
            this.txtMontly.TabIndex = 6;
            this.txtMontly.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMontly.MouseHover += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(196, 67);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(150, 31);
            this.txtAPR.TabIndex = 7;
            this.txtAPR.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtAPR.DoubleClick += new System.EventHandler(this.txtAPR_DoubleClick);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(196, 107);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(150, 31);
            this.txtYears.TabIndex = 8;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtFuture
            // 
            this.txtFuture.Location = new System.Drawing.Point(196, 152);
            this.txtFuture.Name = "txtFuture";
            this.txtFuture.ReadOnly = true;
            this.txtFuture.Size = new System.Drawing.Size(150, 31);
            this.txtFuture.TabIndex = 9;
            this.txtFuture.TabStop = false;
            // 
            // FutureValueForm
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(381, 265);
            this.Controls.Add(this.txtFuture);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtAPR);
            this.Controls.Add(this.txtMontly);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblFuture);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblAPR);
            this.Controls.Add(this.lblMonthly);
            this.Name = "FutureValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.DoubleClick += new System.EventHandler(this.FutureValueForm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblFuture;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMontly;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtFuture;
    }
}

