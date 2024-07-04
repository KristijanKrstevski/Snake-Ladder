namespace Snake_Ladder
{
    partial class FormWelocome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelocome));
            btnStart = new Button();
            tbPlayer1 = new TextBox();
            tbPlayer2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(297, 174);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tbPlayer1
            // 
            tbPlayer1.Location = new Point(201, 88);
            tbPlayer1.Name = "tbPlayer1";
            tbPlayer1.Size = new Size(100, 23);
            tbPlayer1.TabIndex = 1;
            // 
            // tbPlayer2
            // 
            tbPlayer2.Location = new Point(382, 88);
            tbPlayer2.Name = "tbPlayer2";
            tbPlayer2.Size = new Size(100, 23);
            tbPlayer2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 58);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "PlayerOne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 58);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "PlayerTwo";
            // 
            // FormWelocome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_intro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 378);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPlayer2);
            Controls.Add(tbPlayer1);
            Controls.Add(btnStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWelocome";
            Text = "Form1";
            Load += FormWelocome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox tbPlayer1;
        private TextBox tbPlayer2;
        private Label label1;
        private Label label2;
    }
}
