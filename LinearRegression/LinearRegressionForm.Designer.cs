namespace LinearRegression
{
	partial class LinearRegressionForm
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.data = new LinearRegression.Data();
			this.button1 = new System.Windows.Forms.Button();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.statusText = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.valuesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.valuesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(540, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(248, 396);
			this.dataGridView1.TabIndex = 0;
			// 
			// xDataGridViewTextBoxColumn
			// 
			this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
			this.xDataGridViewTextBoxColumn.HeaderText = "X";
			this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
			// 
			// yDataGridViewTextBoxColumn
			// 
			this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
			this.yDataGridViewTextBoxColumn.HeaderText = "Y";
			this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
			// 
			// valuesBindingSource
			// 
			this.valuesBindingSource.DataMember = "Values";
			this.valuesBindingSource.DataSource = this.data;
			// 
			// data
			// 
			this.data.DataSetName = "Data";
			this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(713, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Best Fit Line";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Location = new System.Drawing.Point(13, 13);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(521, 396);
			this.cartesianChart1.TabIndex = 2;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// statusText
			// 
			this.statusText.Location = new System.Drawing.Point(13, 418);
			this.statusText.Name = "statusText";
			this.statusText.Size = new System.Drawing.Size(694, 20);
			this.statusText.TabIndex = 3;
			// 
			// LinearRegressionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusText);
			this.Controls.Add(this.cartesianChart1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "LinearRegressionForm";
			this.Text = "Linear Regression Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.valuesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource valuesBindingSource;
		private Data data;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.TextBox statusText;
	}
}

