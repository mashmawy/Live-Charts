﻿using System;
using System.Drawing;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Data.Points;

namespace LiveCharts.Wpf.PointViews
{
    /// <summary>
    /// Column point view.
    /// </summary>
    /// <seealso cref="LiveCharts.Core.Abstractions.IPointView" />
    public class ColumnPointView : IPointView
    {
        /// <summary>
        /// Gets the rectangle.
        /// </summary>
        /// <value>
        /// The rectangle.
        /// </value>
        public Rectangle Rectangle { get; protected set; }

        public void Draw(ChartPoint point, ChartPoint previous, IChartView chart)
        {
            
            throw new NotImplementedException();
        }

        public void Erase()
        {
            throw new NotImplementedException();
        }
    }
}
