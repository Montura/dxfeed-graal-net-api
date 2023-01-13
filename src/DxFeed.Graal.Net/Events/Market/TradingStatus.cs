// <copyright file="TradingStatus.cs" company="Devexperts LLC">
// Copyright © 2022 Devexperts LLC. All rights reserved.
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

using DxFeed.Graal.Net.Utils;
using static DxFeed.Graal.Net.Events.Market.TradingStatus;

namespace DxFeed.Graal.Net.Events.Market;

/// <summary>
/// Trading status of an instrument.
/// </summary>
public enum TradingStatus
{
    /// <summary>
    /// Trading status is undefined, unknown or inapplicable.
    /// </summary>
    Undefined,

    /// <summary>
    /// Trading is halted.
    /// </summary>
    Halted,

    /// <summary>
    /// Trading is active.
    /// </summary>
    Active,
}

/// <summary>
/// Class extension for <see cref="TradingStatus"/> enum.
/// </summary>
internal static class TradingStatusExt
{
    private static readonly TradingStatus[] Values = EnumUtil.BuildEnumBitMaskArrayByValue(Undefined);

    /// <summary>
    /// Returns an enum constant of the <see cref="TradingStatus"/> by integer code bit pattern.
    /// </summary>
    /// <param name="value">The specified value.</param>
    /// <returns>The enum constant of the specified enum type with the specified value.</returns>
    public static TradingStatus ValueOf(int value) =>
        Values[value];
}
