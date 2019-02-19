using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private string _price;
    private string _miles;
    private string _year;
    private static List<Car> _instances = new List<Car> {};

    public Car(string year, string makeModel, string miles, string price)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _year = year;
      _instances.Add(this);
    }

    public string GetYear()
    {
      return _year;
    }

    public void SetYear(string newYear)
    {
      _year = newYear;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetModel(string newModel)
    {
      _makeModel = newModel;
    }

    public string GetPrice()
    {
      return _price;
    }

    public void SetPrice(string newPrice)
     {
       _price = newPrice;
     }

    public string GetMiles()
    {
      return _miles;
    }

    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
