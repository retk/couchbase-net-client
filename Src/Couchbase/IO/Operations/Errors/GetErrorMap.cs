﻿using Couchbase.Core.Transcoders;

namespace Couchbase.IO.Operations.Errors
{
    internal class GetErrorMap : OperationBase<ErrorMap>
    {
        private const int DefaultVersion = 1; // will be configurable at some point

        public ErrorMap ErrorMap { get; set; }

        public GetErrorMap(ITypeTranscoder transcoder, uint timeout)
            : base(null, null, transcoder, timeout)
        { }

        public override byte[] CreateKey()
        {
            return new byte[0];
        }

        public override byte[] CreateExtras()
        {
            return new byte[0];
        }

        public override byte[] CreateBody()
        {
            var body = new byte[2];
            Converter.FromInt16(DefaultVersion, body, 0);
            return body;
        }

        public override IOperation Clone()
        {
            return new GetErrorMap(Transcoder, Timeout)
            {
                ErrorCode = ErrorCode
            };
        }

        public override void ReadExtras(byte[] buffer)
        {
            // no extras to read
        }

        public override OperationCode OperationCode
        {
            get { return OperationCode.GetErrorMap; }
        }

        public override bool RequiresKey
        {
            get { return false; }
        }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2017 Couchbase, Inc.
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
