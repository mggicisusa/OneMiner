﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneMiner.Model.UnZip
{
    interface  IUnzip
    {
        bool Unzip();
        void Init(string zipfile, string outputfile);
        void SetNExtChain(IUnzip unzip);
    }
}
