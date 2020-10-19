using System;
using System.Collections.Generic;
using System.Text;

namespace IPSLibrary
{
  public  interface IBook :ILibraryItem
    {
        string Author { get; set; }
      
        int Pages { get; set; }
     
    }
}
