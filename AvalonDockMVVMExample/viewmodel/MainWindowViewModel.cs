using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonDockMVVMExample.viewmodel {
	public class MainWindowViewModel {
		public DockManagerViewModel DockManagerViewModel{get; private set;}
		//public MenuViewModel MenuViewModel{get; private set;}

		public MainWindowViewModel() {
			var documents = new List<DockWindowViewModel>();

			for (int i = 0; i < 3; i++) {
				documents.Add(new PluginViewModel() { Title = "Sample " + i.ToString() });
				documents.Add(new Plugin2ViewModel() { Title = "Sample " + (3 + i).ToString() });
			}

			DockManagerViewModel = new DockManagerViewModel(documents);
			//this.MenuViewModel = new MenuViewModel(documents);
		}
	}
}