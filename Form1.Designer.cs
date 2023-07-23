namespace ImageClassifiationDogs
{
    partial class DogsImageClassification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogsImageClassification));
            pictureBox = new PictureBox();
            btnBrowse = new Button();
            btnClassify = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = global::DogsImageClassification.Properties.Resources.test_golden_retriever;
            pictureBox.Location = new Point(12, 56);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(418, 301);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Silver;
            btnBrowse.Location = new Point(73, 376);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(120, 60);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnClassify
            // 
            btnClassify.BackColor = Color.Silver;
            btnClassify.Location = new Point(246, 376);
            btnClassify.Name = "btnClassify";
            btnClassify.Size = new Size(120, 60);
            btnClassify.TabIndex = 2;
            btnClassify.Text = "Classify";
            btnClassify.UseVisualStyleBackColor = false;
            btnClassify.Click += btnClassify_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 456);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 456);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 9);
            label3.Name = "label3";
            label3.Size = new Size(305, 33);
            label3.TabIndex = 5;
            label3.Text = "DogBreed Detective";
            // 
            // DogsImageClassification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(442, 500);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClassify);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DogsImageClassification";
            Text = "DogBreed Detective";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnBrowse;
        private Button btnClassify;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}