﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IPSLibrary
{
   public interface IAudioBook: ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}