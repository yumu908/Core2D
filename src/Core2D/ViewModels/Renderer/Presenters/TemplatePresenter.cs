﻿using Core2D.Model;
using Core2D.Model.Renderer;
using Core2D.ViewModels.Containers;

namespace Core2D.ViewModels.Renderer.Presenters
{
    public partial class TemplatePresenter : IContainerPresenter
    {
        public void Render(object dc, IShapeRenderer renderer, ISelection selection, BaseContainerViewModel container, double dx, double dy)
        {
            if (container is PageContainerViewModel page && page.Template != null)
            {
                renderer.Fill(dc, dx, dy, page.Template.Width, page.Template.Height, page.Template.Background);
                renderer.Grid(dc, page.Template, 0, 0, page.Template.Width, page.Template.Height);
                DrawContainer(dc, renderer, selection, page.Template);
            }
        }

        private void DrawContainer(object dc, IShapeRenderer renderer, ISelection selection, BaseContainerViewModel container)
        {
            foreach (var layer in container.Layers)
            {
                if (layer.IsVisible)
                {
                    DrawLayer(dc, renderer, selection, layer);
                }
            }
        }

        private void DrawLayer(object dc, IShapeRenderer renderer, ISelection selection, LayerContainerViewModel layer)
        {
            foreach (var shape in layer.Shapes)
            {
                if (shape.State.HasFlag(renderer.State.DrawShapeState))
                {
                    shape.DrawShape(dc, renderer, selection);
                }
            }

            foreach (var shape in layer.Shapes)
            {
                if (shape.State.HasFlag(renderer.State.DrawShapeState))
                {
                    shape.DrawPoints(dc, renderer, selection);
                }
            }
        }
    }
}
