// Copyright (c) 2025 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace ReactiveUI;

/// <summary>
/// A suspension driver that does not do anything.
/// Useful potentially for unit testing or for platforms
/// where you don't want to use a Suspension Driver.
/// </summary>
#if NET6_0_OR_GREATER
[RequiresDynamicCode("The method uses reflection and will not work in AOT environments.")]
[RequiresUnreferencedCode("The method uses reflection and will not work in AOT environments.")]
#endif
public class DummySuspensionDriver : ISuspensionDriver
{
    /// <inheritdoc/>
    public IObservable<object> LoadState() => // TODO: Create Test
        Observable<object>.Default;

    /// <inheritdoc/>
    public IObservable<Unit> SaveState(object state) => // TODO: Create Test
        Observables.Unit;

    /// <inheritdoc/>
    public IObservable<Unit> InvalidateState() => // TODO: Create Test
        Observables.Unit;
}
