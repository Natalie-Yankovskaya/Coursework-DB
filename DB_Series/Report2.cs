using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;

namespace DB_Series
{
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Top5". При необходимости она может быть перемещена или удалена.
            this.top5TableAdapter.Fill(this.seriesDataSet.Top5);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Add(Visible: true);


            Range r = doc.Range(doc.Content.End - 1);

            r.Text = "Топ-5 сериалов  " + DateTime.Today.ToString("dd-MM-yyyy");
            //r.Bold = 1;
            r.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            r.Font.Size = 14;


            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT TOP(5) Title AS 'Название сериала', Genre AS 'Жанр', Country AS 'Страна', Rating AS 'Рейтинг' FROM Series ORDER BY Series.Rating DESC; ", con);


                    //comm.Parameters.AddWithValue("Studios Name", "Average rating of series");
                    int i = 0;
                    int j = 0;
                    using (SqlDataReader reader1 = comm.ExecuteReader())
                    {
                        i = reader1.FieldCount;
                        while (reader1.Read())
                        {
                            j++;
                        }
                    }

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {

                        r = doc.Range(doc.Content.End - 1);

                        Microsoft.Office.Interop.Word.Table t = doc.Tables.Add(r, j + 1, i);
                        t.Borders.Enable = 1;
                        int b = 2;
                        t.Cell(1, 1).Range.Text = "Название сериала";
                        t.Cell(1, 2).Range.Text = "Жанр";
                        t.Cell(1, 3).Range.Text = "Страна";
                        t.Cell(1, 4).Range.Text = "Рейтинг";
                        while (reader.Read())
                        {
                            for (int a = 1; a <= reader.FieldCount; a++)
                            {
                                t.Cell(b, a).Range.Text = reader.GetValue(a - 1).ToString();
                            }
                            b++;
                            r.Bold = 0;
                        }


                    }

                    doc.Save();
                    var fullName = doc.FullName;
                    doc.Close();
                    con.Close();
                    Spire.Doc.Document doc2 = new Spire.Doc.Document(fullName);
                    //doc2.Background.Type = BackgroundType.Gradient;
                    //BackgroundGradient Test = doc2.Background.Gradient;
                    //Test.Color1 = Color.White;
                    //Test.Color2 = Color.LightSteelBlue;
                    //Test.ShadingVariant = GradientShadingVariant.ShadingDown;
                    //Test.ShadingStyle = GradientShadingStyle.Horizontal;

                    doc2.SaveToFile(fullName, FileFormat.Docx);

                    app.Quit();
                }
                catch (Exception help)
                {
                    MessageBox.Show(help.Message);
                }
            }

        }

        private void top5DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
