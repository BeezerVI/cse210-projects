
using System;
public class Circle : Shapes {
    private double _radius;

    public Circle(string color, double radius) : base(color) {
        _radius = radius;
    }
    public override double GetArea() {
    return 3.145 * _radius * _radius; //Could have used Math.PI but I prefer it this whay
    }
}