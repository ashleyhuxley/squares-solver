using ElectricFox.SquaresSolver;
using System.Text;

namespace ElectricFox.SquaresHelper.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void findButton_Click(object sender, EventArgs e)
        {
            var letters = new char[4, 4];

            letters[0, 0] = character1.Text.ToLowerInvariant()[0];
            letters[0, 1] = character2.Text.ToLowerInvariant()[0];
            letters[0, 2] = character3.Text.ToLowerInvariant()[0];
            letters[0, 3] = character4.Text.ToLowerInvariant()[0];
            letters[1, 0] = character5.Text.ToLowerInvariant()[0];
            letters[1, 1] = character6.Text.ToLowerInvariant()[0];
            letters[1, 2] = character7.Text.ToLowerInvariant()[0];
            letters[1, 3] = character8.Text.ToLowerInvariant()[0];
            letters[2, 0] = character9.Text.ToLowerInvariant()[0];
            letters[2, 1] = character10.Text.ToLowerInvariant()[0];
            letters[2, 2] = character11.Text.ToLowerInvariant()[0];
            letters[2, 3] = character12.Text.ToLowerInvariant()[0];
            letters[3, 0] = character13.Text.ToLowerInvariant()[0];
            letters[3, 1] = character14.Text.ToLowerInvariant()[0];
            letters[3, 2] = character15.Text.ToLowerInvariant()[0];
            letters[3, 3] = character16.Text.ToLowerInvariant()[0];

            var solver = new Solver(letters);

            var sowpods = File.ReadAllLines("Z:\\Assets\\sowpods.txt");
            var words = new List<string>();
            foreach (var word in sowpods)
            {
                if (word.Length < 4 || word.Length > 16)
                {
                    continue;
                }

                if (solver.IsValidWord(word.ToLowerInvariant()))
                {
                    words.Add(word);
                }
            }

            wordList.Items.Clear();
            foreach (var item in words.OrderByDescending(w => w.Length).ThenBy(w => w))
            {
                wordList.Items.Add(item);
            }
        }

        private void CharacterTextChanged(object sender, EventArgs e)
        {
            SelectNextControl((TextBox)sender, true, true, false, true);
        }

        private void CharacterEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
