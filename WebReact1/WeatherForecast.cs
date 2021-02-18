using System;

namespace WebReact1
{
  public class WeatherForecast
  {
    private DateTime _Date = DateTime.Now;
    private int _Purchased = 0;
    private int _Point = 0;
    public WeatherForecast(int purchased, DateTime date)
    {
      _Date = date;
      _Purchased = purchased;
      _Point = (purchased < 50 ? 0 : (purchased < 100 ? purchased - 50 : (purchased - 100) * 2 + 50));

    }
    public DateTime Date
    {
      get { return _Date; }
      private set
      {
        _Date = value;
      }
    }
    public int Purchased
    {
      get { return _Purchased; }
      private set
      {
        _Purchased = value;
      }
    }
    public int Point
    {
      get { return _Point; }
      private set
      {
        _Point = value;
      }
    }

  }
}
