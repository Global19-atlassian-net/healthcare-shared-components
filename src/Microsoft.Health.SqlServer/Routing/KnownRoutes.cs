﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.SqlServer.Features.Routing
{
    public static class KnownRoutes
    {
        public const string SchemaRoot = "_schema";

        public const string Compatibility = "compatibility";
        public const string Versions = "versions";

        public const string Current = Versions + "/current";
        public const string Script = Versions + "/{id:int}/script";
        public const string Diff = Script + "/diff";
    }
}
