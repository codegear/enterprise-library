﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console.Wpf.Tests.VSTS.Mocks;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console.Wpf.Tests.VSTS.DevTests;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using Microsoft.Practices.Unity;

namespace Console.Wpf.Tests.VSTS.DevTests.given_data_configuration
{
    [TestClass]
    public class when_saving_protected_data_settings : given_data_configuration
    {
        ProtectedConfigurationSource saveSource = new ProtectedConfigurationSource();

        protected override void Act()
        {
            var configurationSourceModel = Container.Resolve<ConfigurationSourceModel>();
            configurationSourceModel.Load(source);

            databaseSectionViewModel = configurationSourceModel.Sections
                        .Where(x => x.SectionName == DataAccessDesignTime.ConnectionStringSettingsSectionName)
                        .Single();

            databaseSectionViewModel.Property("Protection Provider").Value = ProtectedConfiguration.DefaultProvider;
            databaseSectionViewModel.Save(saveSource);
        }

        [TestMethod]
        public void then_all_configuration_sections_are_protected()
        {
            Assert.AreEqual(3, saveSource.ProtectedAddCallCount);
        }

    }
}
