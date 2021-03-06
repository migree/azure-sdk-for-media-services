﻿//-----------------------------------------------------------------------
// <copyright file="INotificationEndPoint.cs" company="Microsoft">Copyright 2012 Microsoft Corporation</copyright>
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

using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.MediaServices.Client
{
    /// <summary>
    /// Notification endpoint, to which the publisher pushes notification, from which
    /// the subscriber reads notification.
    /// 
    /// The endpoint is provided by the application.
    /// </summary>
    public partial interface INotificationEndPoint
    {
        /// <summary>
        /// Unique identifier of notification endpoint
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Display name of the notification endpoint.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Type of notification endpoint.
        /// 
        /// Media service uses this type to determine how to write the notification to the endpoint. 
        /// </summary>
        NotificationEndPointType EndPointType { get; }

        /// <summary>
        /// Address of endpoint. The constraints of this value is determined by the endpoint type.
        /// </summary>
        string EndPointAddress { get; }

        /// <summary>
        /// Update the notification endpoint object.
        /// </summary>
        void Update();

        /// <summary>
        /// Update the notification endpoint object in asynchronous mode.
        /// </summary>
        /// <returns>Task of updating the notification endpoint.</returns>
        Task UpdateAsync();

        /// <summary>
        /// Delete this instance of notification endpoint object.
        /// </summary>
        void Delete();

        /// <summary>
        /// Delete this instance of notification endpoint object in asynchronous mode.
        /// </summary>
        /// <returns>Task of deleting the notification endpoint.</returns>
        Task DeleteAsync();
    }
}
