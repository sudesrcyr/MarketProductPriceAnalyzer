
namespace MarketList
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
            this.btnReadAllData = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReadAllData
            // 
            this.btnReadAllData.Location = new System.Drawing.Point(32, 58);
            this.btnReadAllData.Name = "btnReadAllData";
            this.btnReadAllData.Size = new System.Drawing.Size(161, 32);
            this.btnReadAllData.TabIndex = 0;
            this.btnReadAllData.Text = "Read all Data";
            this.btnReadAllData.UseVisualStyleBackColor = true;
            this.btnReadAllData.Click += new System.EventHandler(this.btnReadAllData_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(32, 214);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 32);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblItems
            // 
            this.lblItems.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblItems.Location = new System.Drawing.Point(29, 143);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(164, 23);
            this.lblItems.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(391, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 356);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnReadAllData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadAllData;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ListBox listBox1;
    }
}

