using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BeautifulPanel
{
    public sealed class Flake : Control
    {
        private readonly int _angle;
        private readonly double _scale;
        private readonly double _opacity;
        private RotateTransform _rotateTransform;
        private ScaleTransform _scaleTransform;

        public Flake(int angle, double scale, double opacity) : this()
        {
            _angle = angle;
            _scale = scale;
            _opacity = opacity;
        }

        private Flake()
        {
            DefaultStyleKey = typeof(Flake);
        }

        public override void OnApplyTemplate()
        {
            _rotateTransform = GetTemplateChild("MyRotateTransform") as RotateTransform;
            _scaleTransform = GetTemplateChild("MyScaleTransform") as ScaleTransform;
            Transform(_angle, _scale);
            this.Opacity = _opacity;
            base.OnApplyTemplate();
        }

        private void Transform(int angle, double scale)
        {
            _rotateTransform.Angle = angle;
            _scaleTransform.ScaleX = _scale;
            _scaleTransform.ScaleY = _scale;
        }
    }
}