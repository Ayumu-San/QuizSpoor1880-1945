using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 12;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("Quiz Berakhir!" + Environment.NewLine +
                                "Kamu telah menjawab " + score + " Pertanyaan secara benar" + Environment.NewLine +
                                "Nilaimu adalah " + percentage + " %" + Environment.NewLine +
                                "Pencet OK untuk memulai kembali"

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.Jawaban1;
                    lblQuestion.Text = "Terdapat sebuah perusahaan kereta nasional Belanda yang mempunyai jaringan kereta api terpanjang pada masanya serta dimiliki oleh pemerintah Belanda, perusahaan itu ialah...";

                    button1.Text = "Staatsspoorwegen (SS)";
                    button2.Text = "Nederlandsch-Indische Spoorweg Maatschappij (NISM)";
                    button3.Text = "Oost-Java Stoomtram Maatschappij (OJS)";
                    button4.Text = "Javasche Spoorweg Maatschappij, N.V. (JSM) ";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Jawaban2;
                    lblQuestion.Text = "Sebelum jalur keretanya di-regauge pada masa pendudukan Jepang menjadi Cape Gauge (1067 mm), perusahaan ini pernah memiliki jalur standard gauge (1435 mm). Perusahaan ini ialah perusahaan kereta.....";

                    button1.Text = "Nederlandsch-Indische Spoorweg Maatschappij (NISM)";
                    button2.Text = "Staatsspoorwegen (SS)";
                    button3.Text = "Bataviasche Oosterspoorweg Maatschappij (BOS)";
                    button4.Text = "Nederlands-Indische Tramweg Maatschappij (NITM)";

                    correctAnswer = 1;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.Jawaban3;

                    lblQuestion.Text = "Lokomotif uap asal Indonesia ini pernah mencapai kecepatan maksimum 110 km/h pada dan dinobatkan sebagai lokomotif tercepat dunia untuk tipe Narrow gauge (1067 mm). Lokomotif ini ialah lokomotif...";

                    button1.Text = "Lokomotif C 53";
                    button2.Text = "Lokomotif C 14";
                    button3.Text = "Lokomotif C 28";
                    button4.Text = "Lokomotif DD 52";

                    correctAnswer = 3;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.Jawaban4;

                    lblQuestion.Text = "Perusahaan jalur kereta daerah Banyumasan yang namanya diambil dari nama salah satu sungai di daerah tersebut";

                    button1.Text = "Klawing Elektrische Tram Maatschappij (KETM)";
                    button2.Text = "Pelus Tramweg Maatschappij (PTM)";
                    button3.Text = "Banjoemas Stoomtram Maatschappij (BSM)";
                    button4.Text = "Serajoedal Stoomtram Maatschappij (SDS)";

                    correctAnswer = 4;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.Jawaban5;

                    lblQuestion.Text = "Layanan kereta ini adalah salah satu layanan kereta terbaik dimasanya, Perjalanannya identik dengan malam hari. Nama kereta ini ialah...";

                    button1.Text = "Vlugge Vier";
                    button2.Text = "Vlugge Vijf";
                    button3.Text = "Java Natch";
                    button4.Text = "Eendasche Express";

                    correctAnswer = 3;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.Jawaban6;

                    lblQuestion.Text = "Elektrifikasi atau jalur kereta listik bukanlah sesuatu yang baru di Indonesia. Jalur kereta api listrik pertama yang dibangun Belanda menghubungkan dua kota, yaitu kota...";

                    button1.Text = "Jakarta-Bekasi";
                    button2.Text = "Jakarta-Bogor";
                    button3.Text = "Jakarta-Bandung";
                    button4.Text = "Surabaya-Jakarta";

                    correctAnswer = 2;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.Jawaban7;

                    lblQuestion.Text = "Jalur kereta listrik pertama di Indonesia beroperasi pada tahun?";

                    button1.Text = "1926";
                    button2.Text = "1989";
                    button3.Text = "1938";
                    button4.Text = "1992";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.Jawaban8;

                    lblQuestion.Text = "Beberapa kota dibawah adalah kota yang memiliki jaringan trem listrik. Kota tersebut ialah";

                    button1.Text = "Jakarta dan Medan";
                    button2.Text = "Jakarta dan Surabaya";
                    button3.Text = "Surabaya dan Solo";
                    button4.Text = "Jakarta dan Semarang";

                    correctAnswer = 2;

                    break;
                case 9:

                    pictureBox1.Image = Properties.Resources.Jawaban9;

                    lblQuestion.Text = "Mallet adalah sebutan untuk sebuah lokomotif uap dengan majemuk artikulasi, yang memungkinan satu buah lokomotif memiliki dua set silinder yang disambung menjadi satu. Salah satu lokomotif Mallet di Indonesia adalah...";

                    button1.Text = "CC 50";
                    button2.Text = "D 52";
                    button3.Text = "C 50";
                    button4.Text = "C 12";

                    correctAnswer = 1;

                    break;
                case 10:

                    pictureBox1.Image = Properties.Resources.Jawaban10;

                    lblQuestion.Text = "Lokomotif Mallet umumnya dioperasikan pada lintas pegunungan yang memiliki lengkung pada tikungan yang kecil. Lokomotif Mallet generasi pertama di Indonesia adalah...";

                    button1.Text = "CC 50";
                    button2.Text = "DD 52";
                    button3.Text = "BB 10";
                    button4.Text = "DD 50";

                    correctAnswer = 3;

                    break;
                case 11:

                    pictureBox1.Image = Properties.Resources.Jawaban11;

                    lblQuestion.Text = "Di Indonesia sendiri, ada beberapa lokomotif zaman pra-kemerdekaan yang masih beroperasi. Namun, ada salah satu lokomotif yang masih beroperasi dan sudah berumur 128 tahun lho! Lokomotif tersebut adalah lokomotif...";

                    button1.Text = "E 1060";
                    button2.Text = "B 5112";
                    button3.Text = "C 1218";
                    button4.Text = "B 2503";

                    correctAnswer = 3;

                    break;
                case 12:

                    pictureBox1.Image = Properties.Resources.Jawaban12;
                    lblQuestion.Text = "Balai Yasa Manggarai pada tahun 1938 pernah membangun beberapa kereta tidur mewah berpendingin udara yang diperuntukan bagi penumpang kelas satu yakni seri SAGL, Unit kereta tidur tersebut digunakan pada kereta malam?";

                    button1.Text = "Dhoho";
                    button2.Text = "Vlugge Vijf";
                    button3.Text = "Vlugge Vier ";
                    button4.Text = "Java Natch";

                    correctAnswer = 4;

                    break;




            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
