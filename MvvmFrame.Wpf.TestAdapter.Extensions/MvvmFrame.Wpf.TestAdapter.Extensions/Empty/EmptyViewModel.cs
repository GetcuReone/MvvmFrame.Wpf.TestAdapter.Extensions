using GetcuReone.MvvmFrame.Wpf.EventArgs;
using System.Threading.Tasks;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter.Empty
{
    /// <summary>
    /// Empty view-model.
    /// </summary>
    public sealed class EmptyViewModel : ViewModelBase
    {
        /// <inheritdoc/>
        protected override void Initialize()
        {

        }

        /// <inheritdoc/>
        protected override ValueTask OnGoPageAsync(object navigateParam)
        {
            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLeavePageAsync(NavigatingEventArgs args)
        {
            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLoadPageAsync()
        {
            return default;
        }
    }
}
