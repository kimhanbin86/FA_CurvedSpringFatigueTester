
namespace CurvedSpringFatigueTester
{
    partial class FrmFrcByPos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ct_FrcByPos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_Count = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Form_Frc_Interval = new System.Windows.Forms.NumericUpDown();
            this.num_Form_Frc_Maximum = new System.Windows.Forms.NumericUpDown();
            this.num_Form_Frc_Minimum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Form_Pos_Interval = new System.Windows.Forms.NumericUpDown();
            this.num_Form_Pos_Maximum = new System.Windows.Forms.NumericUpDown();
            this.num_Form_Pos_Minimum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_FrcByPos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Minimum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Minimum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ct_FrcByPos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ct_FrcByPos
            // 
            chartArea1.Name = "ChartArea1";
            this.ct_FrcByPos.ChartAreas.Add(chartArea1);
            this.ct_FrcByPos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ct_FrcByPos.Legends.Add(legend1);
            this.ct_FrcByPos.Location = new System.Drawing.Point(3, 3);
            this.ct_FrcByPos.Name = "ct_FrcByPos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ct_FrcByPos.Series.Add(series1);
            this.ct_FrcByPos.Size = new System.Drawing.Size(1002, 577);
            this.ct_FrcByPos.TabIndex = 0;
            this.ct_FrcByPos.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.num_Count);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(3, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 140);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(618, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "지정된 카운트에 그래프를 초기화합니다";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(618, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Count :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Count
            // 
            this.num_Count.Location = new System.Drawing.Point(732, 58);
            this.num_Count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Count.Name = "num_Count";
            this.num_Count.Size = new System.Drawing.Size(81, 27);
            this.num_Count.TabIndex = 5;
            this.num_Count.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.num_Form_Frc_Interval);
            this.groupBox2.Controls.Add(this.num_Form_Frc_Maximum);
            this.groupBox2.Controls.Add(this.num_Form_Frc_Minimum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(314, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y 축 (Nm)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interval :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Form_Frc_Interval
            // 
            this.num_Form_Frc_Interval.Location = new System.Drawing.Point(124, 87);
            this.num_Form_Frc_Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Frc_Interval.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Frc_Interval.Name = "num_Form_Frc_Interval";
            this.num_Form_Frc_Interval.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Frc_Interval.TabIndex = 4;
            this.num_Form_Frc_Interval.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_Form_Frc_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Form_Frc_Maximum
            // 
            this.num_Form_Frc_Maximum.Location = new System.Drawing.Point(124, 54);
            this.num_Form_Frc_Maximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Frc_Maximum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Frc_Maximum.Name = "num_Form_Frc_Maximum";
            this.num_Form_Frc_Maximum.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Frc_Maximum.TabIndex = 3;
            this.num_Form_Frc_Maximum.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            this.num_Form_Frc_Maximum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Form_Frc_Minimum
            // 
            this.num_Form_Frc_Minimum.Location = new System.Drawing.Point(124, 21);
            this.num_Form_Frc_Minimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Frc_Minimum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Frc_Minimum.Name = "num_Form_Frc_Minimum";
            this.num_Form_Frc_Minimum.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Frc_Minimum.TabIndex = 2;
            this.num_Form_Frc_Minimum.Value = new decimal(new int[] {
            400,
            0,
            0,
            -2147483648});
            this.num_Form_Frc_Minimum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Minimum :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_Form_Pos_Interval);
            this.groupBox1.Controls.Add(this.num_Form_Pos_Maximum);
            this.groupBox1.Controls.Add(this.num_Form_Pos_Minimum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X 축 (deg)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Form_Pos_Interval
            // 
            this.num_Form_Pos_Interval.Location = new System.Drawing.Point(124, 87);
            this.num_Form_Pos_Interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Pos_Interval.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Pos_Interval.Name = "num_Form_Pos_Interval";
            this.num_Form_Pos_Interval.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Pos_Interval.TabIndex = 4;
            this.num_Form_Pos_Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Form_Pos_Interval.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Form_Pos_Maximum
            // 
            this.num_Form_Pos_Maximum.Location = new System.Drawing.Point(124, 54);
            this.num_Form_Pos_Maximum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Pos_Maximum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Pos_Maximum.Name = "num_Form_Pos_Maximum";
            this.num_Form_Pos_Maximum.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Pos_Maximum.TabIndex = 3;
            this.num_Form_Pos_Maximum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.num_Form_Pos_Maximum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // num_Form_Pos_Minimum
            // 
            this.num_Form_Pos_Minimum.Location = new System.Drawing.Point(124, 21);
            this.num_Form_Pos_Minimum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Form_Pos_Minimum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.num_Form_Pos_Minimum.Name = "num_Form_Pos_Minimum";
            this.num_Form_Pos_Minimum.Size = new System.Drawing.Size(81, 27);
            this.num_Form_Pos_Minimum.TabIndex = 2;
            this.num_Form_Pos_Minimum.Value = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.num_Form_Pos_Minimum.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmFrcByPos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmFrcByPos";
            this.Text = "FrcByPos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFrcByPos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFrcByPos_FormClosed);
            this.Load += new System.EventHandler(this.FrmFrcByPos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ct_FrcByPos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Frc_Minimum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Form_Pos_Minimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ct_FrcByPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_Form_Pos_Minimum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Form_Pos_Interval;
        private System.Windows.Forms.NumericUpDown num_Form_Pos_Maximum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_Form_Frc_Interval;
        private System.Windows.Forms.NumericUpDown num_Form_Frc_Maximum;
        private System.Windows.Forms.NumericUpDown num_Form_Frc_Minimum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_Count;
    }
}