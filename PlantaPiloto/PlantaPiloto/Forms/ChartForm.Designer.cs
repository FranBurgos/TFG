﻿using PlantaPiloto.Services;

namespace PlantaPiloto
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chartVar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            this.tFG_DBDataSet = new PlantaPiloto.Services.TFG_DBDataSet();
            this.lblChartAmount = new System.Windows.Forms.Label();
            this.txtChartAmount = new System.Windows.Forms.RichTextBox();
            this.btnChartAmount = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFG_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVar.Legends.Add(legend1);
            this.chartVar.Location = new System.Drawing.Point(12, 12);
            this.chartVar.Name = "chartVar";
            this.chartVar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVar.Series.Add(series1);
            this.chartVar.Size = new System.Drawing.Size(776, 397);
            this.chartVar.TabIndex = 0;
            this.chartVar.Text = "chart1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(712, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tFG_DBDataSet
            // 
            this.tFG_DBDataSet.DataSetName = "TFG_DBDataSet";
            this.tFG_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblChartAmount
            // 
            this.lblChartAmount.AutoSize = true;
            this.lblChartAmount.Location = new System.Drawing.Point(12, 415);
            this.lblChartAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChartAmount.Name = "lblChartAmount";
            this.lblChartAmount.Size = new System.Drawing.Size(76, 13);
            this.lblChartAmount.TabIndex = 2;
            this.lblChartAmount.Text = "cantidadDatos";
            // 
            // txtChartAmount
            // 
            this.txtChartAmount.Location = new System.Drawing.Point(191, 413);
            this.txtChartAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChartAmount.Multiline = false;
            this.txtChartAmount.Name = "txtChartAmount";
            this.txtChartAmount.Size = new System.Drawing.Size(84, 22);
            this.txtChartAmount.TabIndex = 3;
            this.txtChartAmount.Text = "";
            this.txtChartAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChartAmount_KeyPress);
            // 
            // btnChartAmount
            // 
            this.btnChartAmount.Location = new System.Drawing.Point(284, 413);
            this.btnChartAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChartAmount.Name = "btnChartAmount";
            this.btnChartAmount.Size = new System.Drawing.Size(52, 25);
            this.btnChartAmount.TabIndex = 4;
            this.btnChartAmount.Text = "button1";
            this.btnChartAmount.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PlantaPiloto.Properties.Resources.help;
            this.pictureBox3.Location = new System.Drawing.Point(665, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnChartAmount);
            this.Controls.Add(this.txtChartAmount);
            this.Controls.Add(this.lblChartAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chartVar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChartForm";
            this.Text = "Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartForm_FormClosing);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFG_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVar;
        private System.Windows.Forms.Button btnClose;
        private TFG_DBDataSet tFG_DBDataSet;
        private System.Windows.Forms.Label lblChartAmount;
        private System.Windows.Forms.RichTextBox txtChartAmount;
        private System.Windows.Forms.Button btnChartAmount;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}