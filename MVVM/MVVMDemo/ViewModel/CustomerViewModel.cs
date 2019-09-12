//using MVVMDemo.Model;
using MVVMDemo.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVMDemo.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        public CustomerViewModel()
        {
            objCommand = new ButtonCommand();
            objCommand.ExecuteCommand = new Action<object>(Change);
        }
        private Customer obj = new Customer();
        public ButtonCommand objCommand { get; set; }
        public string TxtCustomerName
        {
            get => obj.CustomerName;
            set => obj.CustomerName = value;
        }
        public double TxtAmount
        {
            //get => Convert.ToInt32(obj.Amount);
            get => obj.Amount;
            //set => obj.Amount = value;
            set { obj.Amount = value; NotifyPropertyChanged("TxtAmount"); }
        }
        public string LblAmountColor
        {
            get
            {
                if (obj.Amount > 2000) return "Blue";
                else if (obj.Amount > 1500) return "Red";
                else return "Yellow";
            }
        }
        public bool IsMarried
        {
            get
            {
                if (obj.Married == "Married") return true;
                else return false;
            }
        }
        public int lblAge
        {
            get => obj.Age;
        }
        public void Change(object parameter)
        {
            TxtAmount += 100;
        }


        //-----------------------------------------------------------
        #region OnPropertyChanged
        protected void UpdateProper<T>(ref T properValue, T newValue, [CallerMemberName] string properName = "")
        {
            if (object.Equals(properValue, newValue))
                return;

            properValue = newValue;
            OnPropertyChanged(properName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
    public class ButtonCommand : ICommand
    {
        public Action<object> ExecuteCommand = null;
        public Func<object, bool> CanExecuteCommand = null;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteCommand != null)
            {
                return this.CanExecuteCommand(parameter);
            }
            else
            {
                return true;
            }
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteCommand != null)
            {
                this.ExecuteCommand(parameter);
            }
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
    //public class ButtonCommand : ICommand
    //{
    //    private Action WhattoExecute;
    //    private Func<bool> WhentoExecute;
    //    public ButtonCommand(Action What, Func<bool> When) // Point 1
    //    {
    //        WhattoExecute = What;
    //        WhentoExecute = When;
    //    }

    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter)
    //    {
    //        return WhentoExecute(); // Point 2
    //    }
    //    public void Execute(object parameter)
    //    {
    //        WhattoExecute(); // Point 3
    //    }
    //}

}
