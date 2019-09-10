using System;
using System.Collections.Generic;

namespace Class09_NestedClass
{
  class Configuration
  {
    private List<ItemValue> listConfig = new List<ItemValue>();

    public void SetConfig(string item, string value)
    {
      ItemValue iv = new ItemValue();
      iv.SetValue(this, item, value);
    }

    public string GetConfig(string item)
    {
      foreach (var iv in listConfig)
        if (iv.GetItem() == item)
          return iv.GetValue();

      return "";
    }
    
    class ItemValue
    {
      private string item;
      private string value;

      public void SetValue(Configuration config, string item, string value)
      {
        this.item = item;
        this.value = value;

        bool found = false;
        for (int i = 0; i < config.listConfig.Count; i++)
        {
          if (config.listConfig[i].item == item)
          {
            config.listConfig[i] = this;
            found = true;
            break;
          }
        }
        
        if (found == false) config.listConfig.Add(this);
      }
      public string GetItem() => item;

      public string GetValue() => value;
    }
  }

  internal class Program
  {
    public static void Main(string[] args)
    {
      Configuration config = new Configuration();
      config.SetConfig("Version", "V 1.0");
      config.SetConfig("Size", "655,324 KB");
      
      Console.WriteLine(config.GetConfig("Version")); // "V 1.0"
      Console.WriteLine(config.GetConfig("Price"));
      
      config.SetConfig("Version", "V 2.0");
      Console.WriteLine(config.GetConfig("Version"));
    }
  }
}