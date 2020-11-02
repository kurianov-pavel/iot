﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Device.I2c;
using System.Threading;
using Iot.Device.Lm75;

I2cConnectionSettings settings = new I2cConnectionSettings(1, Lm75.DefaultI2cAddress);
I2cDevice device = I2cDevice.Create(settings);

using Lm75 sensor = new Lm75(device);
while (true)
{
    // read temperature
    Console.WriteLine($"Temperature: {sensor.Temperature.DegreesCelsius} ℃");
    Console.WriteLine();

    Thread.Sleep(1000);
}
