using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HangmanDB
{
    public partial class HangmanForm : Form
    {
        private int n = 3, m = 9;
        private string resPath = $@"{Directory.GetCurrentDirectory()}\..\..\ImagesHangman\";
        private int cnt;
        private int L;
        private Label[] wordLetters;
        private List<string> words = new List<string>();
        private Button[,] letters;
        private TableLayoutPanel wordTbl;
        private TableLayoutPanel tbl;
        private Random random = new Random();
        public static int punctaj;
        private int g;
        private int counter;
        private string fileName;
        public HangmanForm()
        {
            InitializeComponent();
            pbHangman.ImageLocation = resPath + "1.png";
            GetWords();
            string word = CreateLabelArray();

            CreateButtonGrid(word);
        }

        private string CreateLabelArray()
        {
            string word = GetRandomWord();
            wordLetters = new Label[word.Length];
            wordTbl = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = word.Length
            };

            int wH = panelWord.Height;
            int wW = panelWord.Width;
            L = Math.Min(wH, wW) / word.Length;

            for (int i = 0; i < word.Length; i++)
            {
                wordTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, L));
                wordLetters[i] = new Label()
                {
                    Text = "_",
                    ForeColor = Color.Black,
                    Margin = new Padding(1),
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
                };

                wordTbl.Controls.Add(wordLetters[i]);
            }

            panelWord.Controls.Add(wordTbl);
            return word;
        }

        private void GetWords()
        {
            StreamReader sr = new StreamReader($@"{Directory.GetCurrentDirectory()}\..\..\Resources\Words.txt");
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                words.Add(line);
            }
        }

        private string GetRandomWord()
        {
            int rand_poz = random.Next(0, words.Count);
            return words[rand_poz];
        }

        private void CreateButtonGrid(string word)
        {
            letters = new Button[n, m];
            tbl = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = n,
                ColumnCount = m,
            };

            int H = panelAlfabet.Height;
            int W = panelAlfabet.Width;
            L = Math.Min(H, W) / Math.Max(m, n);
            for (int j = 0; j < m; j++)
                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, L));

            for (int i = 0; i < n; i++)
            {
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, L));
                for (int j = 0; j < m; j++)
                {
                    ++cnt;
                    int ascii = 96 + cnt;
                    char c = (char)ascii;
                    string str = c.ToString();
                    letters[i, j] = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(1),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.DarkCyan,
                        ForeColor = Color.Khaki,
                        Font = new Font("Monospace", 20),
                        Text = str
                    };

                    tbl.Controls.Add(letters[i, j]);

                    letters[i, j].Click += async (sender, e) =>
                    {
                        Button btn = (Button)sender;
                        List<int> indexes = new List<int>();

                        if (!word.Contains(btn.Text)) ++g;

                        for (int k = 0; k < word.Length; k++)
                        {
                            if (word[k].ToString() ==  btn.Text)
                            {
                                indexes.Add(k);
                                ++counter;
                            }
                        }

                        if (indexes.Count == 0)
                        {
                            fileName = Path.GetFileName(pbHangman.ImageLocation);
                            if (fileName != "7.png")
                            {
                                int nextImage = (int)Char.GetNumericValue(fileName[0]) + 1;
                                Repaint(nextImage);

                                if (nextImage == 7)
                                {
                                    lblPunctaj.Text = $"Punctaj: {punctaj}";
                                    DisableLetterButtons();
                                    await Task.Delay(2000);
                                    this.Dispose();
                                }
                            }
                        }

                        if (indexes.Count > 0)
                        {
                            foreach (int index in indexes)
                                wordLetters[index].Text = btn.Text;

                            if (counter == word.Length)
                            {
                                punctaj = 100 - (15 * g);
                                lblPunctaj.Text = $"Punctaj: {punctaj}";
                                DisableLetterButtons();
                                await Task.Delay(2000);
                                this.Dispose();
                            }
                        }

                        tbl.Controls.Remove(btn);
                    };
                }
            }

            panelAlfabet.Controls.Add(tbl);
            tbl.Controls.Remove(letters[n - 1, m - 1]);
        }

        private void DisableLetterButtons()
        {
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    letters[i, j].Enabled = false;
        }

        private void Repaint(int image)
        {
            pbHangman.Image = Image.FromFile(resPath + $"{image}.png");
            pbHangman.ImageLocation = resPath + $"{image}.png";
            pbHangman.Invalidate();
            pbHangman.Update();
        }

        public static void UpdateScore(string userName, int highScore)
        {
            var conn = new SqlConnection(LoginForm.connStr);
            conn.Open();
            string query = "UPDATE Player SET Highscore = @highScore WHERE Username = @userName";

            var cmd = new SqlCommand(query, conn);  
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@highScore", highScore);

            cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }
    }
}
