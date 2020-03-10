using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
    public int Weight {get; set;}
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public int Volume {get; set;}
    public int Cost {get; set;}



    public Parcel(int weight, int length, int width, int height)
    {
      Weight = weight;
      Length = length;
      Width = width;
      Height = height;
    }


    public int Volumer(int length, int width, int height)
    {
      Volume = (length*width*height);
      return Volume;
    }

    public int CostToShip()
    {
      Cost = (Volume*Weight)/3;
      return Cost;
     
    }


    }
}
