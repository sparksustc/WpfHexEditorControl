using WpfHexEditor.Sample.MVVM.Contracts.Common;

namespace WpfHexEditor.Sample.MVVM.Contracts.ToolTip {
    public interface IToolTipItemFactory {
        IToolTipDataItem CreateToolTipDataItem();
        IToolTipObjectItem CreateToolTipObjectItem();
    }
    public class ToolTipItemFactory:GenericServiceStaticInstance<IToolTipItemFactory> {
        public static IToolTipDataItem CreateIToolTipDataItem() => Current?.CreateToolTipDataItem();
        public static IToolTipObjectItem CreateToolTipObjectItem() => Current?.CreateToolTipObjectItem();
    }

}
