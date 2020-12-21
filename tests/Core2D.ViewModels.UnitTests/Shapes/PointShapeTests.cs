﻿#nullable disable
using Core2D.Model;
using Core2D.ViewModels.Shapes;
using Xunit;

namespace Core2D.ViewModels.UnitTests.Shapes
{
    public class PointShapeTests
    {
        private readonly IFactory _factory = new Factory(null);

        [Fact]
        [Trait("Core2D.Shapes", "Shapes")]
        public void Inherits_From_BaseShape()
        {
            var target = _factory.CreatePointShape();
            Assert.True(target is BaseShapeViewModel);
        }
    }
}
