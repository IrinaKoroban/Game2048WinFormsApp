namespace Game2048WinFormsApp
{
    partial class GameForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьСНачалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.результатыИгрыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(394, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.начатьСНачалаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // начатьСНачалаToolStripMenuItem
            // 
            this.начатьСНачалаToolStripMenuItem.Name = "начатьСНачалаToolStripMenuItem";
            this.начатьСНачалаToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.начатьСНачалаToolStripMenuItem.Text = "Начать с начала";
            this.начатьСНачалаToolStripMenuItem.Click += new System.EventHandler(this.начатьСНачалаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // результатыИгрыToolStripMenuItem
            // 
            this.результатыИгрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьРезультатыToolStripMenuItem});
            this.результатыИгрыToolStripMenuItem.Name = "результатыИгрыToolStripMenuItem";
            this.результатыИгрыToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.результатыИгрыToolStripMenuItem.Text = "Результаты игры";
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            this.показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            this.показатьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.показатьРезультатыToolStripMenuItem.Text = "Показать результаты";
            this.показатьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.показатьРезультатыToolStripMenuItem_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(15, 56);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(118, 55);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Счет";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.BackColor = System.Drawing.Color.RosyBrown;
            this.bestScoreLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bestScoreLabel.ForeColor = System.Drawing.Color.White;
            this.bestScoreLabel.Location = new System.Drawing.Point(158, 56);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(167, 55);
            this.bestScoreLabel.TabIndex = 2;
            this.bestScoreLabel.Text = "Лучший счет";
            this.bestScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(394, 491);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private ToolStripMenuItem начатьСНачалаToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem результатыИгрыToolStripMenuItem;
        private ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private Label scoreLabel;
        private Label bestScoreLabel;
    }
}