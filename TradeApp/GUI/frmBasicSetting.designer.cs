﻿namespace TheLast.GUI
{
    partial class frmBasicSetting
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
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nmADX = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nmRSI = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nmSignal = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nmLowMACD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmHighMACD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmEMA = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmMA = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCandleStick = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmADX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLowMACD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHighMACD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Location = new System.Drawing.Point(317, 379);
            this.btnOkAndSave.Name = "btnOkAndSave";
            this.btnOkAndSave.Size = new System.Drawing.Size(109, 32);
            this.btnOkAndSave.TabIndex = 11;
            this.btnOkAndSave.Text = "Lưu cấu hình";
            this.btnOkAndSave.Click += new System.EventHandler(this.btnOkAndSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nmADX);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.nmRSI);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.nmSignal);
            this.groupControl1.Controls.Add(this.nmEMA);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.nmMA);
            this.groupControl1.Controls.Add(this.nmHighMACD);
            this.groupControl1.Controls.Add(this.nmLowMACD);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.nmWeight);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cmbCandleStick);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cmbTimeZone);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 364);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Thiết lập";
            // 
            // nmADX
            // 
            this.nmADX.Location = new System.Drawing.Point(120, 281);
            this.nmADX.Name = "nmADX";
            this.nmADX.Size = new System.Drawing.Size(119, 21);
            this.nmADX.TabIndex = 23;
            this.nmADX.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "ADX";
            // 
            // nmRSI
            // 
            this.nmRSI.Location = new System.Drawing.Point(121, 240);
            this.nmRSI.Name = "nmRSI";
            this.nmRSI.Size = new System.Drawing.Size(119, 21);
            this.nmRSI.TabIndex = 21;
            this.nmRSI.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "RSI";
            // 
            // nmSignal
            // 
            this.nmSignal.Location = new System.Drawing.Point(452, 325);
            this.nmSignal.Name = "nmSignal";
            this.nmSignal.Size = new System.Drawing.Size(89, 21);
            this.nmSignal.TabIndex = 19;
            this.nmSignal.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Signal";
            // 
            // nmLowMACD
            // 
            this.nmLowMACD.Location = new System.Drawing.Point(292, 325);
            this.nmLowMACD.Name = "nmLowMACD";
            this.nmLowMACD.Size = new System.Drawing.Size(89, 21);
            this.nmLowMACD.TabIndex = 17;
            this.nmLowMACD.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Low";
            // 
            // nmHighMACD
            // 
            this.nmHighMACD.Location = new System.Drawing.Point(152, 325);
            this.nmHighMACD.Name = "nmHighMACD";
            this.nmHighMACD.Size = new System.Drawing.Size(89, 21);
            this.nmHighMACD.TabIndex = 15;
            this.nmHighMACD.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đường MACD";
            // 
            // nmEMA
            // 
            this.nmEMA.Location = new System.Drawing.Point(121, 201);
            this.nmEMA.Name = "nmEMA";
            this.nmEMA.Size = new System.Drawing.Size(120, 21);
            this.nmEMA.TabIndex = 12;
            this.nmEMA.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Đường EMA";
            // 
            // nmMA
            // 
            this.nmMA.Location = new System.Drawing.Point(120, 163);
            this.nmMA.Name = "nmMA";
            this.nmMA.Size = new System.Drawing.Size(120, 21);
            this.nmMA.TabIndex = 10;
            this.nmMA.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đường MA";
            // 
            // nmWeight
            // 
            this.nmWeight.Location = new System.Drawing.Point(121, 126);
            this.nmWeight.Name = "nmWeight";
            this.nmWeight.Size = new System.Drawing.Size(120, 21);
            this.nmWeight.TabIndex = 8;
            this.nmWeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "( phiên )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khối lượng";
            // 
            // cmbCandleStick
            // 
            this.cmbCandleStick.FormattingEnabled = true;
            this.cmbCandleStick.Location = new System.Drawing.Point(120, 90);
            this.cmbCandleStick.Name = "cmbCandleStick";
            this.cmbCandleStick.Size = new System.Drawing.Size(121, 21);
            this.cmbCandleStick.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nến";
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(120, 57);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(121, 21);
            this.cmbTimeZone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khung thời gian";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmBasicSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 425);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnOkAndSave);
            this.Name = "frmBasicSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập cơ bản";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmADX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLowMACD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHighMACD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCandleStick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmADX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmRSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmSignal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmLowMACD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmHighMACD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmEMA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmWeight;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}