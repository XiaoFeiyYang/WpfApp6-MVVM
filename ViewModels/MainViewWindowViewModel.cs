using System;
using System.Collections.Generic;
using System.Text;
using WpfApp6_MVVM.Command;

namespace WpfApp6_MVVM.ViewModels
{
    class MainViewWindowViewModel:NotificationObject
    {
        private double input1;

        public double Input1
        {
            get { return input1; }
            set { input1 = value;
                this.RaisePropertyChanged("input1");
                }
        }

        private double input2;

        public double Input2
        {
            get { return input2; }
            set { input2 = value;
                this.RaisePropertyChanged("input2");
                }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { result = value;
                this.RaisePropertyChanged("result");
                }
        }

        public DelegateCommand AddCommand { get; set; }

        public void Add(object parameter)
        {
            this.Result = this.Input1 + this.Input2;
        }

        public MainViewWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(Add);
        }
    }
}
