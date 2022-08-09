using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      CalculateTotalCost();
    }
    static double Triangle(double ht, double wt){
      double area=(0.5 * wt) * ht;
      return area;
    }
    static double Rectangle(double hr, double wr){
      double area=wr * hr;
      return area;
    }
    static double Circle(double diameter){
      double area = Math.PI * Math.Pow((diameter/2),2) ;
      return area/2;
    }
    static void CalculateTotalCost(){
      double triangle =Triangle(500,750);
      double circle= Circle(375);
      double rectangle = Rectangle(1500,2500);
      double totalArea= triangle + circle + rectangle;
      double floorPrice= 180;
      double flooringCost = totalArea * floorPrice;
      flooringCost= Math.Round(flooringCost, 2);
      Console.WriteLine($"The total area of Teotihuacan is {totalArea} meters and the flooring cost comes to about ${flooringCost} pesos.");
    }
  }
}