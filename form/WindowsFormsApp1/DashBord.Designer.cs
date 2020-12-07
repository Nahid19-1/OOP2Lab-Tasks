namespace WindowsFormsApp1
{
    partial class DashBord
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
            this.rTOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTOutput
            // 
            this.rTOutput.AccessibleName = "rTOutput";
            this.rTOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rTOutput.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTOutput.Location = new System.Drawing.Point(113, 7);
            this.rTOutput.Name = "rTOutput";
            this.rTOutput.Size = new System.Drawing.Size(397, 419);
            this.rTOutput.TabIndex = 1;
            this.rTOutput.Text = "";
            // 
            // DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 438);
            this.Controls.Add(this.rTOutput);
            this.Name = "DashBord";
            this.Text = "DashBord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTOutput;
    }
}