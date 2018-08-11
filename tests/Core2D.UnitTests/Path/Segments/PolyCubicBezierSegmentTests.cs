﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Core2D.Path.Segments;
using System.Linq;
using Xunit;

namespace Core2D.UnitTests
{
    public class PolyCubicBezierSegmentTests
    {
        [Fact]
        [Trait("Core2D.Path", "Segments")]
        public void Points_Not_Null()
        {
            var target = new PolyCubicBezierSegment();
            Assert.False(target.Points.IsDefault);
        }

        [Fact]
        [Trait("Core2D.Path", "Segments")]
        public void GetPoints_Should_Return_All_Segment_Points()
        {
            var segment = new PolyCubicBezierSegment();
            segment.Points = segment.Points.Add(new TestPointShape());
            segment.Points = segment.Points.Add(new TestPointShape());
            segment.Points = segment.Points.Add(new TestPointShape());
            segment.Points = segment.Points.Add(new TestPointShape());
            segment.Points = segment.Points.Add(new TestPointShape());

            var target = segment.GetPoints();
            var count = target.Count();

            Assert.Equal(5, count);

            Assert.Equal(segment.Points, target);
        }

        [Fact]
        [Trait("Core2D.Path", "Segments")]
        public void ToString_Should_Return_Path_Markup()
        {
            var target = new PolyCubicBezierSegment();
            target.Points = target.Points.Add(new TestPointShape());
            target.Points = target.Points.Add(new TestPointShape());
            target.Points = target.Points.Add(new TestPointShape());
            target.Points = target.Points.Add(new TestPointShape());
            target.Points = target.Points.Add(new TestPointShape());

            var actual = target.ToString();

            Assert.Equal("C0,0 0,0 0,0 0,0 0,0", actual);
        }
    }
}
