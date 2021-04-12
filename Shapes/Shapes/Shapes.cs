using System;
using System.Xml.Serialization;

namespace Shapes
{
    [Serializable]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Circle))]
    public class Shape
    {
        public virtual string Name { get; }
        public virtual double Area { get; }
        public virtual string Colour { get; set; }
    }

    [Serializable]
    public class Rectangle : Shape
    {

        public double Height { set; get; }
        public double Width { set; get; }

        public override string Colour { get => base.Colour; set => base.Colour = value; }
        public override string Name => GetType().Name;
        public override double Area => Height * Width;
    }

    [Serializable]
    public class Circle : Shape
    {
        public double Radius { set; get; }

        public override string Colour { get => base.Colour; set => base.Colour = value; }
        public override double Area => Math.PI * (Radius * Radius);
        public override string Name => GetType().Name;
    }
}
