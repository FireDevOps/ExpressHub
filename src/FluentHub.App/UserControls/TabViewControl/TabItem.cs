// Copyright (c) FluentHub
// Licensed under the MIT License. See the LICENSE.

using FluentHub.App.Services.Navigation;
using FluentHub.App.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace FluentHub.App.UserControls.TabViewControl
{
    public class TabItem : ObservableObject, ITabViewItem
    {
        private readonly ILogger _logger;

        public Guid Guid { get; }

        public Frame Frame { get; }

        public NavigationHistory<PageNavigationEntry> NavigationHistory { get; }

        public TabItem()
        {
            // Dependency injection
            _logger = App.Current.Services.GetService<ILogger>();

            // Initialize
            Guid = Guid.NewGuid();
            Frame = new();
            NavigationHistory = new();

            Frame.Navigating += OnFrameNavigating;
        }

        private void OnFrameNavigating(object sender, NavigatingCancelEventArgs e)
        {
            switch (e.NavigationMode)
            {
                case NavigationMode.New:
                    NavigationHistory.NavigateTo(new PageNavigationEntry(), NavigationHistory.CurrentItemIndex + 1);
                    break;
                case NavigationMode.Back:
                    NavigationHistory.GoBack();
                    break;
                case NavigationMode.Forward:
                    NavigationHistory.GoForward();
                    break;
            }

            _logger?.Info("ITabViewItem.OnFrameNavigating [Page: {0}, Parameter: {1}, NavigationMode: {2}]", e.SourcePageType, e.Parameter, e.NavigationMode);
        }
    }
}
