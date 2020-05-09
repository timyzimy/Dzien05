namespace StooqParser
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
            this.tbTicker = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtStop = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnParse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj ticker:";
            // 
            // tbTicker
            // 
            this.tbTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTicker.Location = new System.Drawing.Point(106, 20);
            this.tbTicker.MaxLength = 3;
            this.tbTicker.Name = "tbTicker";
            this.tbTicker.Size = new System.Drawing.Size(83, 20);
            this.tbTicker.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(205, 20);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(140, 20);
            this.dtStart.TabIndex = 2;
            // 
            // dtStop
            // 
            this.dtStop.Location = new System.Drawing.Point(370, 20);
            this.dtStop.Name = "dtStop";
            this.dtStop.Size = new System.Drawing.Size(152, 20);
            this.dtStop.TabIndex = 3;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(37, 79);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(584, 236);
            this.dgvData.TabIndex = 4;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(540, 17);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(81, 30);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Pobierz";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 365);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtStop);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbTicker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTicker;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtStop;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnParse;
    }
}

