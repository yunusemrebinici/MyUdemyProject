﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.AboutDtos
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }

        public string Title1 { get; set; }

        public string Title2 { get; set; }

        public string Content { get; set; }
    }
}
