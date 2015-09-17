namespace ImageConverter
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnConvertFiles = new System.Windows.Forms.Button();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openImageFiles = new System.Windows.Forms.OpenFileDialog();
            this.txtOutputLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.AllowDrop = true;
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 12);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(251, 199);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            this.lstFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstFiles_KeyUp);
            // 
            // imgPreview
            // 
            this.imgPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPreview.Location = new System.Drawing.Point(269, 12);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(232, 199);
            this.imgPreview.TabIndex = 1;
            this.imgPreview.TabStop = false;
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(12, 227);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(134, 84);
            this.btnAddFiles.TabIndex = 2;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnConvertFiles
            // 
            this.btnConvertFiles.Location = new System.Drawing.Point(359, 227);
            this.btnConvertFiles.Name = "btnConvertFiles";
            this.btnConvertFiles.Size = new System.Drawing.Size(142, 84);
            this.btnConvertFiles.TabIndex = 3;
            this.btnConvertFiles.Text = "Convert Files";
            this.btnConvertFiles.UseVisualStyleBackColor = true;
            this.btnConvertFiles.Click += new System.EventHandler(this.btnConvertFiles_Click);
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "jpeg",
            "gif",
            "png",
            "bmp"});
            this.cmbFormat.Location = new System.Drawing.Point(163, 247);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(176, 21);
            this.cmbFormat.TabIndex = 4;
            this.cmbFormat.Text = "jpeg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target Format";
            // 
            // openImageFiles
            // 
            this.openImageFiles.Filter = "Image Files|*.bmp;*.jpg;*.gif;*.png|All Files|*.*";
            this.openImageFiles.Multiselect = true;
            // 
            // txtOutputLocation
            // 
            this.txtOutputLocation.Location = new System.Drawing.Point(163, 291);
            this.txtOutputLocation.Name = "txtOutputLocation";
            this.txtOutputLocation.Size = new System.Drawing.Size(176, 20);
            this.txtOutputLocation.TabIndex = 6;
            this.txtOutputLocation.Text = "C:\\ImageConverterOutput\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.btnConvertFiles);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.lstFiles);
            this.Name = "Form1";
            this.Text = "Image Converter";
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnConvertFiles;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openImageFiles;
        private System.Windows.Forms.TextBox txtOutputLocation;
        private System.Windows.Forms.Label label2;
    }
}

