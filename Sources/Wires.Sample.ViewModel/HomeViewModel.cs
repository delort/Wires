using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wires.Sample.ViewModel
{
	public class HomeViewModel : ViewModelBase
	{
		public HomeViewModel()
		{
			this.Title = "Wires";
			this.Illustration = "https://github.com/aloisdeniel/Wires/raw/develop/Documentation/Logo.png";
			this.Amount = 0.45;
			this.IsActive = true;
			this.birthday = new DateTime(1988, 6, 2);

			this.loadCommand = new RelayCommand(ExecuteLoadCommand, CanExecuteLoadCommand);
		}

		#region Fields

		private string title;

		private string illustration;

		private bool isLoading;

		private bool isActive;

		private double amount;

		private DateTime birthday;

		#endregion

		#region Properties

		public string Title
		{
			get { return title; }
			set { if (this.Set(ref title, value)) RaiseProperty(nameof(Sections)); }
		}

		public string Illustration
		{
			get { return illustration; }
			set { this.Set(ref illustration, value); }
		}

		public string[] Sections => new[] { Title, Amount.ToString(), IsActive.ToString()  };

		public double Amount
		{
			get { return amount; }
			set { if(this.Set(ref amount, value)) RaiseProperty(nameof(Sections)); }
		}

		public bool IsActive
		{
			get { return isActive; }
			set { if (this.Set(ref isActive, value)) RaiseProperty(nameof(Sections)); }
		}

		public DateTime Birthday
		{
			get { return birthday; }
			set { this.Set(ref birthday, value); }
		}

		public bool IsLoading
		{
			get { return isLoading; }
			set
			{
				if (this.Set(ref isLoading, value))
				{
					this.loadCommand.RaiseCanExecuteChanged();
				}
			}
		}

		#endregion

		private RelayCommand loadCommand;

		public ICommand LoadCommand => loadCommand;

		async void ExecuteLoadCommand()
		{
			this.IsLoading = true;
			await Task.Delay(2000);
			this.IsLoading = false;
		}

		bool CanExecuteLoadCommand() => !this.IsLoading;
	}
}
