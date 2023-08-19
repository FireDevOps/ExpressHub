using FluentHub.Octokit.Queries.Repositories;
using FluentHub.App.Helpers;
using FluentHub.App.Models;
using FluentHub.App.Services;
using FluentHub.App.Utils;
using FluentHub.App.ViewModels.UserControls.Overview;
using FluentHub.App.ViewModels.UserControls.BlockButtons;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Imaging;

namespace FluentHub.App.ViewModels.Repositories.Issues
{
	public class IssuesViewModel : BaseViewModel
	{
		private readonly ObservableCollection<IssueBlockButtonViewModel> _pinnedItems;
		public ReadOnlyObservableCollection<IssueBlockButtonViewModel> PinnedItems { get; }

		private readonly ObservableCollection<IssueBlockButtonViewModel> _issueItems;
		public ReadOnlyObservableCollection<IssueBlockButtonViewModel> IssueItems { get; }

		public IAsyncRelayCommand LoadRepositoryIssuesPageCommand { get; }

		public IssuesViewModel() : base()
		{
			_issueItems = new();
			IssueItems = new(_issueItems);

			_pinnedItems = new();
			PinnedItems = new(_pinnedItems);

			LoadRepositoryIssuesPageCommand = new AsyncRelayCommand(LoadRepositoryIssuesPageAsync);
		}

		private async Task LoadRepositoryIssuesPageAsync()
		{
			SetTabInformation("Issues", "Issues", "Issues");
			SetLoadingProgress(true);

			_currentTaskingMethodName = nameof(LoadRepositoryIssuesPageAsync);

			try
			{
				_currentTaskingMethodName = nameof(LoadRepositoryAsync);
				await LoadRepositoryAsync(Login, Name);

				_currentTaskingMethodName = nameof(LoadRepositoryIssuesAsync);
				await LoadRepositoryIssuesAsync(Login, Name);

				SetTabInformation($"Issues \u2022 {Login}/{Name}", $"Issues \u2022 {Login}/{Name}");
			}
			catch (Exception ex)
			{
				TaskException = ex;
				IsTaskFaulted = true;
			}
			finally
			{
				SetLoadingProgress(false);
			}
		}

		private async Task LoadRepositoryIssuesAsync(string owner, string name)
		{
			IssueQueries queries = new();
			var items = await queries.GetAllAsync(name, owner);

			_issueItems.Clear();
			foreach (var item in items)
			{
				IssueBlockButtonViewModel viewModel = new()
				{
					IssueItem = item,
				};

				_issueItems.Add(viewModel);
			}

			var pinnedIssues = await queries.GetPinnedAllAsync(owner, name);
			if (pinnedIssues == null) return;

			_pinnedItems.Clear();
			foreach (var item in pinnedIssues)
			{
				IssueBlockButtonViewModel viewModel = new()
				{
					IssueItem = item,
				};

				_pinnedItems.Add(viewModel);
			}
		}

		private async Task LoadRepositoryAsync(string owner, string name)
		{
			RepositoryQueries queries = new();
			Repository = await queries.GetDetailsAsync(owner, name);
		}
	}
}
