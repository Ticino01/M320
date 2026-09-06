  using System.ComponentModel.DataAnnotations;
  using System.Security.Cryptography;
  using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication
{
 public class Cylinder
    {
       private double  _radius {get; set;}
       private  double _height {get; set;}
      

      public void SetHeight(double height)
    {
      _height  = height;
    }

    public void SetRadius(double radius)
    {
      _radius = radius;
    }

    public double GetHeight()
    {
      return _height;
    }

    public double GetRadius()
    {
      return _radius;
  
    }
//konstruktor 
   public  Cylinder()
  {}
     
       public double GetDiameter()
    {
      return 2 * _radius;
    }
    public double GetBaseArea()
    {
      return Math.PI * _radius * _radius;
    }
    public double GetVolume()
    {
      return _height * GetBaseArea();
    }

public double GetCircumference()
    {
      return 2* Math.PI * _radius;
    }

public double GetLateralArea()
    {
    return  _height * GetCircumference();
    }

  public double GetSurfaceArea()
    {
      return (_height + _radius) * GetCircumference();
    }
  
     public static double GetSurfaceArea(double Radius, double Height)
    {
      return 2 * Math.PI * Radius * (Radius + Height);
    }
    public  Cylinder(double radius, double height)
  {
     _radius = radius;
     _height = height;
  }
  


}

    public class Cuiobid
  { 
    public double _height   {get; set;}
    public double _radius {get; set;}
    public double _width {get; set;}

    public double Volumen()
    {
      return _height * _radius * _width;

    }

    public double Gesamtoberfläche()
    {
      return 2 * (_height * _radius + _height * _width + _radius * _width);
    }
    public double Bodenfläche()
    {
      return -_width * _radius;
    }
    public double Diagonale()
    {
      return Math.Sqrt((_height * _height) + (_radius * _radius) + (_width * _width));
    }
  }
}
