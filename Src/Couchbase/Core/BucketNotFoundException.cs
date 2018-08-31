﻿using System;
using System.Runtime.Serialization;

namespace Couchbase.Core
{
    public class BucketNotFoundException : ArgumentException
    {
        public BucketNotFoundException()
        {
        }

        public BucketNotFoundException(string message) : base(message)
        {
        }

        public BucketNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public BucketNotFoundException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }

        public BucketNotFoundException(string message, string paramName) : base(message, paramName)
        {
        }

#if NET452
        protected BucketNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2014 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion