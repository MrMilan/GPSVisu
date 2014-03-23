namespace GPSVisu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReadGPS = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPocetSatanu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSpeedHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHisHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPocetSatanuHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart8 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimeHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeedHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHisHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanuHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeHis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSpeed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(45, 20);
            this.chartSpeed.Name = "chartSpeed";
            this.chartSpeed.Size = new System.Drawing.Size(382, 396);
            this.chartSpeed.TabIndex = 0;
            this.chartSpeed.Text = "chartSpeed";
            // 
            // btnReadGPS
            // 
            this.btnReadGPS.Location = new System.Drawing.Point(112, 1);
            this.btnReadGPS.Name = "btnReadGPS";
            this.btnReadGPS.Size = new System.Drawing.Size(58, 23);
            this.btnReadGPS.TabIndex = 1;
            this.btnReadGPS.Text = "Nacti gps";
            this.btnReadGPS.UseVisualStyleBackColor = true;
            this.btnReadGPS.Click += new System.EventHandler(this.btnReadGPS_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(254, 1);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(58, 23);
            this.Draw.TabIndex = 2;
            this.Draw.Text = "Vykresli";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // chartHeight
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHeight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHeight.Legends.Add(legend2);
            this.chartHeight.Location = new System.Drawing.Point(445, 20);
            this.chartHeight.Name = "chartHeight";
            this.chartHeight.Size = new System.Drawing.Size(382, 396);
            this.chartHeight.TabIndex = 3;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartPocetSatanu
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPocetSatanu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPocetSatanu.Legends.Add(legend3);
            this.chartPocetSatanu.Location = new System.Drawing.Point(860, 20);
            this.chartPocetSatanu.Name = "chartPocetSatanu";
            this.chartPocetSatanu.Size = new System.Drawing.Size(382, 396);
            this.chartPocetSatanu.TabIndex = 4;
            this.chartPocetSatanu.Text = "chartPocetSatanu";
            // 
            // chartSpeedHis
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSpeedHis.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSpeedHis.Legends.Add(legend4);
            this.chartSpeedHis.Location = new System.Drawing.Point(43, 422);
            this.chartSpeedHis.Name = "chartSpeedHis";
            this.chartSpeedHis.Size = new System.Drawing.Size(382, 396);
            this.chartSpeedHis.TabIndex = 5;
            this.chartSpeedHis.Text = "chartSpeedHis";
            // 
            // chartHisHeight
            // 
            chartArea5.Name = "ChartArea1";
            this.chartHisHeight.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHisHeight.Legends.Add(legend5);
            this.chartHisHeight.Location = new System.Drawing.Point(445, 422);
            this.chartHisHeight.Name = "chartHisHeight";
            this.chartHisHeight.Size = new System.Drawing.Size(382, 396);
            this.chartHisHeight.TabIndex = 6;
            this.chartHisHeight.Text = "chartHeightHis";
            // 
            // chartPocetSatanuHis
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPocetSatanuHis.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPocetSatanuHis.Legends.Add(legend6);
            this.chartPocetSatanuHis.Location = new System.Drawing.Point(858, 422);
            this.chartPocetSatanuHis.Name = "chartPocetSatanuHis";
            this.chartPocetSatanuHis.Size = new System.Drawing.Size(382, 396);
            this.chartPocetSatanuHis.TabIndex = 7;
            this.chartPocetSatanuHis.Text = "chartPocetSatanuHis";
            // 
            // chart7
            // 
            chartArea7.Name = "ChartArea1";
            this.chart7.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart7.Legends.Add(legend7);
            this.chart7.Location = new System.Drawing.Point(445, 833);
            this.chart7.Name = "chart7";
            this.chart7.Size = new System.Drawing.Size(382, 396);
            this.chart7.TabIndex = 8;
            this.chart7.Text = "chart7";
            // 
            // chart8
            // 
            chartArea8.Name = "ChartArea1";
            this.chart8.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart8.Legends.Add(legend8);
            this.chart8.Location = new System.Drawing.Point(849, 833);
            this.chart8.Name = "chart8";
            this.chart8.Size = new System.Drawing.Size(382, 396);
            this.chart8.TabIndex = 10;
            this.chart8.Text = "chart8";
            // 
            // chartTimeHis
            // 
            chartArea9.Name = "ChartArea1";
            this.chartTimeHis.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartTimeHis.Legends.Add(legend9);
            this.chartTimeHis.Location = new System.Drawing.Point(34, 833);
            this.chartTimeHis.Name = "chartTimeHis";
            this.chartTimeHis.Size = new System.Drawing.Size(382, 396);
            this.chartTimeHis.TabIndex = 9;
            this.chartTimeHis.Text = "chartTimeHis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1024, 1024);
            this.ClientSize = new System.Drawing.Size(1228, 515);
            this.Controls.Add(this.chart8);
            this.Controls.Add(this.chartTimeHis);
            this.Controls.Add(this.chart7);
            this.Controls.Add(this.chartPocetSatanuHis);
            this.Controls.Add(this.chartHisHeight);
            this.Controls.Add(this.chartSpeedHis);
            this.Controls.Add(this.chartPocetSatanu);
            this.Controls.Add(this.chartHeight);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.btnReadGPS);
            this.Controls.Add(this.chartSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeedHis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHisHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanuHis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeHis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.Button btnReadGPS;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPocetSatanu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeedHis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHisHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPocetSatanuHis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeHis;
    }
}

