﻿using System;
using System.Collections.Generic;
using System.Resources;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using DataSorting.Controllers;

namespace DataSorting
{
	public partial class MainWindow : Form
	{
		private PDLController pdlController;
		private SortController sortController;
		private ExcerptController excerptController;

		public MainWindow()
		{
			InitializeComponent();
			this.toolStripComboBoxPDL.Items.Add("Fisk");
			this.toolStripComboBoxPDL.SelectedIndex = 0;
			this.toolStripComboBoxSort.Items.Add("MergeSort");
			this.toolStripComboBoxSort.SelectedIndex = 0;
		}

		private void FillListView(ListView lv, double[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
				lv.Items.Add(new ListViewItem(new[] { (i + 1).ToString(), arr[i].ToString() }));
		}

		private void ClearOutput()
		{
			textBoxTime.Clear();
			textBoxComparisons.Clear();
			textBoxPermutations.Clear();
			listViewSourceArr.Items.Clear();
			listViewSortedArr.Items.Clear();
		}

		private void ClearOutput2()
		{
			textBoxA0.Clear();
			textBoxA1.Clear();
			textBoxCoefCor.Clear();
			textBoxCoefDeterm.Clear();
			textBoxCoefEl.Clear();
			textBoxBetaCoef.Clear();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			listViewSourceData.Items.Clear();
			for (int i = 0; i < chart.Series.Count; i++)
				chart.Series[i].Points.Clear();
		}

		private void ButtonGenEnabled()
		{
			buttonGen.Enabled = (textBoxA.Text != "" && textBoxB.Text != "" && textBoxC.Text != "");
		}

		private Object GetModel(string path, string name) {
			return Activator.CreateInstance(Type.GetType(path + name));
		}

		private void ShowError(string message)
		{
			MessageBox.Show(
				message,
				"Ошибка",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
				);
		}

		private void buttonGen_Click(object sender, EventArgs e)
		{
			ClearOutput();

			double a, b, c;
			if (!double.TryParse(textBoxA.Text, out a))
			{
				ShowError("Неверный ввод параметра A");
				return;
			}
			if (!double.TryParse(textBoxB.Text, out b))
			{
				ShowError("Неверный ввод параметра B");
				return;
			}
			if (!double.TryParse(textBoxC.Text, out c))
			{
				ShowError("Неверный ввод параметра C");
				return;
			}

			var parameters = new Dictionary<string, double>() {
				{"A", a},
				{"B", b},
				{"C", c}
			};

			try
			{
				pdlController = new PDLController(GetModel("DataSorting.Models.", toolStripComboBoxPDL.Text), 
				parameters, (int)numericUpDownN.Value);
			}
			catch (ArgumentException ae)
			{
				ShowError(ae.Message);
				return;
			}
			
			sortController = new SortController(GetModel("DataSorting.Models.", toolStripComboBoxSort.Text));

			FillListView(listViewSourceArr, pdlController.PDL.arr);
			FillListView(listViewSortedArr, sortController.Sort.Sort(pdlController.PDL.arr));

			(int permutations, int comparisons, long time) = sortController.Sort.Indicators;
			textBoxTime.Text = time.ToString();
			textBoxComparisons.Text = comparisons.ToString();
			textBoxPermutations.Text = permutations.ToString();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			ClearOutput();
			numericUpDownN.Value = numericUpDownN.Minimum;
			textBoxA.Clear();
			textBoxB.Clear();
			textBoxC.Clear();
		}

		private void buttonCalc_Click(object sender, EventArgs e)
		{
			ClearOutput2();

			if (pdlController == null)
				pdlController = new PDLController(GetModel("DataSorting.Models.", toolStripComboBoxPDL.Text));
			if (sortController == null)
				sortController = new SortController(GetModel("DataSorting.Models.", toolStripComboBoxSort.Text));

			int m;
			if (!int.TryParse(textBoxM.Text, out m))
			{
				ShowError("Неверный ввод объема выборки M");
				return;
			}
			if (m <= 1)
			{
				ShowError("Объем выборки M должен быть > 1");
				return;
			}

			excerptController = new ExcerptController(m, pdlController, sortController);
			excerptController.Excerpt.Calculate();

			for (int i = 0; i < excerptController.Excerpt.M; i++)
				listViewSourceData.Items.Add(new ListViewItem(new[] { (i + 1).ToString(), 
				excerptController.Excerpt.Arr[i, 0].ToString(),
				excerptController.Excerpt.Arr[i, 1].ToString(),
				excerptController.Excerpt.Arr[i, 2].ToString(),
				excerptController.Excerpt.Arr[i, 3].ToString() }));

			textBoxA0.Text = excerptController.Excerpt.A0.ToString();
			textBoxA1.Text = excerptController.Excerpt.A1.ToString();
			textBoxCoefCor.Text = excerptController.Excerpt.CoefCor.ToString();
			textBoxCoefDeterm.Text = excerptController.Excerpt.CoefDeterm.ToString();
			textBoxCoefEl.Text = excerptController.Excerpt.CoefEl.ToString();
			textBoxBetaCoef.Text = excerptController.Excerpt.BetaCoef.ToString();
			textBox1.Text = excerptController.Excerpt.M.ToString();
			textBox2.Text = excerptController.Excerpt.Equations[0][1].ToString();
			textBox3.Text = excerptController.Excerpt.Equations[0][2].ToString();
			textBox4.Text = excerptController.Excerpt.Equations[1][0].ToString();
			textBox5.Text = excerptController.Excerpt.Equations[1][1].ToString();
			textBox6.Text = excerptController.Excerpt.Equations[1][2].ToString();
			textBox7.Text = excerptController.Excerpt.A0.ToString();
			textBox8.Text = excerptController.Excerpt.A1.ToString();

			DrawChart();
		}

		private void DrawChart()
		{
			double minValueX = 50000, maxValueX = 9000;
			double minValueY = 1500, maxValueY = 0;

			for (int i = 0; i < excerptController.Excerpt.M; i++)
			{
				if (excerptController.Excerpt.Arr[i, 1] < minValueX)
					minValueX = excerptController.Excerpt.Arr[i, 1];
				if (excerptController.Excerpt.Arr[i, 1] > maxValueX)
					maxValueX = excerptController.Excerpt.Arr[i, 1];
				if (excerptController.Excerpt.Arr[i, 0] < minValueY)
					minValueY = excerptController.Excerpt.Arr[i, 0];
				if (excerptController.Excerpt.Arr[i, 0] > maxValueY)
					maxValueY = excerptController.Excerpt.Arr[i, 0];
			}

			chart.ChartAreas[0].AxisX.Minimum = minValueX;
			chart.ChartAreas[0].AxisX.Maximum = maxValueX;
			chart.ChartAreas[0].AxisY.Minimum = minValueY;
			chart.ChartAreas[0].AxisY.Maximum = maxValueY;

			for (int i = 0; i < excerptController.Excerpt.M; i++)
			{
				chart.Series[0].Points.AddXY(excerptController.Excerpt.Arr[i, 1], excerptController.Excerpt.Arr[i, 0]);
				chart.Series[1].Points.AddXY(excerptController.Excerpt.Arr[i, 1],
				excerptController.Excerpt.A0 + excerptController.Excerpt.A1 * excerptController.Excerpt.Arr[i, 1]);
			}
		}

		private void buttonClear2_Click(object sender, EventArgs e)
		{
			textBoxM.Clear();
			ClearOutput2();
		}

		private void ToolStripMenuItemSignIn_Click(object sender, EventArgs e)
		{

		}

		private void ToolStripLogOut_Click(object sender, EventArgs e)
		{

		}

		private void textBoxA_TextChanged(object sender, EventArgs e) => ButtonGenEnabled();

		private void textBoxB_TextChanged(object sender, EventArgs e) => ButtonGenEnabled();

		private void textBoxC_TextChanged(object sender, EventArgs e) => ButtonGenEnabled();

		private void toolStripComboBoxPDL_SelectedIndexChanged(object sender, EventArgs e)
		{
			Type rt = typeof(DataSorting.Properties.Resources);
			PropertyInfo fp = rt.GetProperty(toolStripComboBoxPDL.Text, typeof(Bitmap));
			pictureBoxFx.Image = (Bitmap)fp.GetValue(new DataSorting.Properties.Resources());
		}

		private void textBoxM_TextChanged(object sender, EventArgs e)
		{
			buttonCalc.Enabled = (textBoxM.Text != "");
		}
	}
}
