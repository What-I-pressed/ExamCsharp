namespace _13.SimleForm.Categories
{
    partial class CategoryCreationForm
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
            this.lblCategoryCreation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblImageURL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryCreation
            // 
            this.lblCategoryCreation.AutoSize = true;
            this.lblCategoryCreation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryCreation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCategoryCreation.Location = new System.Drawing.Point(261, 26);
            this.lblCategoryCreation.Name = "lblCategoryCreation";
            this.lblCategoryCreation.Size = new System.Drawing.Size(186, 30);
            this.lblCategoryCreation.TabIndex = 0;
            this.lblCategoryCreation.Text = "Category creation";
            this.lblCategoryCreation.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblName.Location = new System.Drawing.Point(43, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(43, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 36);
            this.txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(43, 194);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(404, 148);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDescription.Location = new System.Drawing.Point(43, 161);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 30);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pbImage
            // 
            this.pbImage.ImageLocation = "C:\\Users\\Антон\\source\\repos\\Exa\\ExampleProject\\13.SimleForm\\Pictures\\noImage.png";
            this.pbImage.Location = new System.Drawing.Point(498, 194);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(197, 148);
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCategory.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCreateCategory.Location = new System.Drawing.Point(312, 372);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(135, 41);
            this.btnCreateCategory.TabIndex = 6;
            this.btnCreateCategory.Text = "Create";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtURL.Location = new System.Drawing.Point(343, 109);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(352, 36);
            this.txtURL.TabIndex = 8;
            // 
            // lblImageURL
            // 
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImageURL.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblImageURL.Location = new System.Drawing.Point(343, 76);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(118, 30);
            this.lblImageURL.TabIndex = 7;
            this.lblImageURL.Text = "Image URL";
            // 
            // CategoryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblImageURL);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategoryCreation);
            this.Name = "CategoryCreationForm";
            this.Text = "CategoryCreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCategoryCreation;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblDescription;
        private PictureBox pbImage;
        private Button btnCreateCategory;
        private TextBox txtURL;
        private Label lblImageURL;
    }
}