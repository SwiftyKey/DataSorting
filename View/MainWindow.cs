using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataSorting.Controllers;
using DataSorting.Models;

namespace DataSorting
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			this.comboBoxPDL.Items.Add("Fisk");
			this.comboBoxPDL.SelectedIndex = 0;
		}

		private void buttonGen_Click(object sender, EventArgs e)
		{
			ClearOutput();

			IPDL pdl = (IPDL)(Activator.CreateInstance(Type.GetType("DataSorting.Models." + comboBoxPDL.Text)));
			Dictionary<string, int> parameters = new Dictionary<string, int>() {
				{"A", int.Parse(textBoxA.Text)},
				{"B", int.Parse(textBoxB.Text)},
				{"C", int.Parse(textBoxC.Text)}
			};
			PDLController pdlController = new PDLController(pdl, parameters, 
															(int)numericUpDownN.Value);

			FillListView(listViewSourceArr, pdlController.pdl.arr);
			FillListView(listViewSortedArr, SortController.MergeSort(pdlController.pdl.arr));

			(int permutations, int comparisons, long time) = SortController.sort.indicators["MergeSort"];
			textBoxTime.Text = time.ToString();
			textBoxComparisons.Text = comparisons.ToString();
			textBoxPermutations.Text = permutations.ToString();
		}

		private void FillListView(ListView lv, float[] arr) {
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

		}

		private void buttonClear2_Click(object sender, EventArgs e)
		{

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

		private void ButtonGenEnabled () {
			buttonGen.Enabled = (textBoxA.Text != "" && textBoxB.Text != "" && textBoxC.Text != "");
		}
	}
}
