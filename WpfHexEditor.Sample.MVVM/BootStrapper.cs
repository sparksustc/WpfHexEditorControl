using CommonServiceLocator;
using Prism.Ioc;
using Prism.Mef;
using Prism.Modularity;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using WpfHexEditor.Sample.MVVM.Common;
using WpfHexEditor.Sample.MVVM.Contracts.Common;
using WpfHexEditor.Sample.MVVM.Contracts.Shell;

namespace WpfHexEditor.Sample.MVVM {

    public class BootStrapper : MefBootstrapper {
        protected override void ConfigureAggregateCatalog() {
            base.ConfigureAggregateCatalog();

            //Framework assembly;
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Dummy).Assembly));
            
        }

        protected override IContainerExtension CreateContainerExtension() => null;
        protected override IModuleCatalog CreateModuleCatalog() {
            return new ConfigurationModuleCatalog();
        }

        protected override DependencyObject CreateShell() {
            ServiceProvider.SetServiceProvider(new PracticeServiceProviderAdapter(ServiceLocator.Current));
            return this.Container.GetExportedValue<IShell>() as DependencyObject;
        }


        protected override void InitializeShell() {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }


    }
}
