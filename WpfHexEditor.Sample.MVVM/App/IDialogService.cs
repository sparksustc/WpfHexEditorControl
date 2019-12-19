using WpfHexEditor.Sample.MVVM.Contracts.Common;

namespace WpfHexEditor.Sample.MVVM.Contracts.App {
    /// <summary>
    /// This is interface is designed to make the project more friendly for unit test.
    /// </summary>
    public interface IDialogService {
        string OpenFile();
    }

    public class DialogService:GenericServiceStaticInstance<IDialogService> {
    }

}
