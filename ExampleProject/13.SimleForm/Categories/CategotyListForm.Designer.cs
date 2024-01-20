namespace _13.SimleForm.Categories
{
    partial class CategoryListForm
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
            ID = _CategoryManager.GetFirstCategoryID();
            var category = _CategoryManager.GetCategory(ID);
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCreatedDateText = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(25, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNameText.Location = new System.Drawing.Point(30, 65);
            this.lblNameText.Name = category["Name"];
            this.lblNameText.Size = new System.Drawing.Size(0, 30);
            this.lblNameText.TabIndex = 1;
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDescriptionText.Location = new System.Drawing.Point(30, 136);
            this.lblDescriptionText.MaximumSize = new System.Drawing.Size(400, 500);
            this.lblDescriptionText.Name = category["Description"];
            this.lblDescriptionText.Size = new System.Drawing.Size(0, 30);
            this.lblDescriptionText.TabIndex = 3;
            this.lblDescriptionText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDescription.Location = new System.Drawing.Point(25, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 30);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(448, 118);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(308, 249);
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click_1);
            this.pbImage.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "Pictures", category["Image"]);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.Location = new System.Drawing.Point(537, 387);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 37);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCreatedDateText
            // 
            this.lblCreatedDateText.AutoSize = true;
            this.lblCreatedDateText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatedDateText.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCreatedDateText.Location = new System.Drawing.Point(25, 376);
            this.lblCreatedDateText.Name = category["CreatedDate"];
            this.lblCreatedDateText.Size = new System.Drawing.Size(0, 30);
            this.lblCreatedDateText.TabIndex = 9;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreatedDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCreatedDate.Location = new System.Drawing.Point(25, 337);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(168, 30);
            this.lblCreatedDate.TabIndex = 8;
            this.lblCreatedDate.Text = "Date of creation";
            // 
            // CategotyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCreatedDateText);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblName);
            this.Name = "CategotyListForm";
            this.Text = "CategotyListForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblNameText;
        private Label lblDescriptionText;
        private Label lblDescription;
        private PictureBox pbImage;
        private Button btnNext;
        private Label lblCreatedDateText;
        private Label lblCreatedDate;
    }
}