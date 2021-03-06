﻿using pdfforge.PDFCreator.UI.Presentation.Help;
using pdfforge.PDFCreator.UI.Presentation.ServiceLocator;
using pdfforge.PDFCreator.UI.Presentation.UserControls.Profiles.TabHelper;
using Prism.Regions;
using SimpleInjector;

namespace pdfforge.PDFCreator.Editions.EditionBase.Tab
{
    public class SimpleTab<TView, TViewModel> : ISettingsTab
        where TView : class
        where TViewModel : class, ITabViewModel
    {
        private readonly HelpTopic _helpTopic;
        private readonly string _contentRegionName;

        public SimpleTab(string contentRegionName, HelpTopic helpTopic)
        {
            _helpTopic = helpTopic;
            _contentRegionName = contentRegionName;
        }

        public void Register(IRegionManager regionManager, IWhitelistedServiceLocator serviceLocator, string regionName)
        {
            regionManager.RegisterSimpleTab<TView, TViewModel>(regionName, _contentRegionName, _helpTopic, serviceLocator);
        }

        public void RegisterNavigationViews(Container container)
        {
        }
    }
}
