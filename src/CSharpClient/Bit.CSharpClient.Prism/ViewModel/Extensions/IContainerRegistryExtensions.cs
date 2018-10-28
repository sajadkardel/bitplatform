﻿using Autofac;
using Bit.ViewModel;
using Prism.Autofac;
using Prism.Mvvm;
using System;
using Xamarin.Forms;

namespace Prism.Ioc
{
    public static class IContainerRegistryExtensions
    {
        public static IContainerRegistry RegisterPartialView<TPartialView, TPartialViewModel>(this IContainerRegistry containerRegistry)
            where TPartialView : TemplatedView
            where TPartialViewModel : BitViewModelBase
        {
            ViewModelLocationProvider.Register<TPartialView>(() => containerRegistry.GetContainer().Resolve<TPartialViewModel>());
            containerRegistry.GetBuilder().RegisterType<TPartialViewModel>().AsSelf().PropertiesAutowired(PropertyWiringOptions.PreserveSetValues);

            return containerRegistry;
        }

        public static void RegisterForNav<TView>(this IContainerRegistry containerRegistry, string name = null)
            where TView : Page
        {
            containerRegistry.RegisterForNavigation<TView>(name);
        }

        public static void RegisterForNav(this IContainerRegistry containerRegistry, Type viewType, string name)
        {
            containerRegistry.RegisterForNavigation(viewType, name);
        }

        public static void RegisterForNav<TView, TViewModel>(this IContainerRegistry containerRegistry, string name = null)
            where TView : Page
            where TViewModel : class
        {
            containerRegistry.RegisterForNavigation<TView, TViewModel>(name);
            containerRegistry.GetBuilder().RegisterType<TViewModel>().PropertiesAutowired(PropertyWiringOptions.PreserveSetValues);
        }

        public static void RegisterForNavOnIdiom<TView, TViewModel>(this IContainerRegistry containerRegistry, string name = null, Type desktopView = null, Type tabletView = null, Type phoneView = null)
            where TView : Page
            where TViewModel : class
        {
            throw new NotImplementedException();
        }

        public static void RegisterForNavOnPlatform<TView, TViewModel>(this IContainerRegistry containerRegistry, params IPlatform[] platforms)
            where TView : Page
            where TViewModel : class
        {
            throw new NotImplementedException();
        }

        public static void RegisterForNavOnPlatform<TView, TViewModel>(this IContainerRegistry containerRegistry, string name, params IPlatform[] platforms)
            where TView : Page
            where TViewModel : class
        {
            throw new NotImplementedException();
        }
    }
}
