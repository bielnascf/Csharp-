﻿using Exercicios40.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Exercicios40.Model.Entities
{
    class Circulo : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"""
                Circle color: {Color}
                Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}
                Area = {Area().ToString("F2", CultureInfo.InvariantCulture)};
                """;
        }
    }
}
