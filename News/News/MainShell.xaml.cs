using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainShell : Shell
	{
		public MainShell ()
		{
			InitializeComponent ();
		}
	}
}