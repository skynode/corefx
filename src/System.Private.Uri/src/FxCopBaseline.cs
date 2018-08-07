// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

// TODO: Remove this once https://github.com/dotnet/corefx/issues/13107 is fixed
[assembly: SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity", Scope = "member", Target = "System.Uri.#CreateUriInfo(System.Uri+Flags)")]
