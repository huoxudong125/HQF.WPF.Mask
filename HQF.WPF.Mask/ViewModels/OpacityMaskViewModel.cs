using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HQF.WPF.Mask.ViewModels
{
    public class OpacityMaskViewModel : BindableBase
    {
        private DispatcherTimer _timer=new DispatcherTimer();
        private HashSet<int> rectRecords=new HashSet<int>();
        public ObservableCollection<Rect> Rectangles { get; set; }

        private  Random random=new Random();

        public OpacityMaskViewModel()
        {
            Rectangles= new ObservableCollection<Rect>();
            _timer.Interval = TimeSpan.FromMilliseconds(50); //每秒执行一次
            _timer.Tick += Timer_Tick;
            _timer.Start();

           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rectRecords.Count<100)
            {
                var index = random.Next(0, 100);
                if (!rectRecords.Contains(index))
                {
                    rectRecords.Add(index);
                    var rect = new Rect() {X= index%10, Y = Math.Floor(index/10.0),  Width = 1 ,Height = 1};
                    Rectangles.Add(rect);
                    Console.WriteLine(index);
                }
            }
            else
            {
                rectRecords.Clear();
                Rectangles.Clear();
            }
        }
    }
}
