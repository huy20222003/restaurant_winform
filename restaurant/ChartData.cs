using restaurant.DAO;
using restaurant.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;

namespace restaurant
{
    public partial class Main
    {
        //--------------------------LINE CHART--------------------------------------------------------------------
        private void lineChart()
        {
            int currentMonth = DateTime.Now.Month; // Lấy tháng hiện tại
            int currentYear = DateTime.Now.Year;   // Lấy năm hiện tại
            DataTable billCountByDay = BillDAO.Instance.GetBillCountByDate(currentMonth, currentYear);
            ChartValues<string> dayValues = new ChartValues<string>();
            ChartValues<int> billCountValues = new ChartValues<int>();
            foreach (DataRow row in billCountByDay.Rows)
            {
                int dayOfMonth = Convert.ToInt32(row["DayOfMonth"]);
                string formattedDate = dayOfMonth.ToString("00") + "/" + currentMonth.ToString("00");
                dayValues.Add(formattedDate);
                billCountValues.Add(Convert.ToInt32(row["TotalBills"]));
            }
            billChart.AxisX.Clear();
            billChart.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = dayValues
            });

            BillSeries = new LineSeries
            {
                Title = "Số lượng hoá đơn",
                Values = billCountValues
            };

            billChart.Series = new SeriesCollection
            {
                BillSeries
            };
            billCountByDay?.Dispose();
        }

        public LineSeries BillSeries { get; set; }

        private void ToggleBillSeries(object sender, System.EventArgs e)
        {
            BillSeries.Visibility = BillSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        //-----------------------------PIE CHART-----------------------------------------------------------------
        private void pieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = BillDetailDAO.Instance.GetTop5Products();

            // Tạo các series cho biểu đồ và thêm dữ liệu từ DataTable
            SeriesCollection seriesCollection = new SeriesCollection();
            foreach (DataRow row in data.Rows)
            {
                string productId = row["productId"].ToString();
                Product product = ProductDAO.Instance.GetProductById(int.Parse(productId));
                string percentageString = row["Percentage"].ToString();
                double percentage = double.Parse(percentageString.Substring(0, Math.Min(percentageString.Length, 4)));


                PieSeries series = new PieSeries
                {
                    Title = product.Name,
                    Values = new ChartValues<double> { percentage },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };

                seriesCollection.Add(series);
            }

            // Cập nhật biểu đồ với các series mới
            productSelledTopChart.Series = seriesCollection;

            productSelledTopChart.LegendLocation = LegendLocation.Bottom;
            data?.Dispose();
        }

        private void DynamicVisibiltyExample()
        {

            MariaSeries = new LineSeries
            {
                Values = new ChartValues<double> { 4, 6, 2, 7, 6 }
            };
            CharlesSeries = new LineSeries
            {
                Values = new ChartValues<double> { 6, 2, 8, 3, 5 }
            };
            JohnSeries = new LineSeries
            {
                Values = new ChartValues<double> { 8, 2, 4, 7, 2 }
            };

            cartesianChart1.Series = new SeriesCollection
            {
                MariaSeries,
                CharlesSeries,
                JohnSeries
            };

        }

        public LineSeries MariaSeries { get; set; }
        public LineSeries CharlesSeries { get; set; }
        public LineSeries JohnSeries { get; set; }

        private void ToggleMariaSeries(object sender, System.EventArgs e)
        {
            MariaSeries.Visibility = MariaSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void ToggleCharlesSeries(object sender, System.EventArgs e)
        {
            CharlesSeries.Visibility = CharlesSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        private void ToggleJohnSeries(object sender, System.EventArgs e)
        {
            JohnSeries.Visibility = JohnSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }
    }
}
