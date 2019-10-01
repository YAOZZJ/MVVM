using GalaSoft.MvvmLight;   //最顶层的命名空间，包含了MvvmLight的主体,最核心的功能都在这里。
                            //1.ICleanup            接口。实现该接口的ViewModel需要在Cleanup方法中释放资源，特别是-=event
                            //2.ObservableObject    该类实现了INotifyPropertyChanged接口，定义了一个可通知的对象基类，供ViewModelBase继承
                            //3.ViewModelBase       继承自ObsevableObject,ICleanup。将作为MvvmLight框架下使用的ViewModel的基类。主要提供Set和RaisePropertyChanged供外部使用。同时会在Cleanup方法里，Unregister该实例的所有MvvmLight Messager（在GalaSoft.MvvmLight.Messaging命名空间内定义）

using GalaSoft.MvvmLight.Command;   //1.RelayCommand   提供了一个ICommand接口的实现
                                    //2.RelayCommand<T>   提供了ICommand接口的泛型实现

using GalaSoft.MvvmLight.Messaging; //消息类命名空间，提供全局的消息通知。

using GalaSoft.MvvmLight.Threading; //DispatcherHelper  非UI线程操作UI线程时用到的帮助类，已针对各平台不同的写法做了封装。

using GalaSoft.MvvmLight.Views; //和View结合较紧密，ViewModel通过依赖该命名空间下的类，来避免直接引用View,用以解耦代码对具体的平台的依赖。
                                //1.IDialogService      对系统弹框消息的抽象。针对具体平台会在GalaSoft.MvvmLight.Platform程序集里分别实现
                                //2.INavigationService  对页面导航的抽象，不同平台会有不同实现。
namespace MVVMLightDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}