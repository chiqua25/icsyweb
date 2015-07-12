using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace IcsyMvc.Models
{
    public enum ScienceActivityEnum
    {
        None = 0,

        [Description("Life Science")]
        LifeScience = 1,
        
        [Description("Physical Science")]
        PhysicalScience = 2,

        [Description("Earth Science")]
        EarthScience = 3,
        
        [Description("Space Science")]
        SpaceScience = 4,
        Weather = 5,
        Chemistry = 6,
        Nature = 7

    }
}