using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Mvvm;

namespace WpfApp1
{
    public class MainVm : BaseVm
    {
        public MainVm()
        {
            var model = new MainModel();
            Types = model.GetTypes();
            TestCommand = new RelayCommand(Test);
        }

        public List<string> Types { get; set; }
        public string Type { get; set; }
        public double Slope { get; set; }
        public double VerticalSlope { get; set; }
        public double HorizontalSlope { get; set; }
        public ICommand TestCommand { get; set; }
        
        private void Test(object obj)
        {
            MessageBox.Show(
                $"Type={Type}\nSlope={Slope}\nVerticalSlope={VerticalSlope}\nHorizontalSlope={HorizontalSlope}");
        }
    }
}