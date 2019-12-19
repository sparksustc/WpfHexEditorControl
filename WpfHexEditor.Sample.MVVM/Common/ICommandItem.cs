using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WpfHexEditor.Sample.MVVM.Contracts.Common
{
    /// <summary>
    /// CommandItem;
    /// </summary>
    public interface ICommandItem  {
        /// <summary>
        /// 命令;
        /// </summary>
        ICommand Command { get; }
        /// <summary>
        /// 名称;
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// ICon;
        /// </summary>
        Uri Icon { get; set; }
        bool IsEnabled { get; set; }
        string GUID { get; }

        IEnumerable<ICommandItem> Children { get; }

        void AddChild(ICommandItem commandItem);

        void RemoveChild(ICommandItem commandItem);

        /// <summary>
        /// 排序;
        /// </summary>
        int Sort { get; set; }
    }

}
