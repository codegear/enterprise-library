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
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console.Wpf.Tests.VSTS.DevTests.Contexts;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel.Services;

namespace Console.Wpf.Tests.VSTS.DevTests.given_environment_node_in_view_model
{
    [TestClass]
    public class when_removing_environment : ContainerContext
    {
        ConfigurationSourceModel configurationSourceModel;

        protected override void Arrange()
        {
            base.Arrange();
            configurationSourceModel = Container.Resolve<ConfigurationSourceModel>();
            configurationSourceModel.NewEnvironment();
        }

        protected override void Act()
        {
            configurationSourceModel.Environments.First().Delete();
        }

        [TestMethod]
        public void then_override_is_no_longer_in_section_view_model()
        {
            Assert.AreEqual(0, configurationSourceModel.Environments.Count());
        }

        [TestMethod]
        public void then_override_is_no_longer_in_section_view_model_sections()
        {
            Assert.AreEqual(0, configurationSourceModel.Sections.Count());
        }

        [TestMethod]
        public void then_environment_is_no_longer_in_element_lookup()
        {
            var lookup = Container.Resolve<ElementLookup>();
            Assert.AreEqual(0, lookup.FindExtendedPropertyProviders().Count());
        }
    }
}
