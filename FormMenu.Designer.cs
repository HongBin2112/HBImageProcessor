namespace HBImageProcessor
{
    partial class FormMenu
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnImageToText = new System.Windows.Forms.Button();
            this.btnImageProcessing = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(280, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Menu";
            // 
            // panelOptions
            // 
            this.panelOptions.AutoScroll = true;
            this.panelOptions.AutoSize = true;
            this.panelOptions.Controls.Add(this.btnImageToText);
            this.panelOptions.Controls.Add(this.btnImageProcessing);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 60);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(280, 96);
            this.panelOptions.TabIndex = 1;
            // 
            // btnImageToText
            // 
            this.btnImageToText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnImageToText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImageToText.FlatAppearance.BorderSize = 0;
            this.btnImageToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageToText.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImageToText.Location = new System.Drawing.Point(0, 48);
            this.btnImageToText.Margin = new System.Windows.Forms.Padding(0);
            this.btnImageToText.Name = "btnImageToText";
            this.btnImageToText.Size = new System.Drawing.Size(280, 48);
            this.btnImageToText.TabIndex = 1;
            this.btnImageToText.Text = "Image To Text";
            this.btnImageToText.UseVisualStyleBackColor = false;
            // 
            // btnImageProcessing
            // 
            this.btnImageProcessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnImageProcessing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImageProcessing.FlatAppearance.BorderSize = 0;
            this.btnImageProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageProcessing.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnImageProcessing.Location = new System.Drawing.Point(0, 0);
            this.btnImageProcessing.Margin = new System.Windows.Forms.Padding(0);
            this.btnImageProcessing.Name = "btnImageProcessing";
            this.btnImageProcessing.Size = new System.Drawing.Size(280, 48);
            this.btnImageProcessing.TabIndex = 0;
            this.btnImageProcessing.Text = "Image Processing";
            this.btnImageProcessing.UseVisualStyleBackColor = false;
            this.btnImageProcessing.Click += new System.EventHandler(this.btnImageProcessing_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Image = global::HBImageProcessor.Properties.Resources.previous;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 510);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBack.Size = new System.Drawing.Size(280, 60);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Image = global::HBImageProcessor.Properties.Resources.image_remove;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(0, 450);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnClear.Size = new System.Drawing.Size(280, 60);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Loaded Images";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(280, 570);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Panel panelOptions;
        private Button btnImageProcessing;
        private Button btnImageToText;
        private Button btnBack;
        private Button btnClear;
    }
}