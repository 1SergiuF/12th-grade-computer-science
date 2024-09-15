using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace eLearningMareaUnire1918
{
    public partial class eLearning1918_Elev : Form
    {
        private int itemiSize;
        private Random random;
        private List<int> items = new List<int>();
        private List<int> types = new List<int>();
        private int countItem = 0;
        private int punctaj = 1;

        private string ri1;
        private string ri2;
        private List<int> ri3 = new List<int>();
        private bool ri4;
        private int type;
        private bool check = false;
        private List<string> raportList = new List<string>();
        private int elevId;
        private string elevNumePrenume;
        public eLearning1918_Elev(int id, string numePrenume)
        {
            InitializeComponent();
            elevId = id;
            elevNumePrenume = numePrenume;
            lblNumePrenume.Text += elevNumePrenume;
            itemiSize = GetCountUtilizatoriTable();
            random = new Random();
            GenerateRandomItems();
        }

        private List<int> GenerateRandomItems()
        {
            items.Clear();
            types.Clear();
            bool ok = false;

            while (!ok)
            {
                for (int i = 0; i < 9; ++i)
                {
                    int r = random.Next(1, itemiSize);
                    if (items.Find(it => it == r) != 0)
                        i--;
                    else
                    {
                        items.Add(r);
                        types.Add(GetTipItem(r));
                    }
                }

                ok = true;
                for (int t = 1; t <= 4; ++t)
                    if (types.FirstOrDefault(tip => tip == t) == 0)
                    {
                        ok = false;
                        items.Clear();
                        types.Clear();
                        break;
                    }
            }
            return items;
        }

        private int GetCountUtilizatoriTable()
        {
            int count = 0;
            using (var conn = new SqlConnection(InregistrareForm.connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(IdItem) FROM Itemi";

                using (var cmd = new SqlCommand(query, conn))
                {
                    var sc = cmd.ExecuteScalar();
                    count = (int)sc;
                }
            }

            return count;
        }

        private int GetTipItem(int id)
        {
            int tip = 0;

            using (var conn = new SqlConnection(InregistrareForm.connStr))
            {
                conn.Open();
                string query = "SELECT TipItem FROM Itemi WHERE IdItem = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    var sc = cmd.ExecuteScalar();
                    tip = (int)sc;
                }
            }

            return tip;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            var answers = GetAnswers(items[0]);
            rtbEnunt.Text = answers[5];
            btnRaspuns.Visible = true;
            if (types[0] == 1)
            {
                type = 1;
                Label raspunsLabel = new Label()
                {
                    Text = "Raspuns",
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 10)
                };

                raspunsTb.Visible = true;

                raspunsTb.TextChanged += HandleTextChanged;
                panelTest.Controls.Add(raspunsLabel);
            }

            else if (types[0] == 2)
            {
                type = 2;
                List<string> ans = GetAnswers(items[0]);
                for (int i = 1; i <= 4; ++i)
                {
                    var rb = new RadioButton()
                    {
                        Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25 * i),
                        Text = ans[i - 1],
                        Name = i.ToString(),
                        AutoSize = true
                    };

                    rb.Click += HandleRbClick;

                    panelTest.Controls.Add(rb);
                }
            }

            else if (types[0] == 3)
            {
                type = 3;
                List<string> ans = GetAnswers(items[0]);
                for (int i = 1; i <= 4; ++i)
                {
                    var checkBox = new CheckBox()
                    {
                        Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25 * i),
                        AutoSize = false,
                        Width = rtbEnunt.Width,
                        Text = ans[i - 1],
                        Name = i.ToString()
                    };

                    checkBox.Click += HandleCheckBoxClick;
                    panelTest.Controls.Add(checkBox);
                }
            }

            else if (types[0] == 4)
            {
                type = 4;
                var rbTrue = new RadioButton()
                {
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25),
                    Text = "adevarat"
                };

                var rbFalse = new RadioButton()
                {
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 50),
                    Text = "fals"
                };

                rbTrue.Click += HandleRbTrueClick;
                rbFalse.Click += HandleRbFalseClick;
                panelTest.Controls.Add(rbTrue);
                panelTest.Controls.Add(rbFalse);
            }

            ++countItem;
            lblItem.Text += $"{countItem}";
            lblItem.Visible = true;
            btnStartTest.Enabled = false;
            btnUrmatorul.Visible = true;
        }

        private void HandleRbFalseClick(object sender, EventArgs e)
        {
            ri4 = false;
            check = true;
        }

        private void HandleRbTrueClick(object sender, EventArgs e)
        {
            ri4 = true;
            check = true;
        }

        private void HandleCheckBoxClick(object sender, EventArgs e)
        {
            CheckBox checkBoxSender = (CheckBox)sender;
            ri3.Add(Int32.Parse(checkBoxSender.Name));
        }

        private void HandleRbClick(object sender, EventArgs e)
        {
            RadioButton rbSender = (RadioButton)sender;
            ri2 = rbSender.Name.ToString();
        }

        private void HandleTextChanged(object sender, EventArgs e)
        {
            TextBox senderTb = (TextBox) sender;
            ri1 = senderTb.Text;
        }

        private List<string> GetAnswers(int id)
        {
            List< string> ans = new List< string>();

            using (var conn = new SqlConnection(InregistrareForm.connStr))
            {
                conn.Open();
                string query = "SELECT Raspuns1Item, Raspuns2Item, Raspuns3Item, " +
                    "Raspuns4Item, RaspunsCorectItem, EnuntItem FROM Itemi WHERE IdItem = " +
                    "@id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var rd = cmd.ExecuteReader())
                    {
                        rd.Read();

                        ans.Add(rd[0].ToString());
                        ans.Add(rd[1].ToString());
                        ans.Add(rd[2].ToString());
                        ans.Add(rd[3].ToString());
                        ans.Add(rd[4].ToString());
                        ans.Add(rd[5].ToString());
                    }
                }
            }

            return ans;
        }

        private void btnRaspuns_Click(object sender, EventArgs e)
        {
            try
            {
                var answers = GetAnswers(items[countItem - 1]);

                if (type == 1)
                {
                    if (ri1 == null)
                    {
                        btnRaspuns.Enabled = false;
                        raportList.Add("null");
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                        if (countItem == items.Count)
                        {
                            InsertEvaluare(elevId, DateTime.Now, punctaj);
                            btnUrmatorul.Enabled = false;
                            btnRaspuns.Enabled = false;
                            lblItem.Text = $"Item nr.{countItem}";
                            string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                            for (int i = 0; i < items.Count; ++i)
                            {
                                var list = GetAnswers(items[i]);
                                raport += $"{i + 1}  {types[i]}  {list[5]}  {raportList[i]}  {list[4]}\n";
                            }
                            MessageBox.Show(raport);
                        }
                        return;
                    }

                    raportList.Add(ri1);
                    string correct = answers[4].ToString().ToLower().Replace(" ", "");
                    string ans = ri1.ToString().ToLower().Replace(" ", "");

                    if (correct != ans)
                    {
                        btnRaspuns.Enabled = false;
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                        raspunsTb.Clear();
                        if (countItem == items.Count)
                        {
                            InsertEvaluare(elevId, DateTime.Now, punctaj);
                            btnUrmatorul.Enabled = false;
                            btnRaspuns.Enabled = false;
                            lblItem.Text = $"Item nr.{countItem}";
                            string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                            for (int i = 0; i < items.Count; ++i)
                            {
                                var list = GetAnswers(items[i]);
                                raport += $"{i + 1}  {types[i]}  {list[5]}  {raportList[i]}  {list[4]}\n";
                            }
                            MessageBox.Show(raport);
                        }
                        return;
                    }
                    btnRaspuns.Enabled = false;
                    MessageBox.Show("Raspuns corect !");
                    lblPunctaj.Text = $"Punctaj={++punctaj}";
                }

                else if (type == 2)
                {
                    if (ri2 != answers[4])
                    {
                        btnRaspuns.Enabled = false;
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                        raspunsTb.Clear();
                        if (countItem == items.Count)
                        {
                            InsertEvaluare(elevId, DateTime.Now, punctaj);
                            btnUrmatorul.Enabled = false;
                            btnRaspuns.Enabled = false;
                            lblItem.Text = $"Item nr.{countItem}";
                            string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                            for (int i = 0; i < items.Count; ++i)
                            {
                                var list = GetAnswers(items[i]);
                                raport += $"{i + 1}  {types[i]}  {list[5]}  {raportList[i]}  {list[4]}\n";
                            }
                            MessageBox.Show(raport);
                        }

                        raportList.Add(ri2);
                        return;
                    }

                    btnRaspuns.Enabled = false;
                    raportList.Add(ri2);
                    MessageBox.Show("Raspuns corect !");
                    lblPunctaj.Text = $"Punctaj={++punctaj}";
                }

                else if (type == 3)
                {
                    string a = "";
                    int ans = Int32.Parse(answers[4].ToString());
                    List<int> digits = new List<int>();

                    while (ans != 0)
                    {
                        digits.Add(ans % 10);
                        ans /= 10;
                    }

                    if (digits.Count != ri3.Count)
                    {
                        btnRaspuns.Enabled = false;
                        ri3.ForEach((i) => a += i);
                        raportList.Add(a);
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                        raspunsTb.Clear();
                        if (countItem == items.Count)
                        {
                            InsertEvaluare(elevId, DateTime.Now, punctaj);
                            btnUrmatorul.Enabled = false;
                            btnRaspuns.Enabled = false;
                            lblItem.Text = $"Item nr.{countItem}";
                            string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                            for (int i = 0; i < items.Count; ++i)
                            {
                                var list = GetAnswers(items[i]);
                                raport += $"{i + 1}  {types[i]}  {list[5]}  {raportList[i]}  {list[4]}\n";
                            }
                            MessageBox.Show(raport);
                        }
                        return;
                    }
                    digits.Sort();
                    ri3.Sort();

                    for (int i = 0; i < digits.Count; ++i)
                        if (digits[i] != ri3[i])
                        {
                            btnRaspuns.Enabled = false;
                            ri3.ForEach((elem) => a += elem);
                            raportList.Add(a);
                            MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                            raspunsTb.Clear();
                            if (countItem == items.Count)
                            {
                                InsertEvaluare(elevId, DateTime.Now, punctaj);
                                btnUrmatorul.Enabled = false;
                                btnRaspuns.Enabled = false;
                                lblItem.Text = $"Item nr.{countItem}";
                                string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                                for (int j = 0; j < items.Count; ++j)
                                {
                                    var list = GetAnswers(items[j]);
                                    raport += $"{j + 1}  {types[j]}  {list[5]}  {raportList[j]}  {list[4]}\n";
                                }
                                MessageBox.Show(raport);
                            }
                            return;
                        }

                    btnRaspuns.Enabled = false;
                    ri3.ForEach((i) => a += i);
                    raportList.Add(a);

                    MessageBox.Show("Raspuns corect !");
                    lblPunctaj.Text = $"Punctaj={++punctaj}";
                }

                else if (type == 4)
                {
                    if (check == false)
                    {
                        raportList.Add("null");
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                    }
                    else if ((ri4 == true && answers[4].ToString() == "0") || (ri4 == false && answers[4].ToString() == "1"))
                    {
                        raportList.Add(ri4 == true ? "true" : "false");
                        MessageBox.Show($"Raspuns incorect! Raspunsul corect era: {answers[4]}");
                    }
                    else
                    {
                        raportList.Add(ri4 == true ? "true" : "false");
                        MessageBox.Show("Raspuns corect !");
                        lblPunctaj.Text = $"Punctaj={++punctaj}";
                    }
                }

                raspunsTb.Clear();
                btnRaspuns.Enabled = false;

                if (countItem == items.Count)
                {
                    InsertEvaluare(elevId, DateTime.Now, punctaj);
                    btnUrmatorul.Enabled = false;
                    btnRaspuns.Enabled = false;
                    lblItem.Text = $"Item nr.{countItem}";
                    string raport = "NrOrd  Tip  Enunt  RaspunsElev  RaspunsCorect\n";

                    for (int i = 0; i < items.Count; ++i)
                    {
                        var list = GetAnswers(items[i]);

                        raport += $"{i + 1}  {types[i]}  {list[5]}  {raportList[i]}  {list[4]}\n";
                    }
                    MessageBox.Show(raport);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void btnUrmatorul_Click(object sender, EventArgs e)
        {
            btnRaspuns.Enabled = true;
            panelTest.Controls.Clear();
            panelTest.Controls.Add(lblItem);
            panelTest.Controls.Add(rtbEnunt);
            panelTest.Controls.Add(btnRaspuns);
            panelTest.Controls.Add(btnUrmatorul);
            panelTest.Controls.Add(raspunsTb);
            var answers = GetAnswers(items[countItem]);
            rtbEnunt.Text = answers[5];
            btnRaspuns.Visible = true;

            if (countItem == items.Count - 1)
                btnUrmatorul.Enabled = false;
            if (types[countItem] == 1)
            {
                type = 1;
                Label raspunsLabel = new Label()
                {
                    Text = "Raspuns",
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 10)
                };

                raspunsTb.Visible = true;

                raspunsTb.TextChanged += HandleTextChanged;
                panelTest.Controls.Add(raspunsLabel);
            }

            else if (types[countItem] == 2)
            {
                raspunsTb.Visible = false;
                type = 2;
                List<string> ans = GetAnswers(items[countItem]);
                for (int i = 1; i <= 4; ++i)
                {
                    var rb = new RadioButton()
                    {
                        Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25 * i),
                        Text = ans[i - 1],
                        Name = i.ToString(),
                        AutoSize = true
                    };

                    rb.Click += HandleRbClick;

                    panelTest.Controls.Add(rb);
                }
            }


            else if (types[countItem] == 3)
            {
                raspunsTb.Visible = false;
                type = 3;
                List<string> ans = GetAnswers(items[countItem]);
                rtbEnunt.Text = ans[5];
                for (int i = 1; i <= 4; ++i)
                {
                    var checkBox = new CheckBox()
                    {
                        Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25 * i),
                        AutoSize = false,
                        Width = rtbEnunt.Width,
                        Text = ans[i - 1],
                        Name = i.ToString()
                    };

                    checkBox.Click += HandleCheckBoxClick;
                    panelTest.Controls.Add(checkBox);
                }
            }

            else if (types[countItem] == 4)
            {
                raspunsTb.Visible = false;
                type = 4;
                var rbTrue = new RadioButton()
                {
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 25),
                    Text = "adevarat"
                };

                var rbFalse = new RadioButton()
                {
                    Location = new Point(rtbEnunt.Location.X, rtbEnunt.Location.Y + rtbEnunt.Height + 50),
                    Text = "fals"
                };

                rbTrue.Click += HandleRbTrueClick;
                rbFalse.Click += HandleRbFalseClick;
                panelTest.Controls.Add(rbTrue);
                panelTest.Controls.Add(rbFalse);
            }

            ++countItem;
            lblItem.Text = $"Item nr.{countItem}";
        }

        private void InsertEvaluare(int idElev, DateTime dataEvaluare, int notaEvaluare)
        {
            using (var conn = new SqlConnection(InregistrareForm.connStr))
            {
                conn.Open();
                string query = "INSERT INTO Evaluari VALUES(@idElev, @dataEvaluare, @notaEvaluare)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idElev", idElev);
                    cmd.Parameters.AddWithValue("@dataEvaluare", dataEvaluare);
                    cmd.Parameters.AddWithValue("@notaEvaluare", notaEvaluare);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void GetEvaluari(int idElev)
        {
            using (var conn = new SqlConnection(InregistrareForm.connStr))
            {
                conn.Open();
                string query = "SELECT DataEvaluare, NotaEvaluare FROM Evaluari " +
                    "WHERE IdElev = @idElev";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idElev", idElev);

                    using (var rd = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        dgvCarnet.DataSource = dt;
                    }
                }
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }

        private void tabcMeniu_Selected(object sender, TabControlEventArgs e)
        {
            GetEvaluari(elevId);
        }

        private void eLearning1918_Elev_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eLearning1918DataSet.Evaluari' table. You can move, or remove it, as needed.
            this.evaluariTableAdapter.Fill(this.eLearning1918DataSet.Evaluari);

        }
    }
}
