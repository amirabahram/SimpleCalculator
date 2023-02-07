
namespace MyCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.NumericUpDown();
            this.btnPls = new System.Windows.Forms.Button();
            this.btnDvd = new System.Windows.Forms.Button();
            this.btnMlt = new System.Windows.Forms.Button();
            this.btnMns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2nd Number:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(196, 28);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(312, 22);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(196, 66);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(312, 22);
            this.txt2.TabIndex = 3;
            // 
            // btnPls
            // 
            this.btnPls.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPls.Location = new System.Drawing.Point(34, 106);
            this.btnPls.Name = "btnPls";
            this.btnPls.Size = new System.Drawing.Size(115, 41);
            this.btnPls.TabIndex = 4;
            this.btnPls.Text = "+";
            this.btnPls.UseVisualStyleBackColor = true;
            this.btnPls.Click += new System.EventHandler(this.btnPls_Click);
            // 
            // btnDvd
            // 
            this.btnDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDvd.Location = new System.Drawing.Point(445, 106);
            this.btnDvd.Name = "btnDvd";
            this.btnDvd.Size = new System.Drawing.Size(115, 41);
            this.btnDvd.TabIndex = 5;
            this.btnDvd.Text = "/";
            this.btnDvd.UseVisualStyleBackColor = true;
            this.btnDvd.Click += new System.EventHandler(this.btnDvd_Click);
            // 
            // btnMlt
            // 
            this.btnMlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMlt.Location = new System.Drawing.Point(305, 106);
            this.btnMlt.Name = "btnMlt";
            this.btnMlt.Size = new System.Drawing.Size(115, 41);
            this.btnMlt.TabIndex = 6;
            this.btnMlt.Text = "*";
            this.btnMlt.UseVisualStyleBackColor = true;
            this.btnMlt.Click += new System.EventHandler(this.btnMlt_Click);
            // 
            // btnMns
            // 
            this.btnMns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMns.Location = new System.Drawing.Point(166, 106);
            this.btnMns.Name = "btnMns";
            this.btnMns.Size = new System.Drawing.Size(115, 41);
            this.btnMns.TabIndex = 7;
            this.btnMns.Text = "-";
            this.btnMns.UseVisualStyleBackColor = true;
            this.btnMns.Click += new System.EventHandler(this.btnMns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 187);
            this.Controls.Add(this.btnMns);
            this.Controls.Add(this.btnMlt);
            this.Controls.Add(this.btnDvd);
            this.Controls.Add(this.btnPls);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.txt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt1;
        private System.Windows.Forms.NumericUpDown txt2;
        private System.Windows.Forms.Button btnPls;
        private System.Windows.Forms.Button btnDvd;
        private System.Windows.Forms.Button btnMlt;
        private System.Windows.Forms.Button btnMns;
    }
}

