﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;

namespace Core2D
{
    /// <summary>
    /// 
    /// </summary>
    public class XPolyLineSegment : XPathSegment
    {
        /// <summary>
        /// 
        /// </summary>
        public IList<XPoint> Points { get; set; }

        /// <summary>
        /// Creates a new <see cref="XPolyLineSegment"/> instance.
        /// </summary>
        /// <param name="points"></param>
        /// <param name="isStroked"></param>
        /// <param name="isSmoothJoin"></param>
        /// <returns></returns>
        public static XPolyLineSegment Create(
            IList<XPoint> points,
            bool isStroked,
            bool isSmoothJoin)
        {
            return new XPolyLineSegment()
            {
                Points = points,
                IsStroked = isStroked,
                IsSmoothJoin = isSmoothJoin
            };
        }
    }
}
