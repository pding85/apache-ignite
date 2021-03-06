/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Apache.Ignite.Core.Common
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;
    using System.Threading.Tasks;

    /// <summary>
    /// Indicates that client-mode local node has been disconnected from the cluster.
    /// </summary>
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", 
        Justification = "No need to implement GetObjectData because there are no custom fields.")]
    [Serializable]
    public sealed class ClientDisconnectedException : IgniteException
    {
        /// <summary>
        /// The client reconnect task.
        /// </summary>
        private readonly Task<bool> _clientReconnectTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedException"/> class.
        /// </summary>
        public ClientDisconnectedException()
        {
            // No-op.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ClientDisconnectedException(string message) : base(message)
        {
            // No-op.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cause">The cause.</param>
        public ClientDisconnectedException(string message, Exception cause) : base(message, cause)
        {
            // No-op.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cause">The cause.</param>
        /// <param name="clientReconnectTask">The client reconnect task.</param>
        public ClientDisconnectedException(string message, Exception cause, Task<bool> clientReconnectTask) : base(message, cause)
        {
            _clientReconnectTask = clientReconnectTask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDisconnectedException"/> class.
        /// </summary>
        /// <param name="info">Serialization information.</param>
        /// <param name="ctx">Streaming context.</param>
        private ClientDisconnectedException(SerializationInfo info, StreamingContext ctx) : base(info, ctx)
        {
            // No-op.
        }

        /// <summary>
        /// Gets the client reconnect task, if present.
        /// </summary>
        /// <value>
        /// The client reconnect task, or null.
        /// </value>
        public Task<bool> ClientReconnectTask
        {
            get { return _clientReconnectTask; }
        }
    }
}
