﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Core.Concrete.Dtos.HelpersDto
{
    public class DeleteImageDto
    {
        public string FullName { get; set; }
        public string Extantion { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
    }
}