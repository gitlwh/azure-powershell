//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public partial class PSDisk
    {
        // Gets or sets the property of 'ResourceGroupName'
        public string ResourceGroupName
        {
            get
            {
                if (string.IsNullOrEmpty(Id)) return null;
                Regex r = new Regex(@"(.*?)/resourcegroups/(?<rgname>\S+)/providers/(.*?)", RegexOptions.IgnoreCase);
                Match m = r.Match(Id);
                return m.Success ? m.Groups["rgname"].Value : null;
            }
        }

        public string ManagedBy { get; set; }
        public IList<string> ManagedByExtended { get; set; }
        public DiskSku Sku { get; set; }
        public IList<string> Zones { get; set; }
        public DateTime? TimeCreated { get; set; }
        public OperatingSystemTypes? OsType { get; set; }
        public string HyperVGeneration { get; set; }
        public CreationData CreationData { get; set; }
        public int? DiskSizeGB { get; set; }
        public long? DiskSizeBytes { get; set; }
        public string UniqueId { get; set; }
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        public string ProvisioningState { get; set; }
        public long? DiskIOPSReadWrite { get; set; }
        public long? DiskMBpsReadWrite { get; set; }
        public long? DiskIOPSReadOnly { get; set; }
        public long? DiskMBpsReadOnly { get; set; }
        public string DiskState { get; set; }
        public Encryption Encryption { get; set; }
        public int? MaxShares { get; set; }
        public IList<ShareInfoElement> ShareInfo { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public ExtendedLocation ExtendedLocation { get; set; }
        public IDictionary<string, string> Tags { get; set; }
        public string NetworkAccessPolicy { get; set; }
        public string DiskAccessId { get; set; }
        public string Tier { get; set; }
        public bool? BurstingEnabled { get; set; }
        public PSPurchasePlan PurchasePlan { get; set; }
        public bool? SupportsHibernation { get; set; }
        public DiskSecurityProfile SecurityProfile { get; set; }
        public string PublicNetworkAccess { get; set; }
        public SupportedCapabilities SupportedCapabilities { get; set; }
        public string DataAccessAuthMode { get; set; }
        public double? CompletionPercent { get; set; }
    }
}
