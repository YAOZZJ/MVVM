using GalaSoft.MvvmLight;   //���������ռ䣬������MvvmLight������,����ĵĹ��ܶ������
                            //1.ICleanup            �ӿڡ�ʵ�ָýӿڵ�ViewModel��Ҫ��Cleanup�������ͷ���Դ���ر���-=event
                            //2.ObservableObject    ����ʵ����INotifyPropertyChanged�ӿڣ�������һ����֪ͨ�Ķ�����࣬��ViewModelBase�̳�
                            //3.ViewModelBase       �̳���ObsevableObject,ICleanup������ΪMvvmLight�����ʹ�õ�ViewModel�Ļ��ࡣ��Ҫ�ṩSet��RaisePropertyChanged���ⲿʹ�á�ͬʱ����Cleanup�����Unregister��ʵ��������MvvmLight Messager����GalaSoft.MvvmLight.Messaging�����ռ��ڶ��壩

using GalaSoft.MvvmLight.Command;   //1.RelayCommand   �ṩ��һ��ICommand�ӿڵ�ʵ��
                                    //2.RelayCommand<T>   �ṩ��ICommand�ӿڵķ���ʵ��

using GalaSoft.MvvmLight.Messaging; //��Ϣ�������ռ䣬�ṩȫ�ֵ���Ϣ֪ͨ��

using GalaSoft.MvvmLight.Threading; //DispatcherHelper  ��UI�̲߳���UI�߳�ʱ�õ��İ����࣬����Ը�ƽ̨��ͬ��д�����˷�װ��

using GalaSoft.MvvmLight.Views; //��View��ϽϽ��ܣ�ViewModelͨ�������������ռ��µ��࣬������ֱ������View,���Խ������Ծ����ƽ̨��������
                                //1.IDialogService      ��ϵͳ������Ϣ�ĳ�����Ծ���ƽ̨����GalaSoft.MvvmLight.Platform������ֱ�ʵ��
                                //2.INavigationService  ��ҳ�浼���ĳ��󣬲�ͬƽ̨���в�ͬʵ�֡�
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