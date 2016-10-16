using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionChartDemo.PageModels
{
    public class ChartPageModel:FreshMvvm.FreshBasePageModel
    {
        private string _title=string.Empty;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                RaisePropertyChanged("Title");
                _title = value;
            }
        }

        private string _chartTitle = string.Empty;

        public string ChartTitle
        {
            get
            {
                return _chartTitle;
            }
            set
            {
                _chartTitle = value;
                RaisePropertyChanged("ChartTitle");
            }
        }

        private ObservableCollection<ChartDataPoint> _highTemperature;

        public ObservableCollection<ChartDataPoint> HighTemperature {
            get
            {
                return _highTemperature;
            }
            set
            {
                _highTemperature = value;
                RaisePropertyChanged("HighTemperture");
            }
        }

        public ChartPageModel()
        {
            Title = "Chart Demo App";
            ChartTitle = "Weather Analysis " + DateTime.Now.ToString();
            HighTemperature = new ObservableCollection<ChartDataPoint>();
            HighTemperature.Add(new ChartDataPoint("Jan", 42));
            HighTemperature.Add(new ChartDataPoint("Feb", 44));
            HighTemperature.Add(new ChartDataPoint("Mar", 53));
            HighTemperature.Add(new ChartDataPoint("Apr", 64));
            HighTemperature.Add(new ChartDataPoint("May", 75));
            HighTemperature.Add(new ChartDataPoint("Jun", 83));
            HighTemperature.Add(new ChartDataPoint("Jul", 87));
            HighTemperature.Add(new ChartDataPoint("Aug", 84));
            HighTemperature.Add(new ChartDataPoint("Sep", 78));
            HighTemperature.Add(new ChartDataPoint("Oct", 67));
            HighTemperature.Add(new ChartDataPoint("Nov", 55));
            HighTemperature.Add(new ChartDataPoint("Dec", 45));
        }
    }
}
