namespace Game2048WinFormsApp
{
    partial class StartForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.rulesbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.sizeMapLabel = new System.Windows.Forms.Label();
            this.mapSizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.RosyBrown;
            this.startButton.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(151, 263);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 56);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rulesbutton
            // 
            this.rulesbutton.BackColor = System.Drawing.Color.RosyBrown;
            this.rulesbutton.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rulesbutton.ForeColor = System.Drawing.Color.White;
            this.rulesbutton.Location = new System.Drawing.Point(151, 339);
            this.rulesbutton.Name = "rulesbutton";
            this.rulesbutton.Size = new System.Drawing.Size(177, 56);
            this.rulesbutton.TabIndex = 1;
            this.rulesbutton.Text = "Правила игры";
            this.rulesbutton.UseVisualStyleBackColor = false;
            this.rulesbutton.Click += new System.EventHandler(this.rulesbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(151, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.Location = new System.Drawing.Point(121, 68);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(232, 40);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(61, 37);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(363, 28);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Для начала игры введите ваше имя";
            // 
            // sizeMapLabel
            // 
            this.sizeMapLabel.AutoSize = true;
            this.sizeMapLabel.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeMapLabel.Location = new System.Drawing.Point(52, 148);
            this.sizeMapLabel.Name = "sizeMapLabel";
            this.sizeMapLabel.Size = new System.Drawing.Size(357, 28);
            this.sizeMapLabel.TabIndex = 5;
            this.sizeMapLabel.Text = "Введите размер поля игры: от  до ";
            this.sizeMapLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mapSizeTextBox
            // 
            this.mapSizeTextBox.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapSizeTextBox.Location = new System.Drawing.Point(151, 179);
            this.mapSizeTextBox.Name = "mapSizeTextBox";
            this.mapSizeTextBox.Size = new System.Drawing.Size(177, 40);
            this.mapSizeTextBox.TabIndex = 6;
            this.mapSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mapSizeTextBox.TextChanged += new System.EventHandler(this.mapSizeTextBox_TextChanged);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 499);
            this.Controls.Add(this.mapSizeTextBox);
            this.Controls.Add(this.sizeMapLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rulesbutton);
            this.Controls.Add(this.startButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private Button rulesbutton;
        private Button exitButton;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label sizeMapLabel;
        private TextBox mapSizeTextBox;
    }
}