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
using System.ComponentModel;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design
{

    ///<summary>
    ///Container class for types and identifiers used to decorate the appSettings configuration schema with designtime information.
    ///</summary>
    public static class AppSettingsDesignTime
    {
        ///<summary>
        ///Name of appSettings section.
        ///</summary>
        public const string AppSettingsSectionName = "appSettings";

        ///<summary>
        ///Container class for View Model Types used to decorate the appSettings configuration schema with designtime information.
        ///</summary>
        public static class ViewModelTypeNames
        {
            ///<summary>
            ///Type Name of the Section View Model used to display application settings.
            ///</summary>
            public const string AppSettingsSectionViewModel = "Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics.AppSettingsViewModel, Microsoft.Practices.EnterpriseLibrary.Configuration.Design";
        }

        ///<summary/>
        public static class MetadataTypes
        {
            ///<summary/>
            [ViewModel(ViewModelTypeNames.AppSettingsSectionViewModel)]
            [ResourceDisplayName(typeof(DesignResources), "AppSettingsSectionMetadataDisplayName")]
            [ResourceDescription(typeof(DesignResources), "AppSettingsSectionMetadataDescription")]
            public abstract class AppSettingsSectionMetadata
            {

            }

            ///<summary/>
            [ResourceDisplayName(typeof(DesignResources), "KeyValueConfigurationCollectionMetadataDisplayName")]
            [ResourceDescription(typeof(DesignResources), "KeyValueConfigurationCollectionMetadataDescription")]
            public abstract class KeyValueConfigurationCollectionMetadata
            {
            }

            ///<summary/>
            [NameProperty("Key", NamePropertyDisplayFormat = "Setting : '{0}'")]
            [ResourceDisplayName(typeof(DesignResources), "KeyValueConfigurationElementMetadataDisplayName")]
            [ResourceDescription(typeof(DesignResources), "KeyValueConfigurationElementMetadataDescription")]
            public abstract class KeyValueConfigurationElementMetadata
            {
                ///<summary/>
                [ResourceDisplayName(typeof(DesignResources), "KeyValueConfigurationElementMetadataKeyDisplayName")]
                [ResourceDescription(typeof(DesignResources), "KeyValueConfigurationElementMetadataKeyDescription")]
                [EnvironmentalOverridesAttribute(false)]
                [ViewModel(CommonDesignTime.ViewModelTypeNames.ConfigurationPropertyViewModel)]
                public abstract string Key { get; set; }

                ///<summary/>
                [ResourceDisplayName(typeof(DesignResources), "KeyValueConfigurationElementMetadataValueDisplayName")]
                [ResourceDescription(typeof(DesignResources), "KeyValueConfigurationElementMetadataValueDescription")]
                public abstract string Value { get; set; }
            }
        }
    }
}
