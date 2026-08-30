  using System.ComponentModel.DataAnnotations;
  using System.Security.Cryptography;
  using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication
{
 public class Cylinder
    {
       public double Radius;
       public double Height;
      
//konstruktor 
   public  Cylinder()
  {}
     
       public double GetDiameter()
    {
      return 2 * Radius;
    }
    public double GetBaseArea()
    {
      return Math.PI * Radius * Radius;
    }
    public double GetVolume()
    {
      return Height * GetBaseArea();
    }

public double GetCircumference()
    {
      return 2* Math.PI * Radius;
    }

public double GetLateralArea()
    {
    return  Height * GetCircumference();
    }

  public double GetSurfaceArea()
    {
      return (Height + Radius) * GetCircumference();
    }
  
     public static double GetSurfaceArea(double Radius, double Height)
    {
      return 2 * Math.PI * Radius * (Radius + Height);
    }
    public  Cylinder(double radius, double height)
  {
     Radius = radius;
     Height = height;
  }
  


}


}
