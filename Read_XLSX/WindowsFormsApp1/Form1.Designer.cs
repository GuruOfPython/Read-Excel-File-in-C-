namespace WindowsFormsApp1
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
            this.read_xlsx_button = new System.Windows.Forms.Button();
            this.http_request_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read_xlsx_button
            // 
            this.read_xlsx_button.Location = new System.Drawing.Point(50, 12);
            this.read_xlsx_button.Name = "read_xlsx_button";
            this.read_xlsx_button.Size = new System.Drawing.Size(84, 48);
            this.read_xlsx_button.TabIndex = 0;
            this.read_xlsx_button.Text = "Read XLSX File";
            this.read_xlsx_button.UseVisualStyleBackColor = true;
            this.read_xlsx_button.Click += new System.EventHandler(this.read_xlsx_button_Click);
            // 
            // http_request_button
            // 
            this.http_request_button.Location = new System.Drawing.Point(186, 18);
            this.http_request_button.Name = "http_request_button";
            this.http_request_button.Size = new System.Drawing.Size(107, 37);
            this.http_request_button.TabIndex = 1;
            this.http_request_button.Text = "Http Request";
            this.http_request_button.UseVisualStyleBackColor = true;
            this.http_request_button.Click += new System.EventHandler(this.http_request_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 342);
            this.Controls.Add(this.http_request_button);
            this.Controls.Add(this.read_xlsx_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button read_xlsx_button;
        private System.Windows.Forms.Button http_request_button;
    }
}

