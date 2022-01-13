
namespace TopSektirme_Proje5
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.leftStick = new System.Windows.Forms.PictureBox();
            this.rightStick = new System.Windows.Forms.PictureBox();
            this.left_topStick = new System.Windows.Forms.PictureBox();
            this.right_topStick = new System.Windows.Forms.PictureBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.scorelbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.recordedTimer = new System.Windows.Forms.Timer(this.components);
            this.backupBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.racket = new TopSektirme_Proje5.Racket();
            ((System.ComponentModel.ISupportInitialize)(this.leftStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_topStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_topStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // leftStick
            // 
            this.leftStick.BackColor = System.Drawing.Color.RosyBrown;
            this.leftStick.Location = new System.Drawing.Point(22, 12);
            this.leftStick.Name = "leftStick";
            this.leftStick.Size = new System.Drawing.Size(18, 374);
            this.leftStick.TabIndex = 3;
            this.leftStick.TabStop = false;
            // 
            // rightStick
            // 
            this.rightStick.BackColor = System.Drawing.Color.RosyBrown;
            this.rightStick.Location = new System.Drawing.Point(760, 12);
            this.rightStick.Name = "rightStick";
            this.rightStick.Size = new System.Drawing.Size(18, 374);
            this.rightStick.TabIndex = 4;
            this.rightStick.TabStop = false;
            // 
            // left_topStick
            // 
            this.left_topStick.BackColor = System.Drawing.Color.RosyBrown;
            this.left_topStick.Location = new System.Drawing.Point(36, 12);
            this.left_topStick.Name = "left_topStick";
            this.left_topStick.Size = new System.Drawing.Size(225, 22);
            this.left_topStick.TabIndex = 5;
            this.left_topStick.TabStop = false;
            // 
            // right_topStick
            // 
            this.right_topStick.BackColor = System.Drawing.Color.RosyBrown;
            this.right_topStick.Location = new System.Drawing.Point(539, 12);
            this.right_topStick.Name = "right_topStick";
            this.right_topStick.Size = new System.Drawing.Size(225, 22);
            this.right_topStick.TabIndex = 6;
            this.right_topStick.TabStop = false;
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.pauseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pauseBtn.FlatAppearance.BorderSize = 2;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pauseBtn.ForeColor = System.Drawing.Color.Black;
            this.pauseBtn.Location = new System.Drawing.Point(689, 415);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 31);
            this.pauseBtn.TabIndex = 10;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Black;
            this.scorelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scorelbl.Location = new System.Drawing.Point(670, 12);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Padding = new System.Windows.Forms.Padding(1);
            this.scorelbl.Size = new System.Drawing.Size(73, 21);
            this.scorelbl.TabIndex = 11;
            this.scorelbl.Text = "Score: 0";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playBtn.FlatAppearance.BorderSize = 2;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playBtn.ForeColor = System.Drawing.Color.Black;
            this.playBtn.Location = new System.Drawing.Point(608, 415);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 31);
            this.playBtn.TabIndex = 12;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.onGameTimer2Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.OnMoverTimer3Tick);
            // 
            // recordedTimer
            // 
            this.recordedTimer.Interval = 120000;
            this.recordedTimer.Tick += new System.EventHandler(this.recordGameInfo);
            // 
            // backupBtn
            // 
            this.backupBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backupBtn.FlatAppearance.BorderSize = 2;
            this.backupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backupBtn.ForeColor = System.Drawing.Color.White;
            this.backupBtn.Location = new System.Drawing.Point(36, 415);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(75, 31);
            this.backupBtn.TabIndex = 17;
            this.backupBtn.Text = "BackUp";
            this.backupBtn.UseVisualStyleBackColor = false;
            this.backupBtn.Click += new System.EventHandler(this.autoBackup);
            // 
            // restoreBtn
            // 
            this.restoreBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.restoreBtn.FlatAppearance.BorderSize = 2;
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restoreBtn.ForeColor = System.Drawing.Color.White;
            this.restoreBtn.Location = new System.Drawing.Point(117, 415);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(79, 31);
            this.restoreBtn.TabIndex = 18;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = false;
            this.restoreBtn.Click += new System.EventHandler(this.autoRestore);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.SaddleBrown;
            this.racket.Location = new System.Drawing.Point(281, 366);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 16;
            this.racket.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.right_topStick);
            this.Controls.Add(this.left_topStick);
            this.Controls.Add(this.rightStick);
            this.Controls.Add(this.leftStick);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.leftStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_topStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_topStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox leftStick;
        private System.Windows.Forms.PictureBox rightStick;
        private System.Windows.Forms.PictureBox left_topStick;
        private System.Windows.Forms.PictureBox right_topStick;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Racket racket;
        private System.Windows.Forms.Timer recordedTimer;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button restoreBtn;
    }
}

