using GetcuReone.MvvmFrame.Interfaces;
using System.Windows.Controls;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter.Empty
{
    /// <summary>
    /// Interaction logic for EmptyPage.xaml
    /// </summary>
    public partial class EmptyPage : Page, IPage
    {
        /// <inheritdoc/>
        public void InitializePageComponent<TViewModel>(TViewModel viewModel) where TViewModel : IViewModel
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
