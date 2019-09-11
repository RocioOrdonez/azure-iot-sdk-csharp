﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Iot.DigitalTwin.Device.Model
{
    /// <summary>
    /// Contains information needed for updating an asynchronous command's status.
    /// </summary>
    public struct DigitalTwinAsyncCommandUpdate : IEquatable<DigitalTwinAsyncCommandUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalTwinAsyncCommandUpdate"/> struct.
        /// </summary>
        /// <param name="name">The name of the command to be updated.</param>
        /// <param name="requestId">The request id of the command to be updated.</param>
        /// <param name="status">The status of the the command to be updated.</param>
        /// <param name="payload">The serialized payload of the the command to be updated.</param>
        public DigitalTwinAsyncCommandUpdate(string name, string requestId, int status, string payload)
        {
            this.Name = name;
            this.Payload = payload;
            this.RequestId = requestId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalTwinAsyncCommandUpdate"/> struct.
        /// </summary>
        /// <param name="name">The name of the command to be updated.</param>
        /// <param name="requestId">The request id of the command to be updated.</param>
        /// <param name="status">The status of the the command to be updated.</param>
        public DigitalTwinAsyncCommandUpdate(string name, string requestId, int status)
            : this(name, requestId, status, string.Empty)
        {
        }

        /// <summary>
        /// Gets the command name associated with this update.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the serialized payload associated with this update.
        /// </summary>
        public string Payload { get; }

        /// <summary>
        /// Gets the command request id associated with this update.
        /// </summary>
        public string RequestId { get; }

        /// <summary>
        /// Gets the status associated with this update.
        /// </summary>
        public int Status { get; }

        public bool Equals(DigitalTwinAsyncCommandUpdate other)
        {
            return
                string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(this.Payload, other.Payload, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(this.RequestId, other.RequestId, StringComparison.OrdinalIgnoreCase) &&
                this.Status == other.Status;
        }

        public override bool Equals(object obj)
        {
            return obj is DigitalTwinAsyncCommandUpdate && this.Equals((DigitalTwinAsyncCommandUpdate)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Name, this.Payload, this.RequestId, this.Status);
        }
    }
}