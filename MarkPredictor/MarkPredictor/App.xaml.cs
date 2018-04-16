﻿using Autofac;
using MarkPredictor.Common;
using MarkPredictor.Controllers.Module;
using MarkPredictor.Shared;
using MarkPredictor.Shared.Models;
using System.Windows;

namespace MarkPredictor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigAutofac();
            Common.AutoMapper.Initialize();
            MainWindow mainWindows = new MainWindow();
            mainWindows.Show();
        }

        private void ConfigAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MarkPredictorDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<ModuleModel>();
            builder.RegisterType<LevelModel>();
            builder.RegisterType<ModuleController>().As<IModuleController>().InstancePerLifetimeScope();
            InstanceFactory.Container = builder.Build();
        }   
    }
}
