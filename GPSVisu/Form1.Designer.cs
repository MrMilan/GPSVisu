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
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReadGPS = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPocetSatanu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSpeedHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHisHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPocetSatanuHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartXY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimeHis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeedHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHisHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPocetSatanuHis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTimeHis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSpeed
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(21, 20);
            this.chartSpeed.Name = "chartSpeed";
            this.chartSpeed.Size = new System.Drawing.Size(1198, 396);
            this.chartSpeed.TabIndex = 0;
            this.chartSpeed.Text = "chartSpeed";
            // 
            // btnReadGPS
            // 
            this.btnReadGPS.Location = new System.Drawing.Point(108, 422);
            this.btnReadGPS.Name = "btnReadGPS";
            this.btnReadGPS.Size = new System.Drawing.Size(174, 65);
            this.btnReadGPS.TabIndex = 1;
            this.btnReadGPS.Text = "Nacti gps";
            this.btnReadGPS.UseVisualStyleBackColor = true;
            this.btnReadGPS.Click += new System.EventHandler(this.btnReadGPS_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(331, 422);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(166, 65);
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
            this.chartHeight.Location = new System.Drawing.Point(21, 546);
            this.chartHeight.Name = "chartHeight";
            this.chartHeight.Size = new System.Drawing.Size(1207, 396);
            this.chartHeight.TabIndex = 3;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartPocetSatanu
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPocetSatanu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPocetSatanu.Legends.Add(legend3);
            this.chartPocetSatanu.Location = new System.Drawing.Point(21, 967);
            this.chartPocetSatanu.Name = "chartPocetSatanu";
            this.chartPocetSatanu.Size = new System.Drawing.Size(1207, 396);
            this.chartPocetSatanu.TabIndex = 4;
            this.chartPocetSatanu.Text = "chartPocetSatanu";
            // 
            // chartSpeedHis
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSpeedHis.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSpeedHis.Legends.Add(legend4);
            this.chartSpeedHis.Location = new System.Drawing.Point(21, 1369);
            this.chartSpeedHis.Name = "chartSpeedHis";
            this.chartSpeedHis.Size = new System.Drawing.Size(1207, 396);
            this.chartSpeedHis.TabIndex = 5;
            this.chartSpeedHis.Text = "chartSpeedHis";
            // 
            // chartHisHeight
            // 
            chartArea5.Name = "ChartArea1";
            this.chartHisHeight.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHisHeight.Legends.Add(legend5);
            this.chartHisHeight.Location = new System.Drawing.Point(21, 1771);
            this.chartHisHeight.Name = "chartHisHeight";
            this.chartHisHeight.Size = new System.Drawing.Size(1207, 396);
            this.chartHisHeight.TabIndex = 6;
            this.chartHisHeight.Text = "chartHeightHis";
            // 
            // chartPocetSatanuHis
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPocetSatanuHis.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPocetSatanuHis.Legends.Add(legend6);
            this.chartPocetSatanuHis.Location = new System.Drawing.Point(21, 2173);
            this.chartPocetSatanuHis.Name = "chartPocetSatanuHis";
            this.chartPocetSatanuHis.Size = new System.Drawing.Size(1207, 396);
            this.chartPocetSatanuHis.TabIndex = 7;
            this.chartPocetSatanuHis.Text = "chartPocetSatanuHis";
            // 
            // chartXY
            // 
            chartArea7.Name = "ChartArea1";
            this.chartXY.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartXY.Legends.Add(legend7);
            this.chartXY.Location = new System.Drawing.Point(21, 3003);
            this.chartXY.Name = "chartXY";
            this.chartXY.Size = new System.Drawing.Size(1207, 396);
            this.chartXY.TabIndex = 8;
            this.chartXY.Text = "chartXY";
            // 
            // chartTimeHis
            // 
            chartArea8.Name = "ChartArea1";
            this.chartTimeHis.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartTimeHis.Legends.Add(legend8);
            this.chartTimeHis.Location = new System.Drawing.Point(21, 2587);
            this.chartTimeHis.Name = "chartTimeHis";
            this.chartTimeHis.Size = new System.Drawing.Size(1207, 396);
            this.chartTimeHis.TabIndex = 9;
            this.chartTimeHis.Text = "chartTimeHis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1024, 1024);
            this.ClientSize = new System.Drawing.Size(1213, 515);
            this.Controls.Add(this.chartTimeHis);
            this.Controls.Add(this.chartXY);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTimeHis;
    }
}

