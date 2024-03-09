using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048WinFormsApp
{
    public partial class GameRulesForm : Form
    {
        public GameRulesForm()
        {
            InitializeComponent();
        }

        private void GameRulesFormcs_Load(object sender, EventArgs e)
        {
            gameRulesLabel.Text = "Правила игры: " +
                "\n1.Используй стрелки чтобы сбросить все плитки игрового поля в одну из 4 сторон." +
                "\n2. Если при сбрасывании две плитки одного номинала «налетают» одна на другую," +
                " то они складываются, а очки увеличиваются на эту сумму." +
                "\n3. Игра заканчивается, когда всё поле заполнено и ходов не осталось.";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameRulesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
