using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMDemo.Model
{
    public class Customer
    {
        private string _customerName;
        private double _amount;
        private string _married;
        private int _age;

        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public string Married { get => _married; set => _married = value; }
        public int Age { get => _age; set => _age = value; }

        //public string CustomerName { get => _customerName; set => UpdateProper(ref _customerName,value); }
        //public double Amount { get => _amount; set => UpdateProper(ref _amount, value); }
        //public string Married { get => _married; set => UpdateProper(ref _married, value); }
        //public int Age { get => _age; set =>  UpdateProper(ref _age, value); }
        public void AddAmount(object parameter)
        {
            Age += 10;
        }
        public void SubAmount()
        {
            Amount -= 10;
        }
        public bool IsValid()
        {
            if (Amount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Customer()
        {
            CustomerName = "YAOZJ";
            Amount = 2234;
            Married = "Married";
            Age = 18;
        }
        
    
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
        #endregion
    }
}
