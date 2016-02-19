using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace RepeatCounterNS.Objects
{
  public class RepeatCounter
  {
    private string _input1;
    private string _input2;

    public RepeatCounter(string myInput1, string myInput2)
    {
      _input1 = myInput1;
      _input2 = myInput2;
    }

    public int CountRepeats()
    {
      int repeatCount = 0;
      string[] phraseArray = _input1.Split(' ');
      for (var i = 0; i < phraseArray.Length; i++)
      {
        if (phraseArray[i].ToLower().Contains(_input2.ToLower()))
        {
          repeatCount += 1;
        }
      }
      return repeatCount;
    }
  }
}
