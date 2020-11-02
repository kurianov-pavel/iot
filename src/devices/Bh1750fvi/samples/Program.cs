﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Device.I2c;
using System.Threading;
using Iot.Device.Bh1750fvi;

I2cConnectionSettings settings = new I2cConnectionSettings(busId: 1, (int)I2cAddress.AddPinLow);
I2cDevice device = I2cDevice.Create(settings);

using Bh1750fvi sensor = new Bh1750fvi(device);
while (true)
{
    Console.WriteLine($"Illuminance: {sensor.Illuminance}Lux");

    Thread.Sleep(1000);
}
