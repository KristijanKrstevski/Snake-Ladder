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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelocome));
            btnStart = new Button();
            tbPlayer1 = new TextBox();
            tbPlayer2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            btnHowToPlay = new Button();
            ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize) errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btnStart.Location = new Point(249, 171);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(185, 56);
            btnStart.TabIndex = 0;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tbPlayer1
            // 
            tbPlayer1.Location = new Point(184, 310);
            tbPlayer1.Name = "tbPlayer1";
            tbPlayer1.Size = new Size(100, 23);
            tbPlayer1.TabIndex = 1;
            tbPlayer1.Validating += tbPlayer1_Validating;
            // 
            // tbPlayer2
            // 
            tbPlayer2.Location = new Point(415, 310);
            tbPlayer2.Name = "tbPlayer2";
            tbPlayer2.Size = new Size(100, 23);
            tbPlayer2.TabIndex = 2;
            tbPlayer2.Validating += tbPlayer2_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 292);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "PlayerOne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(435, 292);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "PlayerTwo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.title_removebg_preview;
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 107);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnHowToPlay
            // 
            btnHowToPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btnHowToPlay.Location = new Point(280, 233);
            btnHowToPlay.Name = "btnHowToPlay";
            btnHowToPlay.Size = new Size(125, 45);
            btnHowToPlay.TabIndex = 6;
            btnHowToPlay.Text = "HOW TO PLAY";
            btnHowToPlay.UseVisualStyleBackColor = true;
            btnHowToPlay.Click += btnHowToPlay_Click;
            // 
            // FormWelocome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_intro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(672, 378);
            Controls.Add(btnHowToPlay);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPlayer2);
            Controls.Add(tbPlayer1);
            Controls.Add(btnStart);
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "FormWelocome";
            Text = "Menu";
            Load += FormWelocome_Load;
            ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize) errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox tbPlayer1;
        private TextBox tbPlayer2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private Button btnHowToPlay;
    }
}
