namespace Game2048WinFormsApp
{
    partial class GameRulesForm
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
            this.gameRulesLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameRulesLabel
            // 
            this.gameRulesLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameRulesLabel.Location = new System.Drawing.Point(12, 9);
            this.gameRulesLabel.Name = "gameRulesLabel";
            this.gameRulesLabel.Size = new System.Drawing.Size(514, 371);
            this.gameRulesLabel.TabIndex = 0;
            this.gameRulesLabel.Text = "Правила";
            this.gameRulesLabel.Click += new System.EventHandler(this.gameRulesLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.Location = new System.Drawing.Point(179, 414);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(156, 39);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GameRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 465);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.gameRulesLabel);
            this.Name = "GameRulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правила игры 2048";
            this.Load += new System.EventHandler(this.GameRulesFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label gameRulesLabel;
        private Button closeButton;
    }
}