﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.TagCloudDtos
{
    public class ResultGetByBlogIdTagCloudDto
    {
        public int TagCloudId { get; set; }

        public string Title { get; set; }

        public int BlogId { get; set; }
    }
}
