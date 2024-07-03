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
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            правилаИгрыToolStripMenuItem = new ToolStripMenuItem();
            начатьСНачалаToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            результатыИгрыToolStripMenuItem = new ToolStripMenuItem();
            показатьРезультатыToolStripMenuItem = new ToolStripMenuItem();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, результатыИгрыToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.Size = new Size(731, 41);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { правилаИгрыToolStripMenuItem, начатьСНачалаToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(88, 35);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            правилаИгрыToolStripMenuItem.Size = new Size(343, 40);
            правилаИгрыToolStripMenuItem.Text = "Правила игры";
            правилаИгрыToolStripMenuItem.Click += правилаИгрыToolStripMenuItem_Click;
            // 
            // начатьСНачалаToolStripMenuItem
            // 
            начатьСНачалаToolStripMenuItem.Name = "начатьСНачалаToolStripMenuItem";
            начатьСНачалаToolStripMenuItem.Size = new Size(343, 40);
            начатьСНачалаToolStripMenuItem.Text = "Начать с начала";
            начатьСНачалаToolStripMenuItem.Click += начатьСНачалаToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(343, 40);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // результатыИгрыToolStripMenuItem
            // 
            результатыИгрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьРезультатыToolStripMenuItem });
            результатыИгрыToolStripMenuItem.Name = "результатыИгрыToolStripMenuItem";
            результатыИгрыToolStripMenuItem.Size = new Size(242, 35);
            результатыИгрыToolStripMenuItem.Text = "Результаты игры";
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            показатьРезультатыToolStripMenuItem.Size = new Size(399, 40);
            показатьРезультатыToolStripMenuItem.Text = "Показать результаты";
            показатьРезультатыToolStripMenuItem.Click += показатьРезультатыToolStripMenuItem_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = Color.RosyBrown;
            scoreLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(13, 41);
            scoreLabel.Margin = new Padding(4, 0, 4, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(177, 82);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Счет";
            scoreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.BackColor = Color.RosyBrown;
            bestScoreLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            bestScoreLabel.ForeColor = Color.White;
            bestScoreLabel.Location = new Point(210, 41);
            bestScoreLabel.Margin = new Padding(4, 0, 4, 0);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(250, 82);
            bestScoreLabel.TabIndex = 2;
            bestScoreLabel.Text = "Лучший счет";
            bestScoreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(731, 831);
            Controls.Add(bestScoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 4, 4, 4);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameForm";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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