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
    /// /// ���������������Ӧ��������ViewModel�ľ�̬���ò��ṩ�˰󶨵Ľ���㡣��
    /// 
    /// App.xaml�н�ViewModelLocator��Ϊ��Դ��ӵ���ȫ�ֵ�Application.Resources��
    /// 
    /// ��������У������ΪView����ViewModelʾ���Ĺ�����
    /// 
    /// ʹ��ViewModelLocator�ĺô���
    /// 1.View��ViewModel֮�䲻��ֱ�����ã�����ͨ��ViewModelLocator������
    /// 2.������ViewModelLocator���ViewModel�����뵥���Ĵ��ڣ�������ȫ�����ð󶨡�
    /// 3.������ĳЩ�����Ƶ������ViewModel��ȴδ������Դ�ͷ���ɵ��ڴ�й©����������˵����ViewModel������ŵ�ViewModelLocator�
    /// 
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);//��������������ǰʵ����ί��
            //Ϊ��ͳһ������������Ƶ�ʱ����Կ�������ViewModel�����ݣ������ServiceLocator �ֽ�SimpleIoc������һ�㡣

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
            ///ע��model
            SimpleIoc.Default.Register<MainViewModel>();//ע��MainViewModel
            SimpleIoc.Default.Register<WelcomeViewModel>();
            SimpleIoc.Default.Register<UserInfoViewModel>();
            SimpleIoc.Default.Register<DebugViewModel>();
            //SimpleIoc��ΪĬ�ϵķ����ṩ��,���Ǹ����׵�ע���ܡ�

            //
            //SimpleIoc:    һ���ǳ��򵥵�����ע�������� Ioc�����Ʒ�ת��
            //SimpleIoc.Default��    SimpleIoc��Ĭ��ʵ��

            //ʹ�÷�����
            //1.���Լ�����ע�ᵽSimpleIoc
            //  SimpleIoc.Default.Register(()=>new MyClass());
            //
            //2.��MainViewModelҲע�ᵽSimpleIoc
            //  SimpleIoc.Default.Register<MainViewModel>();
            //
            //3.��Main������ͨ��ServiceLocator.Current.GetInstance()������ȡʵ��
            //  public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
            //
            //4.��MainViewModel�Ĺ��캯����ƥ��MyClass��
            //  public MainViewModel(MyClass data)
            //  {
            //      WelcomeTitle = data.Name;
            //  }
        }

        /// <summary>
        /// ����modelʵ��
        /// </summary>
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();//��ȡMainViewModel��ʵ��(����ע��)
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