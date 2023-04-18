using System.IO;
using System.Net;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Font = iTextSharp.text.Font;

namespace ShareFormFill_Project
{
    public partial class FormUpload : Form
    {
        string? MainName;
        string? ADDRESS;
        string? EMAIL;
        string? Mobile;
        string? PAN;
        string? BDAC;
        string? acno;
        string? bab;
        string? pathin;
        string? pathout;
        public FormUpload()
        {
            InitializeComponent();
        }

        public void Formfill(string pathin, string pathout)
        {
            //create PdfReader object to read from the existing document
            using (PdfReader reader = new PdfReader(pathin))
            //create PdfStamper object to write to get the pages from reader 
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(pathout, FileMode.Create)))
            {
                //select two pages from the original document
                reader.SelectPages("1-2");

                //gettins the page size in order to substract from the iTextSharp coordinates
                var pageSize = reader.GetPageSize(1);

                // PdfContentByte from stamper to add content to the pages over the original content
                PdfContentByte pbover = stamper.GetOverContent(1);





                #region NAME SECTION
                //add content to the page using ColumnText
                Font font = new Font();
                font.Size = 11;

                //setting up the X and Y coordinates of the document
                float x = 330;
                int y = 110;

                y = (int)(pageSize.Height - y);

                string Name = MainName.Substring(0, 15);

                foreach (char xname in Name.ToCharArray())
                {
                    string xstr = xname.ToString();
                    x = x + 16.5f;
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, font), x, y + 1, 0);
                }

                float xsub = 295;
                string Name2 = MainName.Substring(15);
                foreach (char xname2 in Name2.ToCharArray())
                {
                    string xstr = xname2.ToString();
                    xsub = xsub + 16.5f;
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, font), xsub, y - 12, 0);
                }

                //////////////////////////////////
                Font fontn1 = new Font();
                fontn1.Size = 7;

                //setting up the X and Y coordinates of the document
                float xn1 = 93;
                int yn1 = 655;
                yn1 = (int)(pageSize.Height - yn1);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(MainName, fontn1), xn1, yn1, 0);
                //////////////////////////////////

                //////////////////////////////////
                Font fontn2 = new Font();
                fontn2.Size = 7;

                //setting up the X and Y coordinates of the document
                float xn2 = 400;
                int yn2 = 710;
                yn2 = (int)(pageSize.Height - yn2);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(MainName, fontn2), xn2, yn2, 0);
                //////////////////////////////////////
                #endregion

                #region ADDRESS SECTION
                //add content to the page using ColumnText
                Font fontADRS = new Font();
                fontADRS.Size = 7;

                //setting up the X and Y coordinates of the document
                float xA = 340;
                int yA = 135;

                yA = (int)(pageSize.Height - yA);

                string ADDRESS1 = ADDRESS.Substring(0, 57);
                string ADDRESS2 = ADDRESS.Substring(57);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(ADDRESS1, fontADRS), xA, yA, 0);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(ADDRESS2, fontADRS), xA - 35, yA - 10, 0);
                #endregion

                #region Email SECTION
                //add content to the page using ColumnText
                Font fontE = new Font();
                fontE.Size = 7;

                //setting up the X and Y coordinates of the document
                float xE = 340;
                int yE = 135;
                yE = (int)(pageSize.Height - yE);
                //35 CHAR THI VADHARE NAI LAIYE

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(EMAIL, fontADRS), xE + 105, yE - 9, 0);

                ////////////////////////////////////////////////////
                Font fontE1 = new Font();
                fontE1.Size = 9;
                float xE1 = 250;
                int yE1 = 670;
                yE1 = (int)(pageSize.Height - yE1);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(EMAIL, fontE1), xE1, yE1, 0);
                ///
                #endregion

                #region MObile NO SECTION
                //add content to the page using ColumnText
                Font fontM = new Font();
                fontM.Size = 11;

                //setting up the X and Y coordinates of the document
                float xM = 410;
                int yM = 157;
                yM = (int)(pageSize.Height - yM);
                //35 CHAR THI VADHARE NAI LAIYE

                foreach (char xname in Mobile.ToCharArray())
                {
                    string xstr = xname.ToString();
                    xM = xM + 16.5f;
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, fontM), xM, yM, 0);
                }
                ////////////////////////////////////////////
                Font fontM1 = new Font();
                fontM1.Size = 11;
                float xM1 = 93;
                int yM1 = 670;
                yM1 = (int)(pageSize.Height - yM1);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(Mobile, fontM1), xM1, yM1, 0);
                ///////////////////////////////////////
                #endregion

                #region PAN NO SECTION
                //add content to the page using ColumnText
                Font fontP = new Font();
                fontP.Size = 15;

                //setting up the X and Y coordinates of the document
                float xP = 313;
                int yP = 190;
                yP = (int)(pageSize.Height - yP);
                //35 CHAR THI VADHARE NAI LAIYE

                foreach (char xname in PAN.ToCharArray())
                {
                    string xstr = xname.ToString();
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, fontP), xP, yP, 0);
                    xP = xP + 28.5f;
                }

                ///////////////////////////////////////////////////////////////////
                Font fontP2 = new Font();
                fontP2.Size = 15;

                //setting up the X and Y coordinates of the document
                float xP2 = 390;
                int yP2 = 600;
                yP2 = (int)(pageSize.Height - yP2);
                //35 CHAR THI VADHARE NAI LAIYE

                foreach (char xname in PAN.ToCharArray())
                {
                    string xstr = xname.ToString();
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, fontP2), xP2, yP2, 0);
                    xP2 = xP2 + 20.5f;
                }
                //////////////////////////////////////////////////////////////////////////////

                ///////////////////////////////////////////////////////////////////
                Font fontP3 = new Font();
                fontP3.Size = 15;

                //setting up the X and Y coordinates of the document
                float xP3 = 390;
                int yP3 = 800;
                yP3 = (int)(pageSize.Height - yP3);
                //35 CHAR THI VADHARE NAI LAIYE

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(PAN, fontP3), xP3, yP3, 0);
                //////////////////////////////////////////////////////////////////////////////
                #endregion

                #region Bidder Deposit AC
                Font font1 = new Font();
                font1.Size = 22;

                float x1 = 27;
                int y1 = 230;

                y1 = (int)(pageSize.Height - y1);

                foreach (char xname in BDAC.ToCharArray())
                {
                    string xstr = xname.ToString();
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, font1), x1, y1, 0);
                    x1 = x1 + 27.3f;
                }

                /////////////////////////////////////////////
                Font fontb1 = new Font();
                fontb1.Size = 15;

                float xb1 = 45;
                int yb1 = 600;

                yb1 = (int)(pageSize.Height - yb1);

                foreach (char xname in BDAC.ToCharArray())
                {
                    string xstr = xname.ToString();
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, fontb1), xb1, yb1, 0);
                    xb1 = xb1 + 21.5f;
                }
                ///////////////////////////////////////////

                #endregion

                #region AC NO
                Font font3 = new Font();
                font3.Size = 12;

                float x3 = 53;
                int y3 = 383;

                y3 = (int)(pageSize.Height - y3);


                foreach (char xc in acno.ToCharArray())
                {
                    string xstr = xc.ToString();
                    x3 = x3 + 14.6f;
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(xstr, font3), x3, y3, 0);
                }

                /////////////////////////////////
                Font fontac3 = new Font();
                fontac3.Size = 8;

                float xac3 = 253;
                int yac3 = 625;
                yac3 = (int)(pageSize.Height - yac3);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(acno, fontac3), xac3, yac3, 0);

                /////////////////////////////////
                ///
                /////////////////////////////////
                Font fontac4 = new Font();
                fontac4.Size = 8;

                float xac4 = 140;
                int yac4 = 755;
                yac4 = (int)(pageSize.Height - yac4);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(acno, fontac4), xac4, yac4, 0);

                /////////////////////////////////
                #endregion

                #region BANK AND BRANCH
                Font fontbab = new Font();
                fontbab.Size = 11;

                float xbab = 97;
                int ybab = 397;
                ybab = (int)(pageSize.Height - ybab);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(bab, fontbab), xbab, ybab, 0);

                /////////////////////////////////
                Font fontbab1 = new Font();
                fontbab1.Size = 8;

                float xbab1 = 100;
                int ybab1 = 640;
                ybab1 = (int)(pageSize.Height - ybab1);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(bab, fontbab1), xbab1, ybab1, 0);

                /////////////////////////////////
                ///
                //////////////////////////////////
                Font fontbab2 = new Font();
                fontbab2.Size = 8;

                float xbab2 = 110;
                int ybab2 = 765;
                ybab2 = (int)(pageSize.Height - ybab2);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase(bab, fontbab2), xbab2, ybab2, 0);
                //////////////////////////////////////////
                #endregion

                Font font2 = new Font();
                font2.Size = 12;

                int x2 = 210;
                int y2 = 310;
                y2 = (int)(pageSize.Height - y2);

                ColumnText.ShowTextAligned(pbover, Element.ALIGN_UNDEFINED, new Phrase("CUT-OFF", font2), x2, y2, 0);




                MessageBox.Show(MainName, "File Generated");

            }

        }

        private void fillUpButtonClick(object sender, EventArgs e)
        {
            MainName = "JHON VASUBHAI PATEL";
            ADDRESS = "123, Random Apartment, Kalupur Road, Jumalal, Odhav, Ahmedabad - 388888";
            EMAIL = " ";
            Mobile = "9898989898";
            PAN = "PANGG1234G";
            BDAC = "IN12345678912345";
            acno = "123456789123456789";
            bab = "RICHEST BANK, LONDON, AHMEDABAD";

            pathin = openFileDialog1.FileName.Replace("\\", "/");
            pathout = pathin.Replace(".pdf", "_") + MainName + ".pdf";
            Formfill(pathin, pathout);
        }

        private void uploadFormButtonClick(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            pathTextBox.Text = openFileDialog1.FileName;
        }
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        
    }
}