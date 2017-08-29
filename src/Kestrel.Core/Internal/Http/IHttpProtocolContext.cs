// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO.Pipelines;
using System.Net;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
    public interface IHttpProtocolContext
    {
        string ConnectionId { get; set; }
        ServiceContext ServiceContext { get; set; }
        PipeFactory PipeFactory { get; set; }
        IPEndPoint RemoteEndPoint { get; set; }
        IPEndPoint LocalEndPoint { get; set; }
    }
}
