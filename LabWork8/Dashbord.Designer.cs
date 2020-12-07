namespace LabWork8
{
    partial class Dashbord
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
            this.radioButtonAddUser = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteUser = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonAddUser
            // 
            this.radioButtonAddUser.AutoSize = true;
            this.radioButtonAddUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAddUser.Location = new System.Drawing.Point(120, 53);
            this.radioButtonAddUser.Name = "radioButtonAddUser";
            this.radioButtonAddUser.Size = new System.Drawing.Size(107, 26);
            this.radioButtonAddUser.TabIndex = 0;
            this.radioButtonAddUser.TabStop = true;
            this.radioButtonAddUser.Text = "Add User";
            this.radioButtonAddUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteUser
            // 
            this.radioButtonDeleteUser.AutoSize = true;
            this.radioButtonDeleteUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDeleteUser.Location = new System.Drawing.Point(294, 53);
            this.radioButtonDeleteUser.Name = "radioButtonDeleteUser";
            this.radioButtonDeleteUser.Size = new System.Drawing.Size(129, 26);
            this.radioButtonDeleteUser.TabIndex = 1;
            this.radioButtonDeleteUser.TabStop = true;
            this.radioButtonDeleteUser.Text = "Delete User";
            this.radioButtonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateUser
            // 
            this.radioButtonUpdateUser.AutoSize = true;
            this.radioButtonUpdateUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUpdateUser.Location = new System.Drawing.Point(475, 53);
            this.radioButtonUpdateUser.Name = "radioButtonUpdateUser";
            this.radioButtonUpdateUser.Size = new System.Drawing.Size(135, 26);
            this.radioButtonUpdateUser.TabIndex = 2;
            this.radioButtonUpdateUser.TabStop = true;
            this.radioButtonUpdateUser.Text = "Update User";
            this.radioButtonUpdateUser.UseVisualStyleBackColor = true;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 271);
            this.Controls.Add(this.radioButtonUpdateUser);
            this.Controls.Add(this.radioButtonDeleteUser);
            this.Controls.Add(this.radioButtonAddUser);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAddUser;
        private System.Windows.Forms.RadioButton radioButtonDeleteUser;
        private System.Windows.Forms.RadioButton radioButtonUpdateUser;
    }
}