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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Average". При необходимости она может быть перемещена или удалена.
            this.averageTableAdapter.Fill(this.seriesDataSet.Average);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "seriesDataSet.Average". При необходимости она может быть перемещена или удалена.
            this.averageTableAdapter.Fill(this.seriesDataSet.Average);

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";
            string Title = "\t" + "\t" + "\t" + "Средний рейтинг сериалов в студии";
            stOutput += Title + "\r\n" + "\r\n" + "\r\n";
            string date = DateTime.Now.ToString("dd MM yyyy | HH:mm:ss");
           
            //for (int j = 0; j < averageDataGridView.Columns.Count; j++)
            //    sHeaders = sHeaders.ToString() + "\t"  + Convert.ToString(averageDataGridView.Columns[j].HeaderText) + "\t";
            
            // Export data.
            sHeaders = sHeaders.ToString() + "\t" + "\t" +  "Студия" + "\t" + "\t" + "\t" + "\t" + "Средний рейтинг сериалов";
            stOutput += sHeaders + "\r\n" + "\r\n" + "\r\n";
            for (int i = 0; i < averageDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < averageDataGridView.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + "\t" + "\t" + Convert.ToString(averageDataGridView.Rows[i].Cells[j].Value);
                    

                }
                stOutput += stLine + "\r\n" + "\r\n";
               
            }

            for (int i = 0; i < averageDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < averageDataGridView.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + "\t" + "\t" + Convert.ToString(averageDataGridView.Rows[i].Cells[j].Value);


                }
                stOutput += stLine + "\r\n" + "\r\n";

            }
            //string stLine = "";
            //stLine = stLine.ToString() + "\t" + "\t"  + Convert.ToString(averageDataGridView.Rows[0].Cells[0].Value);
            //stOutput += stLine + "\r\n" + "\r\n";
            stOutput += "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + date + "\r\n";

            Encoding u8 = Encoding.UTF8;
            byte[] output = u8.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs, u8);

            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();

            //sfd.Filter = "Word Documents (*.doc)|*.doc";

            //sfd.FileName = "Average.doc";

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    ToCsV(averageDataGridView, sfd.FileName); // Here dataGridview1 is your grid view name
            //}



            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Add(Visible: true);


            Range r = doc.Range(doc.Content.End - 1);

            r.Text = "Отчет о среднем рейтинге сериалов одной студии   " + DateTime.Today.ToString("dd-MM-yyyy");
            //r.Bold = 1;
            r.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            r.Font.Size = 14;
            

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Series.mdf;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT Studios.Name AS 'Studios Name', AVG(Series.Rating) AS 'Average rating of series' FROM Series, Studios WHERE Series.Id_studio = Studios.Id_studio GROUP BY Studios.Name", con);


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
                        t.Cell(1, 1).Range.Text = "Название студии";
                        t.Cell(1, 2).Range.Text = "Средний рейтинг сериалов";
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

        private void averageDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
