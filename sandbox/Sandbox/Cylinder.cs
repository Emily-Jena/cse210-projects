class Cylinder 
{
    private Circle _circle; // private member variable

    private double _height;

    public void SetCircle (Circle circle) 
    {
        _circle = circle; // receives circle variable
    }

    public void SetHeight (double height)
    {
        _height = height;
    }

    public double GetVolume()
    {
       // double radius = _circle.GetRadius(); 
        return _circle.GetArea() * _height; //Alt of the above and below formula
        //return Math.PI * radius * radius * _height; // Vol of the can = the formula
    }
}

 