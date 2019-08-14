using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearRegression
{
	public partial class LinearRegressionForm : Form
	{
		public LinearRegressionForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ChartValues<ObservablePoint> values = new ChartValues<ObservablePoint>();
			int index = 0;
			double firstpoint = 0;
			double lastpoint = 0;
			foreach (var obj in data.Values)
			{
				statusText.Text += Environment.NewLine;
				statusText.Text += "[X = " + obj.X + ", Y = " + obj.Y + "] ";
				values.Add( new ObservablePoint() { X = obj.X, Y = obj.Y } );
				if(index == 0)
				{
					firstpoint = obj.Y;
				}
				if(index == data.Values.Count)
				{
					lastpoint = obj.Y;
				}
				index++;
			}
			cartesianChart1.Series = new SeriesCollection
			{
				new ScatterSeries
				{
					Title = "Input Values",
					Values = values
				},
				new LineSeries
				{
					Title = "Series 2",
					Values = new ChartValues<double> {firstpoint,lastpoint},
					PointGeometry = null
				}
			};
		}

		Func<ChartPoint, string> label = chartpoint => string.Format("{0}, ({1:P)", chartpoint.Y, chartpoint.X);

		private void Form1_Load(object sender, EventArgs e)
		{
			cartesianChart1.LegendLocation = LegendLocation.Bottom;
		}
	}
}
