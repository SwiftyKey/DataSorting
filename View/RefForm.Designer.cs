namespace DataSorting.View
{
	partial class RefForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSorting = new System.Windows.Forms.TabPage();
			this.tabPageLSM = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageSorting.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSorting);
			this.tabControl1.Controls.Add(this.tabPageLSM);
			this.tabControl1.Location = new System.Drawing.Point(0, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(946, 519);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageSorting
			// 
			this.tabPageSorting.BackColor = System.Drawing.Color.DarkGray;
			this.tabPageSorting.Controls.Add(this.label2);
			this.tabPageSorting.Controls.Add(this.label1);
			this.tabPageSorting.Location = new System.Drawing.Point(4, 29);
			this.tabPageSorting.Name = "tabPageSorting";
			this.tabPageSorting.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSorting.Size = new System.Drawing.Size(938, 486);
			this.tabPageSorting.TabIndex = 1;
			this.tabPageSorting.Text = "Упорядочивание данных";
			// 
			// tabPageLSM
			// 
			this.tabPageLSM.BackColor = System.Drawing.Color.DarkGray;
			this.tabPageLSM.Location = new System.Drawing.Point(4, 29);
			this.tabPageLSM.Name = "tabPageLSM";
			this.tabPageLSM.Size = new System.Drawing.Size(938, 486);
			this.tabPageLSM.TabIndex = 2;
			this.tabPageLSM.Text = "МНК";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.label1.Location = new System.Drawing.Point(258, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Алгоритм сортировки слиянием";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(38, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(863, 280);
			this.label2.TabIndex = 1;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// RefForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(945, 521);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "RefForm";
			this.Text = "RefForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPageSorting.ResumeLayout(false);
			this.tabPageSorting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSorting;
		private System.Windows.Forms.TabPage tabPageLSM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}