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

namespace Apache.Ignite.ExamplesDll.Datagrid
{
    using System;
    using Apache.Ignite.Core.Cache;

    /// <summary>
    /// EntryProocessor that increments cached values.
    /// </summary>
    [Serializable]
    public class CacheIncrementEntryProcessor : ICacheEntryProcessor<int, int, int, object>
    {
        /// <summary>
        /// Process an entry.
        /// </summary>
        /// <param name="entry">The entry to process.</param>
        /// <param name="arg">The argument.</param>
        /// <returns>
        /// Processing result.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object Process(IMutableCacheEntry<int, int> entry, int arg)
        {
            entry.Value += arg;

            return null;
        }
    }
}
