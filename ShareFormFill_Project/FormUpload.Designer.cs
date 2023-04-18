namespace ShareFormFill_Project
{
    partial class FormUpload
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
            pathTextBox = new TextBox();
            projectTitle = new Label();
            fillUpButton = new Button();
            uploadFormButton = new Button();
            label2 = new Label();
            developerLabel = new Label();
            SuspendLayout();
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(163, 59);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(418, 27);
            pathTextBox.TabIndex = 0;
            // 
            // projectTitle
            // 
            projectTitle.AutoSize = true;
            projectTitle.BackColor = Color.Transparent;
            projectTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            projectTitle.Location = new Point(259, 24);
            projectTitle.Name = "projectTitle";
            projectTitle.Size = new Size(240, 18);
            projectTitle.TabIndex = 1;
            projectTitle.Text = "India IPO Share/Stock Form Fill UP";
            // 
            // fillUpButton
            // 
            fillUpButton.Location = new Point(392, 109);
            fillUpButton.Name = "fillUpButton";
            fillUpButton.Size = new Size(189, 29);
            fillUpButton.TabIndex = 2;
            fillUpButton.Text = "Fill the form";
            fillUpButton.UseVisualStyleBackColor = true;
            fillUpButton.Click += fillUpButtonClick;
            // 
            // uploadFormButton
            // 
            uploadFormButton.BackColor = Color.Transparent;
            uploadFormButton.Location = new Point(163, 109);
            uploadFormButton.Name = "uploadFormButton";
            uploadFormButton.Size = new Size(203, 29);
            uploadFormButton.TabIndex = 3;
            uploadFormButton.Text = "Upload the ASBA Form";
            uploadFormButton.UseVisualStyleBackColor = false;
            uploadFormButton.Click += uploadFormButtonClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 169);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // developerLabel
            // 
            developerLabel.AutoSize = true;
            developerLabel.BackColor = Color.Transparent;
            developerLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            developerLabel.Location = new Point(259, 170);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new Size(197, 18);
            developerLabel.TabIndex = 5;
            developerLabel.Text = "Developed By : Jainam Shah";
            // 
            // FormUpload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 225);
            Controls.Add(developerLabel);
            Controls.Add(label2);
            Controls.Add(uploadFormButton);
            Controls.Add(fillUpButton);
            Controls.Add(projectTitle);
            Controls.Add(pathTextBox);
            Name = "FormUpload";
            Text = "Auto Form Fill Up By Jainam Shah";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pathTextBox;
        private Label projectTitle;
        private Button fillUpButton;
        private Button uploadFormButton;
        private Label label2;
        private Label developerLabel;
    }
}