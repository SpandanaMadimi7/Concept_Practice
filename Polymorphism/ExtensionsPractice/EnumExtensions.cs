using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.ExtensionsPractice
{
    public static class EnumExtensions
    {
        public static Season Next(this Season season){
            int value = (int)season;
            int next = (value + 1) % 4;
            return (Season)next;
        }
    }
}
