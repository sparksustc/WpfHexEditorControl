namespace WpfHexEditor.Sample.MVVM.Contracts.ToolTip {

    public interface IToolTipObjectItem : IToolTipItem {
        new object UIObject { get; set; }
    }
    
}
