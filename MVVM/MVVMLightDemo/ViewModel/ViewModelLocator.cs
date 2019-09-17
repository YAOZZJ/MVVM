/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MVVMLightDemo"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using System.Data.Services;
//using Microsoft.Practices.ServiceLocation;

namespace MVVMLightDemo.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    /// /// （这个类包含了这个应用中所有ViewModel的静态引用并提供了绑定的进入点。）
    /// 
    /// App.xaml中将ViewModelLocator作为资源添加到了全局的Application.Resources里
    /// 
    /// 在这个类中，完成了为View创建ViewModel示例的工作。
    /// 
    /// 使用ViewModelLocator的好处：
    /// 1.View和ViewModel之间不再直接引用，而是通过ViewModelLocator关联。
    /// 2.储存在ViewModelLocator里的ViewModel类似与单例的存在，可以在全局引用绑定。
    /// 3.避免了某些情况下频繁创建ViewModel，却未做好资源释放造成的内存泄漏。（并不是说所有ViewModel都必须放到ViewModelLocator里）
    /// 
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);//设置用来检索当前实例的委托
            //为了统一化，并且在设计的时候可以看到看到ViewModel的数据，这边用ServiceLocator 又将SimpleIoc包裹了一层。

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
            ///注入model
            SimpleIoc.Default.Register<MainViewModel>();//注册MainViewModel
            SimpleIoc.Default.Register<WelcomeViewModel>();
            SimpleIoc.Default.Register<UserInfoViewModel>();
            SimpleIoc.Default.Register<DebugViewModel>();
            //SimpleIoc作为默认的服务提供者,它是个简易的注入框架。

            //
            //SimpleIoc:    一个非常简单的依赖注入容器。 Ioc（控制反转）
            //SimpleIoc.Default：    SimpleIoc的默认实例

            //使用方法：
            //1.将自己的类注册到SimpleIoc
            //  SimpleIoc.Default.Register(()=>new MyClass());
            //
            //2.把MainViewModel也注册到SimpleIoc
            //  SimpleIoc.Default.Register<MainViewModel>();
            //
            //3.在Main属性中通过ServiceLocator.Current.GetInstance()方法获取实例
            //  public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
            //
            //4.在MainViewModel的构造函数中匹配MyClass类
            //  public MainViewModel(MyClass data)
            //  {
            //      WelcomeTitle = data.Name;
            //  }
        }

        /// <summary>
        /// 返回model实例
        /// </summary>
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();//获取MainViewModel的实例(依赖注入)
                //public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public WelcomeViewModel Welcome
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WelcomeViewModel>();
            }
        }
        public UserInfoViewModel UserInfo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UserInfoViewModel>();
            }
        }
        public DebugViewModel Debug
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DebugViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}