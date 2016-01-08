﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Collections.Immutable;
using System.Windows.Controls;

namespace Core2D.Wpf.Controls.Custom.Lists
{
    /// <summary>
    /// The <see cref="ListBox"/> control for <see cref="BaseShape"/> items with drag and drop support.
    /// </summary>
    public class BaseShapeDragAndDropListBox : DragAndDropListBox<BaseShape>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseShapeDragAndDropListBox"/> class.
        /// </summary>
        public BaseShapeDragAndDropListBox()
            : base()
        {
            this.Initialized += (s, e) => base.Initialize();
        }

        /// <summary>
        /// Updates DataContext binding to ImmutableArray collection property.
        /// </summary>
        /// <param name="array">The updated immutable array.</param>
        public override void UpdateDataContext(ImmutableArray<BaseShape> array)
        {
            var editor = (Core2D.Editor)this.Tag;

            var layer = editor.Project.CurrentContainer.CurrentLayer;

            var previous = layer.Shapes;
            var next = array;
            editor.Project?.History?.Snapshot(previous, next, (p) => layer.Shapes = p);
            layer.Shapes = next;
        }
    }
}
