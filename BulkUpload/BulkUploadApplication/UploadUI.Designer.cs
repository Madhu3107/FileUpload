namespace BulkUploadApplication
{
    partial class UploadUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingleFile = new System.Windows.Forms.RadioButton();
            this.MultipleFile = new System.Windows.Forms.RadioButton();
            this.Upload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Upload System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MultipleFile);
            this.panel1.Controls.Add(this.SingleFile);
            this.panel1.Location = new System.Drawing.Point(236, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 100);
            this.panel1.TabIndex = 1;
           // this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SingleFile
            // 
            this.SingleFile.AutoSize = true;
            this.SingleFile.Location = new System.Drawing.Point(37, 15);
            this.SingleFile.Name = "SingleFile";
            this.SingleFile.Size = new System.Drawing.Size(73, 17);
            this.SingleFile.TabIndex = 0;
            this.SingleFile.TabStop = true;
            this.SingleFile.Text = "Single File";
            this.SingleFile.UseVisualStyleBackColor = true;
            // 
            // MultipleFile
            // 
            this.MultipleFile.AutoSize = true;
            this.MultipleFile.Location = new System.Drawing.Point(37, 55);
            this.MultipleFile.Name = "MultipleFile";
            this.MultipleFile.Size = new System.Drawing.Size(80, 17);
            this.MultipleFile.TabIndex = 1;
            this.MultipleFile.TabStop = true;
            this.MultipleFile.Text = "Multiple File";
            this.MultipleFile.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.FlatAppearance.BorderSize = 3;
            this.Upload.Location = new System.Drawing.Point(273, 196);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // UploadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UploadUI";
            this.Text = "UploadUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SingleFile;
        private System.Windows.Forms.RadioButton MultipleFile;
        private System.Windows.Forms.Button Upload;
    }
}