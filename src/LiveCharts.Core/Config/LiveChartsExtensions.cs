﻿using System;
using System.Drawing;
using System.Linq;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Charts;
using LiveCharts.Core.Data;
using LiveCharts.Core.Dimensions;
using Rectangle = LiveCharts.Core.Drawing.Rectangle;
using Size = LiveCharts.Core.Drawing.Size;

namespace LiveCharts.Core.Config
{
    /// <summary>
    /// A set of useful extensions.
    /// </summary>
    public static class LiveChartsExtensions
    {
        /// <summary>
        /// Sets the opacity.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="opacity">The opacity.</param>
        /// <returns></returns>
        public static Color SetOpacity(this Color color, double opacity)
        {
            return Color.FromArgb((byte) (255 * opacity), color.R, color.G, color.B);
        }

        /// <summary>
        /// Gets the series dimensions.
        /// </summary>
        /// <param name="chart">The chart.</param>
        /// <param name="series">The series.</param>
        /// <returns></returns>
        public static DimensionRange[] GetSeriesDimensions(this ChartModel chart, IChartSeries series)
        {
            return series.ScaleAtByDimension
                .Select((scalesAtIndex, dimensionIndex) =>
                    chart.DataRangeMatrix[dimensionIndex][scalesAtIndex])
                .ToArray();
        }
    }
}
