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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(418, 301);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Silver;
            btnBrowse.Location = new Point(73, 332);
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
            btnClassify.Location = new Point(246, 332);
            btnClassify.Name = "btnClassify";
            btnClassify.Size = new Size(120, 60);
            btnClassify.TabIndex = 2;
            btnClassify.Text = "Classify";
            btnClassify.UseVisualStyleBackColor = false;
            btnClassify.Click += btnClassify_Click;
            // 
            // DogsImageClassification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(442, 422);
            Controls.Add(btnClassify);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DogsImageClassification";
            Text = "DogsImageClassification";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnBrowse;
        private Button btnClassify;
    }
}