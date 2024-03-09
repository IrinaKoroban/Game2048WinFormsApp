using Game2048.Common;
using System.Drawing.Imaging;


namespace Game2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private Label[,] labelsMap;
        private string userName;
        User user;

        private int mapSize;
        private int labelSize = 80;
        private int startX = 25;
        private int startY = 130;
        private int gapBetweenCells = 8;
        private int backLabelShift = 10;
        private int score = 0;
        private int bestScore = 0;

        private bool availableLeftRightMove = true;
        private bool availableUpDownMove = true;

        private static Random random = new Random();

        public GameForm(string text, int number)
        {
            InitializeComponent();
            userName = text;
            mapSize = number;

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            user = new User(userName);
            InitMap();
            GenerateNumber();
            ShowScore();
            ShowBestScore();
        }
        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CleateCellLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
            var backLabel = CleateBackLabel();
            Controls.Add(backLabel);
        }

        private void GenerateNumber()
        {
            while (true)
            {
                var indexRaw = random.Next(mapSize);
                var indexColumn = random.Next(mapSize);

                int number;
                var percentageDropNumber = random.Next(100);
                if (percentageDropNumber < 75)
                    number = 2;
                else
                    number = 4;

                for (int i = indexRaw; i < mapSize; i++)
                {
                    for (int j = indexColumn; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            labelsMap[i, j].Text = number.ToString();
                            return;
                        }
                    }
                }
            }
        }
        private Label CleateCellLabel(int indexRow, int indexColumn)
        {
            var cellLabel = new Label();

            cellLabel.BackColor = Color.SandyBrown;
            cellLabel.Font = new Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cellLabel.Name = "tileLabel";
            cellLabel.Size = new Size(labelSize, labelSize);
            cellLabel.TabIndex = 1;
            cellLabel.TextAlign = ContentAlignment.MiddleCenter;

            int x = startX + indexColumn * (labelSize + gapBetweenCells);
            int y = startY + indexRow * (labelSize + gapBetweenCells);
            cellLabel.Location = new Point(x, y);

            cellLabel.TextChanged += CellLabel_TextChanged;

            return cellLabel;
        }

        private void CellLabel_TextChanged(object? sender, EventArgs e)
        {
            var cellLabel = (Label)sender;

            if (cellLabel.Text != string.Empty)
            {
                var colorSaturationCoefficient = 0;
                var cellNumber = int.Parse(cellLabel.Text);
                do
                {
                    cellNumber = cellNumber / 2;
                    colorSaturationCoefficient++;

                    if (colorSaturationCoefficient > 10)
                        break;
                }
                while (cellNumber > 1);

                cellLabel.BackColor = Color.FromArgb(colorSaturationCoefficient * 20, 
                    250, colorSaturationCoefficient * 2, colorSaturationCoefficient * 2);
            }
            else
            {
                cellLabel.BackColor = Color.SandyBrown;
            }

        }

        private Label CleateBackLabel()
        {
            var backLabel = new Label();
            var backlabelSize = (labelSize + gapBetweenCells) * mapSize - gapBetweenCells + backLabelShift * 2;
            backLabel.BackColor = Color.RosyBrown;
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(backlabelSize, backlabelSize);
            backLabel.TabIndex = 1;
            backLabel.TextAlign = ContentAlignment.MiddleCenter;

            int x = startX - backLabelShift;
            int y = startY - backLabelShift;
            backLabel.Location = new Point(x, y);
            return backLabel;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ExistNextMove())
            {
                if (availableLeftRightMove)
                {
                    if (e.KeyCode == Keys.Right)
                    {
                        MoveCellsRight();
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        MoveCellsLeft();
                    }
                }
                if (availableUpDownMove)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        MoveCellsUp();
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        MoveCellsDown();
                    }
                }

                if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                {
                    MessageBox.Show("Нажимайте стрелки для управления полем.");
                    return;
                }
                ShowScore();
                ShowBestScore();

                if (ExistEmptyCell())
                {
                    GenerateNumber();
                }
            }
            else
            {
                SaveUserResult();
                ShowUserResult();
            }
        }
        private void ShowUserResult()
        {
            if (bestScore > score)
            {
                MessageBox.Show($"Ваш счет: {score}");
            }
            else
            {
                MessageBox.Show($"Поздравляем {user.Name}, у вас лучший результат: {user.Score}");
            }
        }
        private void SaveUserResult()
        {
            user.AddScore(score);
            UsersResultStorage.Append(user);
        }
        private void MoveCellsDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {

                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveCellsUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveCellsLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveCellsRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    score += number * 2;
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public bool ExistEmptyCell()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if ((labelsMap[i, j]).Text == string.Empty)
                        return true;
                }
            }
            return false;
        }
        public bool ExistNextMove()
        {
            if (ExistEmptyCell())
            {
                return true;
            }
            else
            {
                for (int i = 0; i < mapSize - 1; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if ((labelsMap[i, j]).Text == (labelsMap[i + 1, j]).Text)
                        {
                            availableUpDownMove = true;
                            return true;
                        }
                    }
                }
                availableUpDownMove = false;

                for (int j = 0; j < mapSize - 1; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if ((labelsMap[i, j]).Text == (labelsMap[i, j + 1]).Text)
                        {
                            availableLeftRightMove = true;
                            return true;
                        }
                    }
                }
                availableLeftRightMove = false;
            }
            return false;
        }
        private void ShowScore()
        {
            scoreLabel.Text = $"Счёт\n{score}";
        }
        private void ShowBestScore()
        {
            bestScore = UsersResultStorage.GetBestResult();
            if (bestScore >= score)
            {
                bestScoreLabel.Text = $"Лучший счёт\n{bestScore}";
            }
            else
            {
                bestScoreLabel.Text = $"Лучший счёт\n{score}";
            }
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameRulesForm= new GameRulesForm();
            gameRulesForm.Show();
        }

        private void начатьСНачалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm();
            userResultsForm.Show();
        }
    }
}