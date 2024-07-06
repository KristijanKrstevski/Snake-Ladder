namespace Snake_Ladder
{
    partial class FormGame
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            pictureBox1 = new PictureBox();
            pbDiceOne = new PictureBox();
            pbDiceTwo = new PictureBox();
            pbDiceThree = new PictureBox();
            pbDiceFour = new PictureBox();
            pbDiceFive = new PictureBox();
            pbDiceSix = new PictureBox();
            pbPlayerOne = new PictureBox();
            pbPlayerTwo = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnRoll = new Button();
            ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceFive).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceSix).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbPlayerOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize) pbPlayerTwo).BeginInit();
            SuspendLayout();
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point,  0);
            lblPlayer1.Location = new Point(680, 81);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(55, 23);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "label1";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 13F);
            lblPlayer2.Location = new Point(680, 129);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(59, 25);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.snake_ladder_image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(37, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 406);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pbDiceOne
            // 
            pbDiceOne.BackgroundImage = Properties.Resources._1;
            pbDiceOne.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceOne.Location = new Point(589, 268);
            pbDiceOne.Name = "pbDiceOne";
            pbDiceOne.Size = new Size(150, 150);
            pbDiceOne.TabIndex = 3;
            pbDiceOne.TabStop = false;
            // 
            // pbDiceTwo
            // 
            pbDiceTwo.BackgroundImage = Properties.Resources._2;
            pbDiceTwo.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceTwo.Location = new Point(589, 268);
            pbDiceTwo.Name = "pbDiceTwo";
            pbDiceTwo.Size = new Size(150, 150);
            pbDiceTwo.TabIndex = 4;
            pbDiceTwo.TabStop = false;
            // 
            // pbDiceThree
            // 
            pbDiceThree.BackgroundImage = Properties.Resources._3;
            pbDiceThree.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceThree.Location = new Point(589, 268);
            pbDiceThree.Name = "pbDiceThree";
            pbDiceThree.Size = new Size(150, 150);
            pbDiceThree.TabIndex = 5;
            pbDiceThree.TabStop = false;
            // 
            // pbDiceFour
            // 
            pbDiceFour.BackgroundImage = Properties.Resources._4;
            pbDiceFour.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceFour.Location = new Point(589, 268);
            pbDiceFour.Name = "pbDiceFour";
            pbDiceFour.Size = new Size(150, 150);
            pbDiceFour.TabIndex = 6;
            pbDiceFour.TabStop = false;
            // 
            // pbDiceFive
            // 
            pbDiceFive.BackgroundImage = Properties.Resources._5;
            pbDiceFive.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceFive.Location = new Point(589, 268);
            pbDiceFive.Name = "pbDiceFive";
            pbDiceFive.Size = new Size(150, 150);
            pbDiceFive.TabIndex = 7;
            pbDiceFive.TabStop = false;
            // 
            // pbDiceSix
            // 
            pbDiceSix.BackColor = Color.Transparent;
            pbDiceSix.BackgroundImage = Properties.Resources._6;
            pbDiceSix.BackgroundImageLayout = ImageLayout.Stretch;
            pbDiceSix.Location = new Point(589, 268);
            pbDiceSix.Name = "pbDiceSix";
            pbDiceSix.Size = new Size(150, 150);
            pbDiceSix.TabIndex = 8;
            pbDiceSix.TabStop = false;
            // 
            // pbPlayerOne
            // 
            pbPlayerOne.BackColor = Color.Blue;
            pbPlayerOne.Location = new Point(450, 25);
            pbPlayerOne.Name = "pbPlayerOne";
            pbPlayerOne.Size = new Size(30, 30);
            pbPlayerOne.TabIndex = 9;
            pbPlayerOne.TabStop = false;
            // 
            // pbPlayerTwo
            // 
            pbPlayerTwo.BackColor = Color.Red;
            pbPlayerTwo.Location = new Point(450, 76);
            pbPlayerTwo.Name = "pbPlayerTwo";
            pbPlayerTwo.Size = new Size(30, 30);
            pbPlayerTwo.TabIndex = 10;
            pbPlayerTwo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(570, 129);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 12;
            label2.Text = "PlayerTwo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(570, 81);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 11;
            label1.Text = "PlayerOne:";
            // 
            // btnRoll
            // 
            btnRoll.BackColor = Color.MediumSpringGreen;
            btnRoll.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRoll.Location = new Point(610, 184);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(106, 59);
            btnRoll.TabIndex = 13;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = false;
            btnRoll.Click += btnRoll_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.game_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRoll);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbPlayerTwo);
            Controls.Add(pbPlayerOne);
            Controls.Add(pbDiceSix);
            Controls.Add(pbDiceFive);
            Controls.Add(pbDiceFour);
            Controls.Add(pbDiceThree);
            Controls.Add(pbDiceTwo);
            Controls.Add(pbDiceOne);
            Controls.Add(pictureBox1);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer1);
            DoubleBuffered = true;
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "FormGame";
            Text = "Snakes and Ladders";
            Load += FormGame_Load;
            ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceOne).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceThree).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceFour).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceFive).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbDiceSix).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbPlayerOne).EndInit();
            ((System.ComponentModel.ISupportInitialize) pbPlayerTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblPlayer1;
        public Label lblPlayer2;
        private PictureBox pictureBox1;
        private PictureBox pbDiceOne;
        private PictureBox pbDiceTwo;
        private PictureBox pbDiceThree;
        private PictureBox pbDiceFour;
        private PictureBox pbDiceFive;
        private PictureBox pbDiceSix;
        private PictureBox pbPlayerOne;
        private PictureBox pbPlayerTwo;
        private Label label2;
        private Label label1;
        private Button btnRoll;
    }
}