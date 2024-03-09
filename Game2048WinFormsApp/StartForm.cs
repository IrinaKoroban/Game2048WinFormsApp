
using Game2048.Common;

namespace Game2048WinFormsApp
{
    public partial class StartForm : Form
    {
        private int mapSize;
        private int minMapSize = 3;
        private int maxMapSize = 9;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            sizeMapLabel.Text = $"Введите размер поля игры: от {minMapSize} до {maxMapSize}";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (mapSize < minMapSize || mapSize > maxMapSize)
            {
                MessageBox.Show("Вы ввели не тот размер поля");
                return;
            }

            var gameForm = new GameForm(userNameTextBox.Text, mapSize);
            gameForm.Show();
        }

        private void rulesbutton_Click(object sender, EventArgs e)
        {
            var rulesForm = new GameRulesForm();
            rulesForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            startButton.Enabled = userNameTextBox.Text.Length >= 2;
        }

        private void mapSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ImputValidavor.TryGetNumber(mapSizeTextBox.Text, out int number, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                mapSize = number;
            }
        }
    }
}
