using System;
using RepeatCounterNS.Objects;
using Nancy;
using System.Collections.Generic;

namespace FindAndReplaceNS.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["new-input1"], Request.Form["new-input2"]);
        int result = newRepeatCounter.CountRepeats();
        return View["results.cshtml", result];
      };
    }
  }
}
