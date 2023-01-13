// <copyright file="GreeksMapper.cs" company="Devexperts LLC">
// Copyright © 2022 Devexperts LLC. All rights reserved.
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

using System.Runtime.InteropServices;
using DxFeed.Graal.Net.Events.Options;
using DxFeed.Graal.Net.Native.Events.Options;

namespace DxFeed.Graal.Net.Native.EventMappers;

internal static class GreeksMapper
{
    public static unsafe Greeks FromNative(GreeksNative* eventNative) =>
        new()
        {
            EventSymbol = Marshal.PtrToStringUTF8(eventNative->MarketEvent.EventSymbol),
            EventTime = eventNative->MarketEvent.EventTime,
            EventFlags = eventNative->EventFlags,
            Index = eventNative->Index,
            Price = eventNative->Price,
            Volatility = eventNative->Volatility,
            Delta = eventNative->Delta,
            Gamma = eventNative->Gamma,
            Theta = eventNative->Theta,
            Rho = eventNative->Rho,
            Vega = eventNative->Vega,
        };
}
