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

        #endregion


        public Form1()
        {
            // inicializace grafu
            InitializeComponent();
            chartSpeed.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartSpeed.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chartSpeed.ChartAreas[0].CursorX.AutoScroll = true;
            chartSpeed.ChartAreas[0].CursorY.AutoScroll = true;

            chartSpeed.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartSpeed.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            chartHeight.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartHeight.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chartHeight.ChartAreas[0].CursorX.AutoScroll = true;
            chartHeight.ChartAreas[0].CursorY.AutoScroll = true;

            chartHeight.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartHeight.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            chart3.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart3.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart3.ChartAreas[0].CursorX.AutoScroll = true;
            chart3.ChartAreas[0].CursorY.AutoScroll = true;

            chart3.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart3.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
        }

        private void btnReadGPS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "NMEA files (*.nmea)|*.nmea|NMEA file (*.NMEA)|*.NMEA|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadDataFromFileNMEA(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pojebalo se to nekde pri nacitani Puvodni error: " + ex.Message);
                }
            }

        }

        /// <summary>
        /// Funkce pro nacitani dat ze souboru s koncovkou NMEA
        /// </summary>
        /// <param name="route">Cesta k souboru</param>
        private void ReadDataFromFileNMEA(string route)
        {
            string[] rawDataFromFile = File.ReadAllLines(route);
            DivideDataByType(rawDataFromFile);
        }

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

        /// <summary>
        /// Predelani separatoru pro budouci praci
        /// </summary>
        /// <param name="inputStringArray">Vstupni stringove pole</param>
        /// <param name="oldSeparator">Separator kterz ma byt nahrazen</param>
        /// <param name="newSeparator">Cim ma byt nahrazen</param>
        /// <returns>Vraci pole stringu s novym separatorem</returns>
        private string[] ReplaceSeparator(string[] inputStringArray, string oldSeparator, string newSeparator)
        {
            string[] newArrayWithNewSeparator = new string[inputStringArray.Length];
            for (int i = 0; i < inputStringArray.Length; i++)
            {
                newArrayWithNewSeparator[i] = inputStringArray[i].Replace(oldSeparator, newSeparator);
            }
            return newArrayWithNewSeparator;
        }

        private double[] Histogram(double[] data, int range)
        {
            Array.Sort(data);
            double diference = data.Max() - data.Min();
            int group = (int)(diference / range);
            double[] his = new double[group];
            for (int i = 0; i < group; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] >= (data.Min()+(range*i)) && data[j] < (data.Min()+(range*(i+1))))
                    {
                        his[i]++;
                    }

                }
            }
            return his;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            DrawSpeed();
            DrawHeight();
            DrawSat();
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
                if(inputStringArray[i]=="")
                {
                inputStringArray[i]="0";
                }
            }
            return inputStringArray;
        }

        private void DrawSpeed()
        {
            string nameLine = "rychle";
            chartSpeed.Series.Add(nameLine);
            chartSpeed.Series[nameLine].ChartType = SeriesChartType.Point;
            double[] speeDat = Speed();
            for (int i = 0; i < speeDat.Length; i++)
            {
                chartSpeed.Series[nameLine].Points.AddXY(i, speeDat[i]);
            }

            string name = "rychleHis";
            int range = 2;
            chartSpeedHis.Series.Add(name);
            chartSpeedHis.Series[name].ChartType = SeriesChartType.Bar;
            double[] pokus = { 1, 2, 3, 4, 5, 6, 7,7,7,7, 1, 2, 3, 4, 5, 6 };

            //double[] speeDatas = new double[speeDat.Length/20];
            //int k = 0;
            //for (int i = 0; i < speeDat.Length; i+=20)
            //{
            //    speeDatas[k] = speeDat[i];
            //    k++;
            //}

            double[] inputDataHis = Histogram(pokus,range);
            for (int i = 0; i < inputDataHis.Length; i++)
            {
                chartSpeedHis.Series[name].Points.AddXY(inputDataHis.Min()+(i*range), inputDataHis[i]);
            }

        }

        public double[] Speed()
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

        private void DrawHeight()
        {
            string nameLine = "vejska";
            chartHeight.Series.Add(nameLine);
            chartHeight.Series[nameLine].ChartType = SeriesChartType.Point;
            double[] inputDataArray = Heightos();
            for (int i = 0; i < inputDataArray.Length; i++)
            {
                chartHeight.Series[nameLine].Points.AddXY(i, inputDataArray[i]);
            }

        }

        public double[] Heightos()
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

        private void DrawSat()
        {
            string nameLine = "sat";
            chart3.Series.Add(nameLine);
            chart3.Series[nameLine].ChartType = SeriesChartType.Point;
            double[] inputDataArray = Sat();
            for (int i = 0; i < inputDataArray.Length; i++)
            {
                chart3.Series[nameLine].Points.AddXY(i, inputDataArray[i]);
            }

        }

        public double[] Sat()
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

       
    }
}
