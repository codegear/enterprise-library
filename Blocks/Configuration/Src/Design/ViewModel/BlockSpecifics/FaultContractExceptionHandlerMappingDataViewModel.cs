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
using System.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ViewModel.BlockSpecifics
{
    public class FaultContractExceptionHandlerMappingDataViewModel : CollectionElementViewModel
    {
        public FaultContractExceptionHandlerMappingDataViewModel(ElementCollectionViewModel containingCollection, ConfigurationElement thisElement)
            : base(containingCollection, thisElement)
        {
        }

        public Property NameProperty
        {
            get { return Property("Name"); }
        }

        public Property SourceProperty
        {
            get { return Property("Source"); }
        }
    
    }
}
