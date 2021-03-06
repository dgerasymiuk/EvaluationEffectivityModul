﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EvaluationOfEffectivenessModul.Services
{
    class MainFormServices
    {
       public static long getCostMultiSuccess(ICollection<Investment> list)
        {
            long res = 0;
            foreach (Investment item in list)
            {
                res += item.cashFlov * item.salesRevenue;
            }
            return res;
        }
    }
}
