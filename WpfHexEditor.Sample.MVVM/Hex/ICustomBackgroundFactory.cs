using System;
using System.Collections.Generic;
using System.Text;
using WpfHexaEditor.Core;
using WpfHexaEditor.Core.Interfaces;
using WpfHexEditor.Sample.MVVM.Contracts.Common;

namespace WpfHexEditor.Sample.MVVM.Contracts.Hex
{
    public interface ICustomBackgroundFactory
    {
        BrushBlock CreateNew();
    }

    public class CustomBackgroundFactory : GenericServiceStaticInstance<ICustomBackgroundFactory> {
        public static BrushBlock CreateNew() => Current.CreateNew();
    }
}
