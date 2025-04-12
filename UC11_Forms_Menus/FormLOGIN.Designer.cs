namespace UC11_Forms_Menus
{
    partial class FormLOGIN
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
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.Location = new System.Drawing.Point(130, 156);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonENTRAR.TabIndex = 0;
            this.buttonENTRAR.Text = "Entrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 238);
            this.Controls.Add(this.buttonENTRAR);
            this.Name = "FormLOGIN";
            this.Text = "FormLOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonENTRAR;
    }
}