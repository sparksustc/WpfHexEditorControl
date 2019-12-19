namespace WpfHexEditor.Sample.MVVM.Contracts.ToolTip {
    /// <summary>
    /// This tooltip item will show a Key (On the left) and a Value(On the right);
    /// </summary>
    public interface IToolTipDataItem : IToolTipItem {
        string KeyName { get; set; }
        string Value { get; set; }
    }
}
