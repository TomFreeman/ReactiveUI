﻿// Copyright (c) 2025 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace ReactiveUI;

/// <summary>
/// Implement this to override how RoutedViewHost and ViewModelViewHost
/// map ViewModels to Views.
/// </summary>
public interface IViewLocator : IEnableLogger
{
    /// <summary>
    /// Determines the view for an associated ViewModel.
    /// </summary>
    /// <typeparam name="T">The view model type.</typeparam>
    /// <param name="viewModel">View model.</param>
    /// <param name="contract">Contract.</param>
    /// <returns>The view associated with the given view model.</returns>
#if NET6_0_OR_GREATER
    [RequiresDynamicCode("The method uses reflection and will not work in AOT environments.")]
    [RequiresUnreferencedCode("The method uses reflection and will not work in AOT environments.")]
#endif
    IViewFor? ResolveView<T>(T? viewModel, string? contract = null);
}
