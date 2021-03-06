﻿//-----------------------------------------------------------------------
// <copyright file="TestCloudMediaContext.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
// <license>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>


using System;

namespace Microsoft.WindowsAzure.MediaServices.Client.Tests.Common
{
    public class TestCloudMediaContext : CloudMediaContext
    {
        public TestCloudMediaContext(string accountName, string accountKey) : base(accountName, accountKey)
        {
        }

        public TestCloudMediaContext(Uri apiServer, string accountName, string accountKey) : base(apiServer, accountName, accountKey)
        {
        }

        public TestCloudMediaContext(Uri apiServer, string accountName, string accountKey, string scope, string acsBaseAddress) : base(apiServer, accountName, accountKey, scope, acsBaseAddress)
        {
        }

        public TestCloudMediaContext(MediaServicesCredentials credentials) : base(credentials)
        {
        }

        public TestCloudMediaContext(Uri apiServer, MediaServicesCredentials credentials) : base(apiServer, credentials)
        {
        }


        public override IStorageAccount DefaultStorageAccount
        {
            get
            {
                return new StorageAccountData
                {
                    IsDefault = true,
                    Name = "test storage"
                };
            }
        }
    }
}