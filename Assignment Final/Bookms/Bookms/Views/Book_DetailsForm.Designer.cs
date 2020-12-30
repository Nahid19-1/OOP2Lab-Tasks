
namespace Bookms.Views
{
    partial class Book_DetailsForm
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
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.RegisterationForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid
            // 
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(173, 124);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(442, 198);
            this.dGrid.TabIndex = 13;
            // 
            // RegisterationForm
            // 
            this.RegisterationForm.AutoSize = true;
            this.RegisterationForm.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterationForm.Location = new System.Drawing.Point(320, 47);
            this.RegisterationForm.Name = "RegisterationForm";
            this.RegisterationForm.Size = new System.Drawing.Size(158, 25);
            this.RegisterationForm.TabIndex = 14;
            this.RegisterationForm.Text = "Book Details";
            // 
            // Book_DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterationForm);
            this.Controls.Add(this.dGrid);
            this.Name = "Book_DetailsForm";
            this.Text = "Book_DetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Label RegisterationForm;
    }
}