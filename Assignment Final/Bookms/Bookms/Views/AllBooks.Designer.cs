
namespace Bookms.Views
{
    partial class AllBooks
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
            this.bunSearch = new System.Windows.Forms.Button();
            this.tBSraech = new System.Windows.Forms.TextBox();
            this.btnBookDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBbookinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // bunSearch
            // 
            this.bunSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunSearch.Location = new System.Drawing.Point(525, 40);
            this.bunSearch.Name = "bunSearch";
            this.bunSearch.Size = new System.Drawing.Size(100, 31);
            this.bunSearch.TabIndex = 11;
            this.bunSearch.Text = "Search";
            this.bunSearch.UseVisualStyleBackColor = true;
            this.bunSearch.Click += new System.EventHandler(this.bunSearch_Click);
            // 
            // tBSraech
            // 
            this.tBSraech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSraech.Location = new System.Drawing.Point(302, 42);
            this.tBSraech.Name = "tBSraech";
            this.tBSraech.Size = new System.Drawing.Size(183, 26);
            this.tBSraech.TabIndex = 10;
            // 
            // btnBookDetail
            // 
            this.btnBookDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDetail.Location = new System.Drawing.Point(466, 207);
            this.btnBookDetail.Name = "btnBookDetail";
            this.btnBookDetail.Size = new System.Drawing.Size(100, 31);
            this.btnBookDetail.TabIndex = 13;
            this.btnBookDetail.Text = "Book Detail";
            this.btnBookDetail.UseVisualStyleBackColor = true;
            this.btnBookDetail.Click += new System.EventHandler(this.btnBookDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search Booked Info";
            // 
            // tBbookinfo
            // 
            this.tBbookinfo.Location = new System.Drawing.Point(466, 121);
            this.tBbookinfo.Name = "tBbookinfo";
            this.tBbookinfo.Size = new System.Drawing.Size(127, 20);
            this.tBbookinfo.TabIndex = 15;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBbookinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookDetail);
            this.Controls.Add(this.bunSearch);
            this.Controls.Add(this.tBSraech);
            this.Controls.Add(this.label1);
            this.Name = "AllBooks";
            this.Text = "AllBooks";
            this.Load += new System.EventHandler(this.AllBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bunSearch;
        private System.Windows.Forms.TextBox tBSraech;
        private System.Windows.Forms.Button btnBookDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBbookinfo;
    }
}