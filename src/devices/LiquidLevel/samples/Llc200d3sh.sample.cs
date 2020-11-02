// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading;
using Iot.Device.LiquidLevel;

using Llc200d3sh sensor = new Llc200d3sh(23);
while (true)
{
    // read liquid level switch
    Console.WriteLine($"Detected: {sensor.IsLiquidPresent()}");
    Console.WriteLine();

    Thread.Sleep(1000);
}
