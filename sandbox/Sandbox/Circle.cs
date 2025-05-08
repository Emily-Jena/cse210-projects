class Circle 
{
    private double _radius; // only accessible within this class - always protected

    public void SetRadius(double radius) // can access outside of class
    {
        if (radius < 0) 
        {
            Console.WriteLine("Error, radius must be > 0");
            return;
        }
        _radius = radius; //attribute radius is = to radius
        //this.radius = radius // it is an option.
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }


}