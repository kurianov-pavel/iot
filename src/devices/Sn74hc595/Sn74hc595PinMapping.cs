﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Device.Gpio;
using System.Device.Spi;

namespace Iot.Device.Multiplexing
{
    /// <summary>
    /// Represents pin bindings for the Sn74hc595.
    /// </summary>
    public struct Sn74hc595PinMapping
    {
        /// <param name="ser">Data pin</param>
        /// <param name="oe">Output enable pin</param>
        /// <param name="rclk">Register clock pin (latch)</param>
        /// <param name="srclk">Shift register pin (shift to data register)</param>
        /// <param name="srclr">Shift register clear pin (shift register is cleared)</param>
        public Sn74hc595PinMapping(int ser, int srclk, int rclk, int oe = -1, int srclr = -1)
        {
            Ser = ser;
            SrClk = srclk;
            RClk = rclk;
            OE = oe;
            SrClr = srclr;
        }

        /// <summary>
        /// Minimal pin bindings for the Sn74hc595.
        /// </summary>
        public static Sn74hc595PinMapping Minimal => new Sn74hc595PinMapping(16, 20, 21);
        /*
            Ser     = 16    SR 14   -- data
            SrClk   = 20    SR 11   -- storage register clock
            RClk    = 21    SR 12   -- latch enable to publish storage register
        */

        /// <summary>
        /// Standard pin bindings for the Sn74hc595.
        /// </summary>
        public static Sn74hc595PinMapping Complete => new Sn74hc595PinMapping(16, 20, 21, 12, 25);
        /*
            Ser     = 16    SR 14   -- data
            SrClk   = 20    SR 11   -- storage register clock
            RClk    = 21    SR 12   -- latch enable to publish storage register
            OE      = 12    SR 13   -- output enable or disable
            SrClr   = 25    SR 10   -- clear storage register
        */

        /// <summary>
        /// SER (data) pin number.
        /// </summary>
        public int Ser { get; set; }

        /// <summary>
        /// SRCLK (shift) pin number.
        /// </summary>
        public int SrClk { get; set; }

        /// <summary>
        /// RCLK (latch) pin number.
        /// </summary>
        public int RClk { get; set; }

        /// <summary>
        /// OE (output enable) pin number.
        /// </summary>
        public int OE { get; set; }

        /// <summary>
        /// SRCLR (clear register) pin number.
        /// </summary>
        public int SrClr { get; set; }
    }
}
