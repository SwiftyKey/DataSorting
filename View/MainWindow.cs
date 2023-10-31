using System;
using System.Collections.Generic;
using System.Resources;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataSorting.Controllers;
using DataSorting.Models;
using System.Reflection;

namespace DataSorting
{
	public partial class MainWindow : Form
	{
		private PDLController pdlController;
		private SortController sortController;

		public MainWindow()
		{
			InitializeComponent();
			this.toolStripComboBoxPDL.Items.Add("Fisk");
			this.toolStripComboBoxPDL.SelectedIndex = 0;
			this.toolStripComboBoxSort.Items.Add("MergeSort");
			this.toolStripComboBoxSort.SelectedIndex = 0;
		}

		private void FillListView(ListView lv, float[] arr)
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

		private void ButtonGenEnabled()
		{
			buttonGen.Enabled = (textBoxA.Text != "" && textBoxB.Text != "" && textBoxC.Text != "");
		}

		private Object GetModel(string path, string name) {
			return Activator.CreateInstance(Type.GetType(path + name));
		}

		private void buttonGen_Click(object sender, EventArgs e)
		{
			ClearOutput();

			APDL pdl = (APDL)GetModel("DataSorting.Models.", toolStripComboBoxPDL.Text);
			var parameters = new Dictionary<string, float>() {
				{"A", float.Parse(textBoxA.Text)},
				{"B", float.Parse(textBoxB.Text)},
				{"C", float.Parse(textBoxC.Text)}
			};
			pdlController = new PDLController(pdl, parameters, (int)numericUpDownN.Value);

			ASort sort = (ASort)GetModel("DataSorting.Models.", toolStripComboBoxSort.Text);
			sortController = new SortController(sort);

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
			var m = int.Parse(textBoxM.Text);

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

		private void toolStripComboBoxPDL_SelectedIndexChanged(object sender, EventArgs e)
		{
			Type rt = typeof(DataSorting.Properties.Resources);
			PropertyInfo fp = rt.GetProperty(toolStripComboBoxPDL.Text, typeof(Bitmap));
			pictureBoxFx.Image = (Bitmap)fp.GetValue(new DataSorting.Properties.Resources());
		}

		private void labelM_Click(object sender, EventArgs e)
		{

		}
	}
}
