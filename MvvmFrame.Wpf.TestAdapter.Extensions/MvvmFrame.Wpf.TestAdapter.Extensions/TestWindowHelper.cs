using GetcuReone.MvvmFrame.Wpf.TestAdapter.Entities;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Helpers;
using System.Windows.Controls;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter
{
    /// <summary>
    /// Helper for <see cref="TestWindow"/>.
    /// </summary>
    public static class TestWindowHelper
    {
        /// <summary>
        /// Run <see cref="TestWindow"/>.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="timeout"></param>
        public static void RunTestWindow<TIn, TOut>(this ThenBlock<TIn, TOut> thenBlock, int timeout)
        {
            thenBlock.Run<TestWindow>(window => window.FindChildByName<Frame>("mainFrame"), timeout);
        }

        /// <summary>
        /// Run <see cref="TestWindow"/>.
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="timeout"></param>
        public static void RunTestWindow<TIn, TOut>(this ThenAsyncBlock<TIn, TOut> thenBlock, int timeout)
        {
            thenBlock.Run<TestWindow>(window => window.FindChildByName<Frame>("mainFrame"), timeout);
        }
    }
}
