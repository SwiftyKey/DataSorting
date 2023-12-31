﻿using System.Drawing;
using System.Windows.Forms;

namespace DataSorting
{
	partial class MainWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControlSorting = new System.Windows.Forms.TabControl();
			this.tabPageSorting = new System.Windows.Forms.TabPage();
			this.textBoxC = new System.Windows.Forms.TextBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonGen = new System.Windows.Forms.Button();
			this.textBoxPermutations = new System.Windows.Forms.TextBox();
			this.textBoxComparisons = new System.Windows.Forms.TextBox();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
			this.listViewSortedArr = new System.Windows.Forms.ListView();
			this.columnHeaderSAId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSAValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewSourceArr = new System.Windows.Forms.ListView();
			this.columnHeaderSrcId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSrcValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pictureBoxFx = new System.Windows.Forms.PictureBox();
			this.labelCountPermutations = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelSourceArr = new System.Windows.Forms.Label();
			this.labelCountComparisons = new System.Windows.Forms.Label();
			this.labelSortedArr = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelN = new System.Windows.Forms.Label();
			this.tabPageConEq = new System.Windows.Forms.TabPage();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonClear2 = new System.Windows.Forms.Button();
			this.buttonCalc = new System.Windows.Forms.Button();
			this.listViewSourceData = new System.Windows.Forms.ListView();
			this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderTimeY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSizeX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderXX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderXY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelConEq = new System.Windows.Forms.Label();
			this.textBoxBetaCoef = new System.Windows.Forms.TextBox();
			this.textBoxCoefCor = new System.Windows.Forms.TextBox();
			this.textBoxA1 = new System.Windows.Forms.TextBox();
			this.textBoxCoefDeterm = new System.Windows.Forms.TextBox();
			this.textBoxCoefEl = new System.Windows.Forms.TextBox();
			this.textBoxA0 = new System.Windows.Forms.TextBox();
			this.textBoxM = new System.Windows.Forms.TextBox();
			this.labelBetaCoef = new System.Windows.Forms.Label();
			this.labelCoefDeterm = new System.Windows.Forms.Label();
			this.labelCoefCor = new System.Windows.Forms.Label();
			this.labelA0 = new System.Windows.Forms.Label();
			this.labelA1 = new System.Windows.Forms.Label();
			this.labelCoef = new System.Windows.Forms.Label();
			this.labelCoefEl = new System.Windows.Forms.Label();
			this.labelSysEq = new System.Windows.Forms.Label();
			this.labelGraph = new System.Windows.Forms.Label();
			this.labelSourceData = new System.Windows.Forms.Label();
			this.labelM = new System.Windows.Forms.Label();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItemRef = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxPDL = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripComboBoxSort = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemUser = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemLogIn = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControlSorting.SuspendLayout();
			this.tabPageSorting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFx)).BeginInit();
			this.tabPageConEq.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlSorting
			// 
			this.tabControlSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSorting.Controls.Add(this.tabPageSorting);
			this.tabControlSorting.Controls.Add(this.tabPageConEq);
			this.tabControlSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tabControlSorting.Location = new System.Drawing.Point(2, 29);
			this.tabControlSorting.Name = "tabControlSorting";
			this.tabControlSorting.SelectedIndex = 0;
			this.tabControlSorting.Size = new System.Drawing.Size(985, 611);
			this.tabControlSorting.TabIndex = 1;
			// 
			// tabPageSorting
			// 
			this.tabPageSorting.BackColor = System.Drawing.Color.DarkGray;
			this.tabPageSorting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPageSorting.Controls.Add(this.textBoxC);
			this.tabPageSorting.Controls.Add(this.buttonClear);
			this.tabPageSorting.Controls.Add(this.buttonGen);
			this.tabPageSorting.Controls.Add(this.textBoxPermutations);
			this.tabPageSorting.Controls.Add(this.textBoxComparisons);
			this.tabPageSorting.Controls.Add(this.textBoxTime);
			this.tabPageSorting.Controls.Add(this.textBoxB);
			this.tabPageSorting.Controls.Add(this.textBoxA);
			this.tabPageSorting.Controls.Add(this.numericUpDownN);
			this.tabPageSorting.Controls.Add(this.listViewSortedArr);
			this.tabPageSorting.Controls.Add(this.listViewSourceArr);
			this.tabPageSorting.Controls.Add(this.pictureBoxFx);
			this.tabPageSorting.Controls.Add(this.labelCountPermutations);
			this.tabPageSorting.Controls.Add(this.labelC);
			this.tabPageSorting.Controls.Add(this.labelSourceArr);
			this.tabPageSorting.Controls.Add(this.labelCountComparisons);
			this.tabPageSorting.Controls.Add(this.labelSortedArr);
			this.tabPageSorting.Controls.Add(this.labelA);
			this.tabPageSorting.Controls.Add(this.labelTime);
			this.tabPageSorting.Controls.Add(this.labelB);
			this.tabPageSorting.Controls.Add(this.labelN);
			this.tabPageSorting.Location = new System.Drawing.Point(4, 29);
			this.tabPageSorting.Name = "tabPageSorting";
			this.tabPageSorting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSorting.Size = new System.Drawing.Size(977, 578);
			this.tabPageSorting.TabIndex = 0;
			this.tabPageSorting.Text = "Упорядочивание данных";
			// 
			// textBoxC
			// 
			this.textBoxC.BackColor = System.Drawing.Color.Silver;
			this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxC.Location = new System.Drawing.Point(156, 113);
			this.textBoxC.Name = "textBoxC";
			this.textBoxC.Size = new System.Drawing.Size(103, 26);
			this.textBoxC.TabIndex = 5;
			this.textBoxC.Text = "1";
			this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear.BackColor = System.Drawing.Color.Silver;
			this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.buttonClear.Location = new System.Drawing.Point(255, 518);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(93, 35);
			this.buttonClear.TabIndex = 8;
			this.buttonClear.Text = "Очистка";
			this.buttonClear.UseVisualStyleBackColor = false;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonGen
			// 
			this.buttonGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonGen.BackColor = System.Drawing.Color.DarkGray;
			this.buttonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.buttonGen.Location = new System.Drawing.Point(51, 518);
			this.buttonGen.Name = "buttonGen";
			this.buttonGen.Size = new System.Drawing.Size(150, 35);
			this.buttonGen.TabIndex = 7;
			this.buttonGen.Text = "Сгенерировать";
			this.buttonGen.UseVisualStyleBackColor = false;
			this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
			// 
			// textBoxPermutations
			// 
			this.textBoxPermutations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPermutations.BackColor = System.Drawing.Color.Silver;
			this.textBoxPermutations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPermutations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxPermutations.Location = new System.Drawing.Point(255, 445);
			this.textBoxPermutations.Name = "textBoxPermutations";
			this.textBoxPermutations.ReadOnly = true;
			this.textBoxPermutations.Size = new System.Drawing.Size(118, 26);
			this.textBoxPermutations.TabIndex = 49;
			this.textBoxPermutations.TabStop = false;
			// 
			// textBoxComparisons
			// 
			this.textBoxComparisons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxComparisons.BackColor = System.Drawing.Color.Silver;
			this.textBoxComparisons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxComparisons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxComparisons.Location = new System.Drawing.Point(255, 398);
			this.textBoxComparisons.Name = "textBoxComparisons";
			this.textBoxComparisons.ReadOnly = true;
			this.textBoxComparisons.Size = new System.Drawing.Size(118, 26);
			this.textBoxComparisons.TabIndex = 48;
			this.textBoxComparisons.TabStop = false;
			// 
			// textBoxTime
			// 
			this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTime.BackColor = System.Drawing.Color.Silver;
			this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxTime.Location = new System.Drawing.Point(255, 350);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.ReadOnly = true;
			this.textBoxTime.Size = new System.Drawing.Size(118, 26);
			this.textBoxTime.TabIndex = 50;
			this.textBoxTime.TabStop = false;
			// 
			// textBoxB
			// 
			this.textBoxB.BackColor = System.Drawing.Color.Silver;
			this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxB.Location = new System.Drawing.Point(156, 78);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(103, 26);
			this.textBoxB.TabIndex = 4;
			this.textBoxB.Text = "50";
			this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
			// 
			// textBoxA
			// 
			this.textBoxA.BackColor = System.Drawing.Color.Silver;
			this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxA.Location = new System.Drawing.Point(156, 47);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(103, 26);
			this.textBoxA.TabIndex = 3;
			this.textBoxA.Text = "1";
			this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
			// 
			// numericUpDownN
			// 
			this.numericUpDownN.BackColor = System.Drawing.Color.Silver;
			this.numericUpDownN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.numericUpDownN.Location = new System.Drawing.Point(156, 16);
			this.numericUpDownN.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.numericUpDownN.Minimum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
			this.numericUpDownN.Name = "numericUpDownN";
			this.numericUpDownN.Size = new System.Drawing.Size(103, 26);
			this.numericUpDownN.TabIndex = 2;
			this.numericUpDownN.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
			// 
			// listViewSortedArr
			// 
			this.listViewSortedArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewSortedArr.BackColor = System.Drawing.Color.LightGray;
			this.listViewSortedArr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSAId,
            this.columnHeaderSAValue});
			this.listViewSortedArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.listViewSortedArr.GridLines = true;
			this.listViewSortedArr.HideSelection = false;
			this.listViewSortedArr.Location = new System.Drawing.Point(687, 43);
			this.listViewSortedArr.Name = "listViewSortedArr";
			this.listViewSortedArr.Size = new System.Drawing.Size(268, 507);
			this.listViewSortedArr.TabIndex = 7;
			this.listViewSortedArr.TabStop = false;
			this.listViewSortedArr.UseCompatibleStateImageBehavior = false;
			this.listViewSortedArr.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderSAId
			// 
			this.columnHeaderSAId.Text = "Номер";
			this.columnHeaderSAId.Width = 80;
			// 
			// columnHeaderSAValue
			// 
			this.columnHeaderSAValue.Text = "Элемент";
			this.columnHeaderSAValue.Width = 120;
			// 
			// listViewSourceArr
			// 
			this.listViewSourceArr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.listViewSourceArr.BackColor = System.Drawing.Color.LightGray;
			this.listViewSourceArr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSrcId,
            this.columnHeaderSrcValue});
			this.listViewSourceArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.listViewSourceArr.GridLines = true;
			this.listViewSourceArr.HideSelection = false;
			this.listViewSourceArr.Location = new System.Drawing.Point(398, 46);
			this.listViewSourceArr.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.listViewSourceArr.Name = "listViewSourceArr";
			this.listViewSourceArr.Size = new System.Drawing.Size(268, 507);
			this.listViewSourceArr.TabIndex = 6;
			this.listViewSourceArr.TabStop = false;
			this.listViewSourceArr.UseCompatibleStateImageBehavior = false;
			this.listViewSourceArr.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderSrcId
			// 
			this.columnHeaderSrcId.Text = "Номер";
			this.columnHeaderSrcId.Width = 80;
			// 
			// columnHeaderSrcValue
			// 
			this.columnHeaderSrcValue.Text = "Элемент";
			this.columnHeaderSrcValue.Width = 120;
			// 
			// pictureBoxFx
			// 
			this.pictureBoxFx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBoxFx.Enabled = false;
			this.pictureBoxFx.Location = new System.Drawing.Point(68, 157);
			this.pictureBoxFx.Name = "pictureBoxFx";
			this.pictureBoxFx.Size = new System.Drawing.Size(258, 175);
			this.pictureBoxFx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxFx.TabIndex = 39;
			this.pictureBoxFx.TabStop = false;
			// 
			// labelCountPermutations
			// 
			this.labelCountPermutations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCountPermutations.AutoSize = true;
			this.labelCountPermutations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelCountPermutations.Location = new System.Drawing.Point(17, 448);
			this.labelCountPermutations.Name = "labelCountPermutations";
			this.labelCountPermutations.Size = new System.Drawing.Size(242, 20);
			this.labelCountPermutations.TabIndex = 37;
			this.labelCountPermutations.Text = "Количество перестановок=";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelC.Location = new System.Drawing.Point(133, 113);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(31, 20);
			this.labelC.TabIndex = 36;
			this.labelC.Text = "C=";
			// 
			// labelSourceArr
			// 
			this.labelSourceArr.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelSourceArr.AutoSize = true;
			this.labelSourceArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelSourceArr.Location = new System.Drawing.Point(450, 18);
			this.labelSourceArr.Name = "labelSourceArr";
			this.labelSourceArr.Size = new System.Drawing.Size(156, 20);
			this.labelSourceArr.TabIndex = 35;
			this.labelSourceArr.Text = "Исходный массив";
			// 
			// labelCountComparisons
			// 
			this.labelCountComparisons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCountComparisons.AutoSize = true;
			this.labelCountComparisons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelCountComparisons.Location = new System.Drawing.Point(46, 404);
			this.labelCountComparisons.Name = "labelCountComparisons";
			this.labelCountComparisons.Size = new System.Drawing.Size(213, 20);
			this.labelCountComparisons.TabIndex = 33;
			this.labelCountComparisons.Text = "Количество сравнений=";
			// 
			// labelSortedArr
			// 
			this.labelSortedArr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSortedArr.AutoSize = true;
			this.labelSortedArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelSortedArr.Location = new System.Drawing.Point(715, 18);
			this.labelSortedArr.Name = "labelSortedArr";
			this.labelSortedArr.Size = new System.Drawing.Size(209, 20);
			this.labelSortedArr.TabIndex = 31;
			this.labelSortedArr.Text = "Упорядоченный массив";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelA.Location = new System.Drawing.Point(133, 50);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(30, 20);
			this.labelA.TabIndex = 30;
			this.labelA.Text = "A=";
			// 
			// labelTime
			// 
			this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelTime.AutoSize = true;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelTime.Location = new System.Drawing.Point(187, 353);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(73, 20);
			this.labelTime.TabIndex = 29;
			this.labelTime.Text = "Время=";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelB.Location = new System.Drawing.Point(133, 80);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(31, 20);
			this.labelB.TabIndex = 28;
			this.labelB.Text = "B=";
			// 
			// labelN
			// 
			this.labelN.AutoSize = true;
			this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
			this.labelN.Location = new System.Drawing.Point(133, 18);
			this.labelN.Name = "labelN";
			this.labelN.Size = new System.Drawing.Size(31, 20);
			this.labelN.TabIndex = 26;
			this.labelN.Text = "N=";
			// 
			// tabPageConEq
			// 
			this.tabPageConEq.BackColor = System.Drawing.Color.DarkGray;
			this.tabPageConEq.Controls.Add(this.textBox8);
			this.tabPageConEq.Controls.Add(this.textBox7);
			this.tabPageConEq.Controls.Add(this.label7);
			this.tabPageConEq.Controls.Add(this.label6);
			this.tabPageConEq.Controls.Add(this.label5);
			this.tabPageConEq.Controls.Add(this.label4);
			this.tabPageConEq.Controls.Add(this.label3);
			this.tabPageConEq.Controls.Add(this.label2);
			this.tabPageConEq.Controls.Add(this.label1);
			this.tabPageConEq.Controls.Add(this.textBox6);
			this.tabPageConEq.Controls.Add(this.textBox5);
			this.tabPageConEq.Controls.Add(this.textBox4);
			this.tabPageConEq.Controls.Add(this.textBox3);
			this.tabPageConEq.Controls.Add(this.textBox2);
			this.tabPageConEq.Controls.Add(this.textBox1);
			this.tabPageConEq.Controls.Add(this.chart);
			this.tabPageConEq.Controls.Add(this.buttonClear2);
			this.tabPageConEq.Controls.Add(this.buttonCalc);
			this.tabPageConEq.Controls.Add(this.listViewSourceData);
			this.tabPageConEq.Controls.Add(this.labelConEq);
			this.tabPageConEq.Controls.Add(this.textBoxBetaCoef);
			this.tabPageConEq.Controls.Add(this.textBoxCoefCor);
			this.tabPageConEq.Controls.Add(this.textBoxA1);
			this.tabPageConEq.Controls.Add(this.textBoxCoefDeterm);
			this.tabPageConEq.Controls.Add(this.textBoxCoefEl);
			this.tabPageConEq.Controls.Add(this.textBoxA0);
			this.tabPageConEq.Controls.Add(this.textBoxM);
			this.tabPageConEq.Controls.Add(this.labelBetaCoef);
			this.tabPageConEq.Controls.Add(this.labelCoefDeterm);
			this.tabPageConEq.Controls.Add(this.labelCoefCor);
			this.tabPageConEq.Controls.Add(this.labelA0);
			this.tabPageConEq.Controls.Add(this.labelA1);
			this.tabPageConEq.Controls.Add(this.labelCoef);
			this.tabPageConEq.Controls.Add(this.labelCoefEl);
			this.tabPageConEq.Controls.Add(this.labelSysEq);
			this.tabPageConEq.Controls.Add(this.labelGraph);
			this.tabPageConEq.Controls.Add(this.labelSourceData);
			this.tabPageConEq.Controls.Add(this.labelM);
			this.tabPageConEq.Location = new System.Drawing.Point(4, 29);
			this.tabPageConEq.Name = "tabPageConEq";
			this.tabPageConEq.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageConEq.Size = new System.Drawing.Size(977, 578);
			this.tabPageConEq.TabIndex = 1;
			this.tabPageConEq.Text = "Уравнение связи";
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox8.BackColor = System.Drawing.Color.Silver;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(243, 381);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(135, 26);
			this.textBox8.TabIndex = 248;
			// 
			// textBox7
			// 
			this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox7.BackColor = System.Drawing.Color.Silver;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(76, 381);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(135, 26);
			this.textBox7.TabIndex = 247;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(380, 384);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 20);
			this.label7.TabIndex = 246;
			this.label7.Text = "x";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(217, 384);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 20);
			this.label6.TabIndex = 245;
			this.label6.Text = "+";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 20);
			this.label5.TabIndex = 244;
			this.label5.Text = "y =";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(269, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.TabIndex = 243;
			this.label4.Text = "a1 =";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(269, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 20);
			this.label3.TabIndex = 242;
			this.label3.Text = "a1 =";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(117, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 241;
			this.label2.Text = "a0 +";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.TabIndex = 240;
			this.label1.Text = "a0 +";
			// 
			// textBox6
			// 
			this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox6.BackColor = System.Drawing.Color.Silver;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(315, 277);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(100, 26);
			this.textBox6.TabIndex = 239;
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox5.BackColor = System.Drawing.Color.Silver;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(163, 277);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(100, 26);
			this.textBox5.TabIndex = 238;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox4.BackColor = System.Drawing.Color.Silver;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(11, 277);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(100, 26);
			this.textBox4.TabIndex = 237;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox3.BackColor = System.Drawing.Color.Silver;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(315, 245);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(100, 26);
			this.textBox3.TabIndex = 236;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox2.BackColor = System.Drawing.Color.Silver;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(163, 245);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(100, 26);
			this.textBox2.TabIndex = 235;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.BackColor = System.Drawing.Color.Silver;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(11, 245);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 234;
			// 
			// chart
			// 
			this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart.BackColor = System.Drawing.Color.LightGray;
			this.chart.BorderlineColor = System.Drawing.Color.DarkGray;
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			this.chart.Cursor = System.Windows.Forms.Cursors.Cross;
			legend1.BackColor = System.Drawing.Color.Silver;
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(449, 52);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
			series1.IsVisibleInLegend = false;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
			series2.IsVisibleInLegend = false;
			series2.Legend = "Legend1";
			series2.Name = "Series2";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series3.IsVisibleInLegend = false;
			series3.Legend = "Legend1";
			series3.Name = "Series3";
			this.chart.Series.Add(series1);
			this.chart.Series.Add(series2);
			this.chart.Series.Add(series3);
			this.chart.Size = new System.Drawing.Size(520, 514);
			this.chart.TabIndex = 233;
			this.chart.TabStop = false;
			// 
			// buttonClear2
			// 
			this.buttonClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear2.BackColor = System.Drawing.Color.Silver;
			this.buttonClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.buttonClear2.Location = new System.Drawing.Point(251, 538);
			this.buttonClear2.Name = "buttonClear2";
			this.buttonClear2.Size = new System.Drawing.Size(95, 27);
			this.buttonClear2.TabIndex = 3;
			this.buttonClear2.Text = "Очистка";
			this.buttonClear2.UseVisualStyleBackColor = false;
			this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
			// 
			// buttonCalc
			// 
			this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCalc.BackColor = System.Drawing.Color.DarkGray;
			this.buttonCalc.Enabled = false;
			this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.buttonCalc.Location = new System.Drawing.Point(82, 539);
			this.buttonCalc.Name = "buttonCalc";
			this.buttonCalc.Size = new System.Drawing.Size(88, 27);
			this.buttonCalc.TabIndex = 2;
			this.buttonCalc.Text = "Расчет";
			this.buttonCalc.UseVisualStyleBackColor = false;
			this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
			// 
			// listViewSourceData
			// 
			this.listViewSourceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listViewSourceData.BackColor = System.Drawing.Color.LightGray;
			this.listViewSourceData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewSourceData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderTimeY,
            this.columnHeaderSizeX,
            this.columnHeaderXX,
            this.columnHeaderXY});
			this.listViewSourceData.GridLines = true;
			this.listViewSourceData.HideSelection = false;
			this.listViewSourceData.Location = new System.Drawing.Point(25, 75);
			this.listViewSourceData.Name = "listViewSourceData";
			this.listViewSourceData.Size = new System.Drawing.Size(371, 144);
			this.listViewSourceData.TabIndex = 232;
			this.listViewSourceData.TabStop = false;
			this.listViewSourceData.UseCompatibleStateImageBehavior = false;
			this.listViewSourceData.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderId
			// 
			this.columnHeaderId.Text = "Номер";
			this.columnHeaderId.Width = 63;
			// 
			// columnHeaderTimeY
			// 
			this.columnHeaderTimeY.Text = "Время(y)";
			this.columnHeaderTimeY.Width = 80;
			// 
			// columnHeaderSizeX
			// 
			this.columnHeaderSizeX.Text = "Развер массива(x)";
			this.columnHeaderSizeX.Width = 150;
			// 
			// columnHeaderXX
			// 
			this.columnHeaderXX.Text = "x*x";
			this.columnHeaderXX.Width = 35;
			// 
			// columnHeaderXY
			// 
			this.columnHeaderXY.Text = "x*y";
			this.columnHeaderXY.Width = 35;
			// 
			// labelConEq
			// 
			this.labelConEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelConEq.AutoSize = true;
			this.labelConEq.Location = new System.Drawing.Point(143, 358);
			this.labelConEq.Name = "labelConEq";
			this.labelConEq.Size = new System.Drawing.Size(142, 20);
			this.labelConEq.TabIndex = 22;
			this.labelConEq.Text = "Уравнение связи:";
			// 
			// textBoxBetaCoef
			// 
			this.textBoxBetaCoef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxBetaCoef.BackColor = System.Drawing.Color.Silver;
			this.textBoxBetaCoef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxBetaCoef.Location = new System.Drawing.Point(293, 506);
			this.textBoxBetaCoef.Name = "textBoxBetaCoef";
			this.textBoxBetaCoef.ReadOnly = true;
			this.textBoxBetaCoef.Size = new System.Drawing.Size(86, 26);
			this.textBoxBetaCoef.TabIndex = 21;
			this.textBoxBetaCoef.TabStop = false;
			// 
			// textBoxCoefCor
			// 
			this.textBoxCoefCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxCoefCor.BackColor = System.Drawing.Color.Silver;
			this.textBoxCoefCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCoefCor.Location = new System.Drawing.Point(293, 419);
			this.textBoxCoefCor.Name = "textBoxCoefCor";
			this.textBoxCoefCor.ReadOnly = true;
			this.textBoxCoefCor.Size = new System.Drawing.Size(86, 26);
			this.textBoxCoefCor.TabIndex = 19;
			this.textBoxCoefCor.TabStop = false;
			// 
			// textBoxA1
			// 
			this.textBoxA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxA1.BackColor = System.Drawing.Color.Silver;
			this.textBoxA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxA1.Location = new System.Drawing.Point(244, 329);
			this.textBoxA1.Name = "textBoxA1";
			this.textBoxA1.ReadOnly = true;
			this.textBoxA1.Size = new System.Drawing.Size(102, 26);
			this.textBoxA1.TabIndex = 16;
			this.textBoxA1.TabStop = false;
			// 
			// textBoxCoefDeterm
			// 
			this.textBoxCoefDeterm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxCoefDeterm.BackColor = System.Drawing.Color.Silver;
			this.textBoxCoefDeterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCoefDeterm.Location = new System.Drawing.Point(293, 446);
			this.textBoxCoefDeterm.Name = "textBoxCoefDeterm";
			this.textBoxCoefDeterm.ReadOnly = true;
			this.textBoxCoefDeterm.Size = new System.Drawing.Size(86, 26);
			this.textBoxCoefDeterm.TabIndex = 15;
			this.textBoxCoefDeterm.TabStop = false;
			// 
			// textBoxCoefEl
			// 
			this.textBoxCoefEl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxCoefEl.BackColor = System.Drawing.Color.Silver;
			this.textBoxCoefEl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxCoefEl.Location = new System.Drawing.Point(293, 474);
			this.textBoxCoefEl.Name = "textBoxCoefEl";
			this.textBoxCoefEl.ReadOnly = true;
			this.textBoxCoefEl.Size = new System.Drawing.Size(86, 26);
			this.textBoxCoefEl.TabIndex = 14;
			this.textBoxCoefEl.TabStop = false;
			// 
			// textBoxA0
			// 
			this.textBoxA0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxA0.BackColor = System.Drawing.Color.Silver;
			this.textBoxA0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxA0.Location = new System.Drawing.Point(106, 329);
			this.textBoxA0.Name = "textBoxA0";
			this.textBoxA0.ReadOnly = true;
			this.textBoxA0.Size = new System.Drawing.Size(99, 26);
			this.textBoxA0.TabIndex = 13;
			this.textBoxA0.TabStop = false;
			// 
			// textBoxM
			// 
			this.textBoxM.BackColor = System.Drawing.Color.Silver;
			this.textBoxM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxM.Location = new System.Drawing.Point(244, 14);
			this.textBoxM.Name = "textBoxM";
			this.textBoxM.Size = new System.Drawing.Size(86, 26);
			this.textBoxM.TabIndex = 1;
			this.textBoxM.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
			// 
			// labelBetaCoef
			// 
			this.labelBetaCoef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelBetaCoef.AutoSize = true;
			this.labelBetaCoef.Location = new System.Drawing.Point(127, 509);
			this.labelBetaCoef.Name = "labelBetaCoef";
			this.labelBetaCoef.Size = new System.Drawing.Size(169, 20);
			this.labelBetaCoef.TabIndex = 11;
			this.labelBetaCoef.Text = "бета-коэффициент=";
			// 
			// labelCoefDeterm
			// 
			this.labelCoefDeterm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCoefDeterm.AutoSize = true;
			this.labelCoefDeterm.Location = new System.Drawing.Point(50, 451);
			this.labelCoefDeterm.Name = "labelCoefDeterm";
			this.labelCoefDeterm.Size = new System.Drawing.Size(246, 20);
			this.labelCoefDeterm.TabIndex = 9;
			this.labelCoefDeterm.Text = "Коэффициент детерминации=";
			// 
			// labelCoefCor
			// 
			this.labelCoefCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCoefCor.AutoSize = true;
			this.labelCoefCor.Location = new System.Drawing.Point(72, 423);
			this.labelCoefCor.Name = "labelCoefCor";
			this.labelCoefCor.Size = new System.Drawing.Size(224, 20);
			this.labelCoefCor.TabIndex = 8;
			this.labelCoefCor.Text = "Коэффициент корреляции=";
			// 
			// labelA0
			// 
			this.labelA0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelA0.AutoSize = true;
			this.labelA0.Location = new System.Drawing.Point(73, 332);
			this.labelA0.Name = "labelA0";
			this.labelA0.Size = new System.Drawing.Size(36, 20);
			this.labelA0.TabIndex = 7;
			this.labelA0.Text = "a0=";
			// 
			// labelA1
			// 
			this.labelA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelA1.AutoSize = true;
			this.labelA1.Location = new System.Drawing.Point(211, 332);
			this.labelA1.Name = "labelA1";
			this.labelA1.Size = new System.Drawing.Size(36, 20);
			this.labelA1.TabIndex = 6;
			this.labelA1.Text = "a1=";
			// 
			// labelCoef
			// 
			this.labelCoef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCoef.AutoSize = true;
			this.labelCoef.Location = new System.Drawing.Point(74, 306);
			this.labelCoef.Name = "labelCoef";
			this.labelCoef.Size = new System.Drawing.Size(262, 20);
			this.labelCoef.TabIndex = 5;
			this.labelCoef.Text = "Коэффициенты уравнения связи";
			// 
			// labelCoefEl
			// 
			this.labelCoefEl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCoefEl.AutoSize = true;
			this.labelCoefEl.Location = new System.Drawing.Point(55, 477);
			this.labelCoefEl.Name = "labelCoefEl";
			this.labelCoefEl.Size = new System.Drawing.Size(241, 20);
			this.labelCoefEl.TabIndex = 4;
			this.labelCoefEl.Text = "Коэффициент эластичности=";
			// 
			// labelSysEq
			// 
			this.labelSysEq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelSysEq.AutoSize = true;
			this.labelSysEq.Location = new System.Drawing.Point(74, 222);
			this.labelSysEq.Name = "labelSysEq";
			this.labelSysEq.Size = new System.Drawing.Size(255, 20);
			this.labelSysEq.TabIndex = 3;
			this.labelSysEq.Text = "Система нормальных уравнений";
			// 
			// labelGraph
			// 
			this.labelGraph.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelGraph.AutoSize = true;
			this.labelGraph.Location = new System.Drawing.Point(562, 14);
			this.labelGraph.Name = "labelGraph";
			this.labelGraph.Size = new System.Drawing.Size(352, 20);
			this.labelGraph.TabIndex = 2;
			this.labelGraph.Text = "Точечный график и график уравнения связи ";
			// 
			// labelSourceData
			// 
			this.labelSourceData.AutoSize = true;
			this.labelSourceData.Location = new System.Drawing.Point(74, 52);
			this.labelSourceData.Name = "labelSourceData";
			this.labelSourceData.Size = new System.Drawing.Size(272, 20);
			this.labelSourceData.TabIndex = 1;
			this.labelSourceData.Text = "Исходные статистические данные";
			// 
			// labelM
			// 
			this.labelM.AutoSize = true;
			this.labelM.Location = new System.Drawing.Point(84, 17);
			this.labelM.Name = "labelM";
			this.labelM.Size = new System.Drawing.Size(161, 20);
			this.labelM.TabIndex = 0;
			this.labelM.Text = "Объем выборки(M)=";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRef,
            this.toolStripComboBoxPDL,
            this.toolStripComboBoxSort});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(987, 32);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolStripMenuItemRef
			// 
			this.ToolStripMenuItemRef.Name = "ToolStripMenuItemRef";
			this.ToolStripMenuItemRef.Size = new System.Drawing.Size(85, 28);
			this.ToolStripMenuItemRef.Text = "Справка";
			this.ToolStripMenuItemRef.Click += new System.EventHandler(this.ToolStripMenuItemRef_Click);
			// 
			// toolStripComboBoxPDL
			// 
			this.toolStripComboBoxPDL.BackColor = System.Drawing.Color.DarkGray;
			this.toolStripComboBoxPDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxPDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripComboBoxPDL.Name = "toolStripComboBoxPDL";
			this.toolStripComboBoxPDL.Size = new System.Drawing.Size(121, 28);
			this.toolStripComboBoxPDL.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxPDL_SelectedIndexChanged);
			// 
			// toolStripComboBoxSort
			// 
			this.toolStripComboBoxSort.BackColor = System.Drawing.Color.DarkGray;
			this.toolStripComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripComboBoxSort.Name = "toolStripComboBoxSort";
			this.toolStripComboBoxSort.Size = new System.Drawing.Size(121, 28);
			// 
			// toolStripMenuItemUser
			// 
			this.toolStripMenuItemUser.Name = "toolStripMenuItemUser";
			this.toolStripMenuItemUser.Size = new System.Drawing.Size(32, 19);
			// 
			// ToolStripMenuItemLogIn
			// 
			this.ToolStripMenuItemLogIn.Name = "ToolStripMenuItemLogIn";
			this.ToolStripMenuItemLogIn.Size = new System.Drawing.Size(32, 19);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(987, 642);
			this.Controls.Add(this.tabControlSorting);
			this.Controls.Add(this.menuStrip1);
			this.Icon = global::DataSorting.Properties.Resources.Icon;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1003, 652);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataSorting";
			this.tabControlSorting.ResumeLayout(false);
			this.tabPageSorting.ResumeLayout(false);
			this.tabPageSorting.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFx)).EndInit();
			this.tabPageConEq.ResumeLayout(false);
			this.tabPageConEq.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TabControl tabControlSorting;
		private TabPage tabPageSorting;
		private TextBox textBoxPermutations;
		private TextBox textBoxComparisons;
		private TextBox textBoxTime;
		private TextBox textBoxB;
		private TextBox textBoxA;
		private NumericUpDown numericUpDownN;
		private ListView listViewSortedArr;
		private ColumnHeader columnHeaderSAId;
		private ColumnHeader columnHeaderSAValue;
		private ListView listViewSourceArr;
		private ColumnHeader columnHeaderSrcId;
		private ColumnHeader columnHeaderSrcValue;
		private PictureBox pictureBoxFx;
		private Label labelCountPermutations;
		private Label labelC;
		private Label labelSourceArr;
		private Label labelCountComparisons;
		private Label labelSortedArr;
		private Label labelA;
		private Label labelTime;
		private Label labelB;
		private Label labelN;
		private TabPage tabPageConEq;
		private Button buttonClear;
		private Button buttonGen;
		private Label labelBetaCoef;
		private Label labelCoefDeterm;
		private Label labelCoefCor;
		private Label labelA0;
		private Label labelA1;
		private Label labelCoef;
		private Label labelCoefEl;
		private Label labelSysEq;
		private Label labelGraph;
		private Label labelSourceData;
		private Label labelM;
		private TextBox textBoxBetaCoef;
		private TextBox textBoxCoefCor;
		private TextBox textBoxA1;
		private TextBox textBoxCoefDeterm;
		private TextBox textBoxCoefEl;
		private TextBox textBoxA0;
		private TextBox textBoxM;
		private Label labelConEq;
		private ListView listViewSourceData;
		private ColumnHeader columnHeaderId;
		private ColumnHeader columnHeaderTimeY;
		private ColumnHeader columnHeaderSizeX;
		private ColumnHeader columnHeaderXX;
		private ColumnHeader columnHeaderXY;
		private Button buttonClear2;
		private Button buttonCalc;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private TextBox textBoxC;
		private ToolStripMenuItem toolStripMenuItem1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItemUser;
		private ToolStripMenuItem ToolStripMenuItemLogIn;
		private ToolStripMenuItem выходToolStripMenuItem;
		private ToolStripComboBox toolStripComboBoxPDL;
		private ToolStripComboBox toolStripComboBoxSort;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox textBox6;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private TextBox textBox8;
		private TextBox textBox7;
		private Label label7;
		private Label label6;
		private Label label5;
		private ToolStripMenuItem ToolStripMenuItemRef;
	}
}