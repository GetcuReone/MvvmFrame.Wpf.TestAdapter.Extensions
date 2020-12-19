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
    }
}
