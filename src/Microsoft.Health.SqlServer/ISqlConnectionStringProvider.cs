﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Microsoft.Health.SqlServer
{
    public interface ISqlConnectionStringProvider
    {
        /// <summary>
        /// Get the SQL connection string.
        /// </summary>
        /// <returns>A SQL connection string.</returns>
        Task<string> GetSqlConnectionString();
    }
}