using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace GPSVisu
{
    public partial class Form1 : Form
    {

        #region GlobalVariebles
        private List<GGA> dataGGA = new List<GGA>();
        private List<GSA> dataGSA = new List<GSA>();
        private List<RMC> dataRMC = new List<RMC>();

        private const string nameLineSpeedHistogram = "rychleHis";
        private const string nameLineSpeed = "rychle";
        private const string nameLineHeight = "vyska";
        private const string nameLineHeightHistogram = "vyska His";
        private const string nameLineCounSat = "Pocet Statelitu";
        private const string nameLineCounSatHistogram = "Pocet Statelitu His";

        private const SeriesChartType nomalTypekCary = SeriesChartType.Point;
        private const SeriesChartType hisTypekCaru = SeriesChartType.Bar;

        private const int rozsahSpeed = 20;
        private const int rozahVEj = 300;
        private const int rozahSatani = 10;



        #endregion


        public Form1()
        {
            // inicializace grafu
            InitializeComponent();

            InitChartu(chartSpeed);
            InitChartu(chartHeight);
            InitChartu(chartPocetSatanu);
            InitChartu(chartHisHeight);
            InitChartu(chartPocetSatanuHis);
            InitChartu(chartSpeedHis);
        }

        #region Eventsna kliknuti

        private void btnReadGPS_Click(object sender, EventArgs e)
        {
            string seznamCtenychSouboru = ListFileTerminals();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = seznamCtenychSouboru;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DivideDataByType(ReadDataFromFile(openFileDialog1.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pojebalo se to nekde pri nacitani Puvodni error: " + ex.Message);
                }
            }

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            double[] speedData = TakeSpeedFromRMCVector();
            double[] heightData = TakeHeightFromVectorGGA();
            double[] satDataArray = TakeNumberSatFromGGAVector();

            PrDelSerieChartu(chartSpeed);
            DrawToGraphos(chartSpeed, speedData, nameLineSpeed, nomalTypekCary);

            PrDelSerieChartu(chartSpeedHis);
            DrawHistogram(chartSpeedHis, speedData, nameLineSpeedHistogram, hisTypekCaru, rozsahSpeed);

            PrDelSerieChartu(chartHeight);
            DrawToGraphos(chartHeight, heightData, nameLineHeight, nomalTypekCary);

            PrDelSerieChartu(chartHisHeight);
            DrawHistogram(chartHisHeight, heightData, nameLineSpeedHistogram, hisTypekCaru, rozahVEj);

            PrDelSerieChartu(chartPocetSatanu);
            DrawToGraphos(chartPocetSatanu, satDataArray, nameLineCounSat, nomalTypekCary);

            PrDelSerieChartu(chartPocetSatanuHis);
            DrawHistogram(chartPocetSatanuHis, speedData, nameLineSpeedHistogram, hisTypekCaru, rozahSatani);
        }
        #endregion


        #region Splitovani a parsovani dat

        private void DivideDataByType(string[] inputDataFromFile)
        {
            for (int i = 0; i < inputDataFromFile.Length; i++)
            {
                string[] transferLevel = inputDataFromFile[i].Split(',');

                if (transferLevel[0] == "$GPGGA")
                {
                    dataGGA.Add(GetGGAData(transferLevel));
                }
                if (transferLevel[0] == "$GPGSA")
                {
                    dataGSA.Add(GetGSAData(transferLevel));
                }

                if (transferLevel[0] == "$GPRMC")
                {
                    dataRMC.Add(GetRMCData(transferLevel));
                }

            }

        }

        private GGA GetGGAData(string[] splitedRow)
        {
            ////        $GPGGA 0,123519 1,4807.038 2,N 3,01131.000 4,E 5,1 6,08 7,0.9 8,545.4 9,M 10,46.9 11,M 12, 13,*47 14
            GGA rData = new GGA();
            splitedRow = ReplaceSeparator(splitedRow, ".", ",");
            splitedRow = ReplaceNull(splitedRow);
            rData.Name = splitedRow[0];
            rData.Time = splitedRow[1];
            rData.Latitude = Convert.ToDouble(splitedRow[2]);
            rData.CharLatitude = Convert.ToChar(splitedRow[3]);
            rData.Longitude = Convert.ToDouble(splitedRow[4]);
            rData.CharLongitude = Convert.ToChar(splitedRow[5]);
            rData.FixQuality = Convert.ToInt32(splitedRow[6]);
            rData.NuberSat = Convert.ToInt32(splitedRow[7]);
            rData.HorizontalDilution = Convert.ToDouble(splitedRow[8]);
            rData.Altitude = Convert.ToDouble(splitedRow[9]);
            rData.HeightOfGeoid = Convert.ToDouble(splitedRow[11]);
            rData.Checksum = splitedRow[14];

            return rData;
        }

        private GSA GetGSAData(string[] splitedRow)
        {

            //        $GPGSA 0,A 1,3 2,04 3,05 4, 5,09 6,12 7, 8, 9,24 10, 11, 12, 13, 14,2.5 15,1.3 16,2.1*39 17
            GSA rData = new GSA();
            splitedRow = ReplaceSeparator(splitedRow, ".", ",");
            splitedRow = ReplaceNull(splitedRow);
            string[] pomoc;
            if (splitedRow[17] != "")
            {
                pomoc = new string[2] { "0", "0" };
            }
            else
            {
                pomoc = splitedRow[17].Split('*');
            }

            rData.Name = splitedRow[0];
            rData.SelectionMode = splitedRow[1];
            rData.ThreeDFix = Convert.ToInt32(splitedRow[2]);
            rData.PRNsOfSatellites1 = splitedRow[3];
            rData.PRNsOfSatellites2 = splitedRow[4];
            rData.PRNsOfSatellites3 = splitedRow[5];
            rData.PRNsOfSatellites4 = splitedRow[6];
            rData.PRNsOfSatellites5 = splitedRow[7];
            rData.PRNsOfSatellites6 = splitedRow[8];
            rData.PRNsOfSatellites7 = splitedRow[9];
            rData.PRNsOfSatellites8 = splitedRow[10];
            rData.PRNsOfSatellites9 = splitedRow[11];
            rData.PRNsOfSatellites10 = splitedRow[12];
            rData.PRNsOfSatellites11 = splitedRow[13];
            rData.PRNsOfSatellites12 = splitedRow[14];
            rData.PDOP = Convert.ToDouble(splitedRow[15]);
            rData.HDOP = Convert.ToDouble(splitedRow[16]);
            rData.VDOP = Convert.ToDouble(pomoc[0]);
            rData.Checksum = pomoc[1];

            return rData;
        }

        private RMC GetRMCData(string[] splitedRow)
        {

            //        $GPRMC 0,123519 1,A 2,4807.038 3,N 4,01131.000 5,E 6,022.4 7,084.4 8,230394 9,003.1 10,W*6A 11

            RMC rData = new RMC();
            splitedRow = ReplaceSeparator(splitedRow, ".", ",");
            splitedRow = ReplaceNull(splitedRow);
            string[] pomoc;
            if (splitedRow[11] != "")
            {
                pomoc = new string[2] { "0", "0" };
            }
            else
            {
                pomoc = splitedRow[11].Split('*');
            }
            rData.Name = splitedRow[0];
            rData.Time = splitedRow[1];
            rData.Status = Convert.ToChar(splitedRow[2]);
            rData.Latitude = Convert.ToDouble(splitedRow[3]);
            rData.CharLatitude = Convert.ToChar(splitedRow[4]);
            rData.Longitude = Convert.ToDouble(splitedRow[5]);
            rData.CharLongitude = Convert.ToChar(splitedRow[6]);
            rData.SpeedOverGround = Convert.ToDouble(splitedRow[7]);
            rData.TrackAngleDegree = Convert.ToDouble(splitedRow[8]);
            rData.Date = splitedRow[9];
            rData.MagneticVariation = Convert.ToDouble(splitedRow[10]);
            rData.Checksum = pomoc[1];

            return rData;
        }

        #endregion





        #region Zakladni vztahovani dat z naparsovaneho souboru

        public double[] TakeHeightFromVectorGGA()
        {
            double[] heiArr = new double[dataGGA.Count()];
            int iter = 0;
            foreach (GGA alti in dataGGA)
            {
                heiArr[iter] = alti.Altitude;
                iter++;
            }
            return heiArr;

        }

        public double[] TakeNumberSatFromGGAVector()
        {
            double[] satArr = new double[dataGGA.Count()];
            int iter = 0;
            foreach (GGA nSat in dataGGA)
            {
                satArr[iter] = nSat.NuberSat;
                iter++;
            }
            return satArr;

        }

        public double[] TakeSpeedFromRMCVector()
        {
            double[] speedArr = new double[dataRMC.Count()];
            int iter = 0;
            foreach (RMC speed in dataRMC)
            {
                speedArr[iter] = speed.SpeedOverGround;
                iter++;
            }
            return speedArr;

        }

        #endregion

        #region Bezne rutiny

        /// <summary>
        /// Funkce pro nacitani dat ze souboru
        /// </summary>
        /// <param name="route">Cesta k souboru</param>
        private string[] ReadDataFromFile(string route)
        {
            return  File.ReadAllLines(route);
        }

        private string ListFileTerminals()
        {
            List<string> cteneTypySouboru = new List<string>();
            cteneTypySouboru.Add("NMEA files (*.nmea)|*.nmea");
            cteneTypySouboru.Add("NMEA file (*.NMEA)|*.NMEA");
            cteneTypySouboru.Add("Textak file (*.txt)|*.txt");
            cteneTypySouboru.Add("Textak file (*.TXT)|*.TXT");
            cteneTypySouboru.Add("All files (*.*)|*.*");

            string seznamCtenychSouboru = "";

            for (int i = 0; i < cteneTypySouboru.Count(); i++)
            {
                if (i < cteneTypySouboru.Count() - 1)
                { seznamCtenychSouboru += cteneTypySouboru[i] + "|"; }
                else
                { seznamCtenychSouboru += cteneTypySouboru[i]; }
            }

            return seznamCtenychSouboru;
        
        }

        private double[] Histogram(double[] data, int range)
        {
            Array.Sort(data);
            double diference = data.Max() - data.Min();
            int group = (int)(diference / range);
            double[] his = new double[group];


            for (int j = 0; j < data.Length; j++)
            {
                for (int i = 0; i < group; i++)
                {
                    if (data[j] > (data.Min() + (range * i)) && data[j] <= (data.Min() + (range * (i + 1))))
                    {
                        his[i]++;
                        break;
                    }
                    if (data[j] == data.Min())
                    {
                        his[i]++;
                        break;
                    }
                }
            }
            return his;
        }

        #region rReplace metody

        private string[] ReplaceSeparator(string[] inputStringArray, string oldSeparator, string newSeparator)
        {
            string[] newArrayWithNewSeparator = new string[inputStringArray.Length];
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                newArrayWithNewSeparator[i] = inputStringArray[i].Replace(oldSeparator, newSeparator);
            }
            return newArrayWithNewSeparator;
        }

        /// <summary>
        /// Funkce pro vykresleni dat
        /// </summary>
        /// <param name="inputDataArray">Nacita vstupni double pole</param>
        /// <param name="nameLine">Nazev rady</param>
        public string[] ReplaceNull(string[] inputStringArray)
        {

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(inputStringArray[i]))
                {
                    inputStringArray[i] = "0";
                }
            }
            return inputStringArray;
        }

        #endregion

        #region Grafove metody

        private void InitChartu(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek)
        {
            nameChartek.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            nameChartek.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            nameChartek.ChartAreas[0].CursorX.AutoScroll = true;
            nameChartek.ChartAreas[0].CursorY.AutoScroll = true;

            nameChartek.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            nameChartek.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

        }

        private void PrDelSerieChartu(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek)
        {
            for (int i = 0; i < nameChartek.Series.Count; i++)
            {
                nameChartek.Series.RemoveAt(i);
            }
        }

        private void DrawLineDataToChart(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek, double[] inputDataArray, string nameLine)
        {
            for (int i = 0; i < inputDataArray.Length; i++)
            {
                nameChartek.Series[nameLine].Points.AddXY(i, inputDataArray[i]);
            }
        }

        private void DrawToGraphos(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek, double[] inputArray, string nameLine, SeriesChartType seriesChartType)
        {
            PrepareSerie(nameChartek, nameLine, seriesChartType);
            DrawLineDataToChart(nameChartek, inputArray, nameLine);

        }

        private void PrepareSerie(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek, string nameLine, SeriesChartType seriesChartType)
        {
            nameChartek.Series.Add(nameLine);
            nameChartek.Series[nameLine].ChartType = seriesChartType;
        }

        private void DrawHistogram(System.Windows.Forms.DataVisualization.Charting.Chart nameChartek, double[] inputArray, string nameLine, SeriesChartType seriesChartType, int range)
        {
            if (range == null)
            {
                range = 100;
            }

            PrepareSerie(nameChartek, nameLine, seriesChartType);

            // double[] pokus = { 1, 2, 3, 4, 5, 6, 7, 7, 7, 7, 1,6,6, 2, 3, 4, 5, 6 };range = 2; // Rozložení histogramu {6,4,8}

            double[] inputDataHis = Histogram(inputArray, range);

            for (int i = 0; i < inputDataHis.Length; i++)
            {
                nameChartek.Series[nameLine].Points.AddXY(inputDataHis.Min() + (i * range), inputDataHis[i]);
            }
        }

        #endregion

        #endregion
    }
}
