using GetcuReone.MvvmFrame.Wpf.TestAdapter.Empty;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Entities;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Controls;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter
{
    /// <summary>
    /// Base class for testing UI.
    /// </summary>
    public abstract class UiTestBase : FrameTestBase
    {
        /// <summary>
        /// Name sub frame.
        /// </summary>
        protected string SubFrameName => "subFrame";

        /// <summary>
        /// Setup veiw-model.
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="viewModel"></param>
        protected virtual void SetupViewModel<TViewModel>(TViewModel viewModel)
            where TViewModel : ViewModelBase
        {

        }

        /// <summary>
        /// Get sub frame.
        /// </summary>
        /// <returns></returns>
        protected virtual Frame GetSubFrame()
        {
            return CheckTypeAndGetPage<Page>().FindParentByType<TestWindow>().FindChildByName<Frame>(SubFrameName);
        }

        /// <summary>
        /// Check type and get page.
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        protected virtual TPage CheckTypeAndGetPageSubFrame<TPage>() where TPage : Page
        {
            var subFrmae = GetSubFrame();
            Assert.IsTrue(subFrmae.Content is TPage, $"subFrame not containe {typeof(TPage).Name}");
            return subFrmae.Content as TPage;
        }

        /// <summary>
        /// Return given block 'Create and show <see cref="EmptyViewModel"/>'.
        /// </summary>
        /// <returns></returns>
        protected GivenBlock<EmptyViewModel, EmptyViewModel> GivenShowEmptyPage()
        {
            return Given("Create view-model.", frame => ViewModelBase.CreateViewModel<EmptyViewModel>(frame))
                .And("Navigate page.", viewModel =>
                {
                    var nResult = ViewModelBase.Navigate<EmptyPage>(viewModel);
                    Assert.IsTrue(nResult.IsNavigate, "Navigation failed.");
                    return viewModel;
                })
                .AndWait(100)
                .And("Setup view-model.", viewModel => 
                {
                    SetupViewModel(viewModel);
                    return viewModel;
                });
        }
    }
}
