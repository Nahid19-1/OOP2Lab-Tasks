
namespace Bookms.Views
{
    partial class Addbook
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
            this.tBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tBEdition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBAuthorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterationForm = new System.Windows.Forms.Label();
            this.btnAllbooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(389, 104);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(140, 20);
            this.tBName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(417, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tBEdition
            // 
            this.tBEdition.Location = new System.Drawing.Point(389, 172);
            this.tBEdition.Name = "tBEdition";
            this.tBEdition.Size = new System.Drawing.Size(140, 20);
            this.tBEdition.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edition";
            // 
            // tBAuthorname
            // 
            this.tBAuthorname.Location = new System.Drawing.Point(389, 140);
            this.tBAuthorname.Name = "tBAuthorname";
            this.tBAuthorname.Size = new System.Drawing.Size(140, 20);
            this.tBAuthorname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Authorname";
            // 
            // RegisterationForm
            // 
            this.RegisterationForm.AutoSize = true;
            this.RegisterationForm.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterationForm.Location = new System.Drawing.Point(273, 46);
            this.RegisterationForm.Name = "RegisterationForm";
            this.RegisterationForm.Size = new System.Drawing.Size(218, 25);
            this.RegisterationForm.TabIndex = 13;
            this.RegisterationForm.Text = "Book Information";
            // 
            // btnAllbooks
            // 
            this.btnAllbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllbooks.Location = new System.Drawing.Point(241, 213);
            this.btnAllbooks.Name = "btnAllbooks";
            this.btnAllbooks.Size = new System.Drawing.Size(152, 32);
            this.btnAllbooks.TabIndex = 21;
            this.btnAllbooks.Text = "Show all Books";
            this.btnAllbooks.UseVisualStyleBackColor = true;
            this.btnAllbooks.Click += new System.EventHandler(this.btnAllbooks_Click);
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllbooks);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBEdition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBAuthorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterationForm);
            this.Name = "Addbook";
            this.Text = "Addbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tBEdition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBAuthorname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RegisterationForm;
        private System.Windows.Forms.Button btnAllbooks;
    }
}