using GetcuReone.MvvmFrame.Wpf.Entities;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Empty;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Entities;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Controls;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter
{
    /// <summary>
    /// Helper for UI test.
    /// </summary>
    public static class UiTestHelper
    {
        /// <summary>
        /// Check type and get data context.
        /// </summary>
        /// <typeparam name="TDataContext"></typeparam>
        /// <param name="page"></param>
        /// <returns></returns>
        public static TDataContext CheckTypeAndDataContext<TDataContext>(this Page page)
        {
            if (page.DataContext is TDataContext dataContext)
                return dataContext;

            Assert.IsNotNull(page.DataContext, "DataContext is null.");
            Assert.Fail($"DataContext has type {page.DataContext.GetType().Name}. Expected<{typeof(TDataContext).Name}>.");
            return default;
        }

        /// <summary>
        /// Navigate empty page.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="navigationParam"></param>
        /// <returns></returns>
        public static GivenBlock<NavigateResult<ViewModelBase>, TViewModel> AndNavigateEmptyPage<TIn, TViewModel>(this GivenBlock<TIn, TViewModel> givenBlock, object navigationParam = null)
            where TViewModel : ViewModelBase
        {
            return givenBlock.And("Navigate empty page.", viewModel => ViewModelBase.Navigate<EmptyPage>(viewModel, navigationParam))
                .AndIsTrue(nResult => nResult.IsNavigate)
                .AndWait(1000)
                .And("Get view-model.", nResult => (TViewModel)nResult.ViewModel);
        }

        /// <summary>
        /// Navigate empty page.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="navigationParam"></param>
        /// <returns></returns>
        public static GivenBlock<NavigateResult<ViewModelBase>, TViewModel> AndNavigateEmptyPage<TIn, TViewModel>(this GivenAsyncBlock<TIn, TViewModel> givenBlock, object navigationParam = null)
            where TViewModel : ViewModelBase
        {
            return givenBlock.And("Navigate empty page.", viewModel => ViewModelBase.Navigate<EmptyPage>(viewModel, navigationParam))
                .AndIsTrue(nResult => nResult.IsNavigate)
                .AndWait(1000)
                .And("Get view-model.", nResult => (TViewModel)nResult.ViewModel);
        }

        /// <summary>
        /// Navigate empty page.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="navigationParam"></param>
        /// <returns></returns>
        public static ThenBlock<NavigateResult<ViewModelBase>, TViewModel> AndNavigateEmptyPage<TIn, TViewModel>(this ThenBlock<TIn, TViewModel> thenBlock, object navigationParam = null)
            where TViewModel : ViewModelBase
        {
            return thenBlock.And("Navigate empty page.", viewModel => ViewModelBase.Navigate<EmptyPage>(viewModel, navigationParam))
                .AndIsTrue(nResult => nResult.IsNavigate)
                .AndWait(1000)
                .And("Get view-model.", nResult => (TViewModel)nResult.ViewModel);
        }

        /// <summary>
        /// Navigate empty page.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="navigationParam"></param>
        /// <returns></returns>
        public static ThenBlock<NavigateResult<ViewModelBase>, TViewModel> AndNavigateEmptyPage<TIn, TViewModel>(this ThenAsyncBlock<TIn, TViewModel> givenBlock, object navigationParam = null)
            where TViewModel : ViewModelBase
        {
            return givenBlock.And("Navigate empty page.", viewModel => ViewModelBase.Navigate<EmptyPage>(viewModel, navigationParam))
                .AndIsTrue(nResult => nResult.IsNavigate)
                .AndWait(1000)
                .And("Get view-model.", nResult => (TViewModel)nResult.ViewModel);
        }
    }
}
