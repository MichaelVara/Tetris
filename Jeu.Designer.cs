namespace Tetris
{
    partial class Jeu
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbNextBaton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbNextCube = new System.Windows.Forms.PictureBox();
            this.ptbNextL1 = new System.Windows.Forms.PictureBox();
            this.ptbNextL2 = new System.Windows.Forms.PictureBox();
            this.ptbNextS = new System.Windows.Forms.PictureBox();
            this.ptbNextT = new System.Windows.Forms.PictureBox();
            this.ptbNextZ = new System.Windows.Forms.PictureBox();
            this.lblLevelStat = new System.Windows.Forms.Label();
            this.lblLinesStat = new System.Windows.Forms.Label();
            this.lblScoreStat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextBaton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextCube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextZ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(512, 344);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(112, 41);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.BackColor = System.Drawing.Color.Transparent;
            this.lblLines.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLines.ForeColor = System.Drawing.Color.White;
            this.lblLines.Location = new System.Drawing.Point(512, 541);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(110, 41);
            this.lblLines.TabIndex = 2;
            this.lblLines.Text = "Lines";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(512, 738);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(113, 41);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ptbNextZ);
            this.groupBox1.Controls.Add(this.ptbNextT);
            this.groupBox1.Controls.Add(this.ptbNextS);
            this.groupBox1.Controls.Add(this.ptbNextL2);
            this.groupBox1.Controls.Add(this.ptbNextL1);
            this.groupBox1.Controls.Add(this.ptbNextCube);
            this.groupBox1.Controls.Add(this.ptbNextBaton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(519, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEXT";
            // 
            // ptbNextBaton
            // 
            this.ptbNextBaton.Image = global::Tetris.Properties.Resources.TetrisBlocksBatonEntier;
            this.ptbNextBaton.Location = new System.Drawing.Point(0, 28);
            this.ptbNextBaton.Name = "ptbNextBaton";
            this.ptbNextBaton.Size = new System.Drawing.Size(239, 180);
            this.ptbNextBaton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextBaton.TabIndex = 0;
            this.ptbNextBaton.TabStop = false;
            this.ptbNextBaton.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.TetrisBlocksMurCadre;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 792);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbNextCube
            // 
            this.ptbNextCube.Image = global::Tetris.Properties.Resources.TetrisBlocksCubeEntier;
            this.ptbNextCube.Location = new System.Drawing.Point(0, 28);
            this.ptbNextCube.Name = "ptbNextCube";
            this.ptbNextCube.Size = new System.Drawing.Size(239, 180);
            this.ptbNextCube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextCube.TabIndex = 1;
            this.ptbNextCube.TabStop = false;
            this.ptbNextCube.Visible = false;
            // 
            // ptbNextL1
            // 
            this.ptbNextL1.Image = global::Tetris.Properties.Resources.TetrisBlocksL1Entier;
            this.ptbNextL1.Location = new System.Drawing.Point(0, 28);
            this.ptbNextL1.Name = "ptbNextL1";
            this.ptbNextL1.Size = new System.Drawing.Size(239, 180);
            this.ptbNextL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextL1.TabIndex = 5;
            this.ptbNextL1.TabStop = false;
            this.ptbNextL1.Visible = false;
            // 
            // ptbNextL2
            // 
            this.ptbNextL2.Image = global::Tetris.Properties.Resources.TetrisBlocksL2Entier;
            this.ptbNextL2.Location = new System.Drawing.Point(0, 28);
            this.ptbNextL2.Name = "ptbNextL2";
            this.ptbNextL2.Size = new System.Drawing.Size(239, 180);
            this.ptbNextL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextL2.TabIndex = 5;
            this.ptbNextL2.TabStop = false;
            this.ptbNextL2.Visible = false;
            // 
            // ptbNextS
            // 
            this.ptbNextS.Image = global::Tetris.Properties.Resources.TetrisBlocksSEntier;
            this.ptbNextS.Location = new System.Drawing.Point(0, 28);
            this.ptbNextS.Name = "ptbNextS";
            this.ptbNextS.Size = new System.Drawing.Size(239, 180);
            this.ptbNextS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextS.TabIndex = 5;
            this.ptbNextS.TabStop = false;
            this.ptbNextS.Visible = false;
            // 
            // ptbNextT
            // 
            this.ptbNextT.Image = global::Tetris.Properties.Resources.TetrisBlocksTEntier;
            this.ptbNextT.Location = new System.Drawing.Point(0, 28);
            this.ptbNextT.Name = "ptbNextT";
            this.ptbNextT.Size = new System.Drawing.Size(239, 180);
            this.ptbNextT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextT.TabIndex = 5;
            this.ptbNextT.TabStop = false;
            this.ptbNextT.Visible = false;
            // 
            // ptbNextZ
            // 
            this.ptbNextZ.Image = global::Tetris.Properties.Resources.TetrisBlocksZEntier;
            this.ptbNextZ.Location = new System.Drawing.Point(0, 28);
            this.ptbNextZ.Name = "ptbNextZ";
            this.ptbNextZ.Size = new System.Drawing.Size(239, 180);
            this.ptbNextZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbNextZ.TabIndex = 5;
            this.ptbNextZ.TabStop = false;
            this.ptbNextZ.Visible = false;
            // 
            // lblLevelStat
            // 
            this.lblLevelStat.AutoSize = true;
            this.lblLevelStat.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelStat.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelStat.ForeColor = System.Drawing.Color.White;
            this.lblLevelStat.Location = new System.Drawing.Point(779, 344);
            this.lblLevelStat.Name = "lblLevelStat";
            this.lblLevelStat.Size = new System.Drawing.Size(40, 41);
            this.lblLevelStat.TabIndex = 5;
            this.lblLevelStat.Text = "0";
            // 
            // lblLinesStat
            // 
            this.lblLinesStat.AutoSize = true;
            this.lblLinesStat.BackColor = System.Drawing.Color.Transparent;
            this.lblLinesStat.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinesStat.ForeColor = System.Drawing.Color.White;
            this.lblLinesStat.Location = new System.Drawing.Point(779, 541);
            this.lblLinesStat.Name = "lblLinesStat";
            this.lblLinesStat.Size = new System.Drawing.Size(40, 41);
            this.lblLinesStat.TabIndex = 6;
            this.lblLinesStat.Text = "0";
            // 
            // lblScoreStat
            // 
            this.lblScoreStat.AutoSize = true;
            this.lblScoreStat.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreStat.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreStat.ForeColor = System.Drawing.Color.White;
            this.lblScoreStat.Location = new System.Drawing.Point(779, 738);
            this.lblScoreStat.Name = "lblScoreStat";
            this.lblScoreStat.Size = new System.Drawing.Size(40, 41);
            this.lblScoreStat.TabIndex = 7;
            this.lblScoreStat.Text = "0";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(927, 887);
            this.Controls.Add(this.lblScoreStat);
            this.Controls.Add(this.lblLinesStat);
            this.Controls.Add(this.lblLevelStat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextBaton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextCube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNextZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbNextBaton;
        private System.Windows.Forms.PictureBox ptbNextL1;
        private System.Windows.Forms.PictureBox ptbNextCube;
        private System.Windows.Forms.PictureBox ptbNextZ;
        private System.Windows.Forms.PictureBox ptbNextT;
        private System.Windows.Forms.PictureBox ptbNextS;
        private System.Windows.Forms.PictureBox ptbNextL2;
        private System.Windows.Forms.Label lblLevelStat;
        private System.Windows.Forms.Label lblLinesStat;
        private System.Windows.Forms.Label lblScoreStat;
    }
}