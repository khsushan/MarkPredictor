﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkPredictor.Dto
{
    public class ModuleDto
    {
        public long Id { get; set; }

        public string ModuleName { get; set; }

        public long LevelId { get; set; }

        public long CourseId { get; set; }

        public double Credit { get; set; }

        public ICollection<AssessmentDto> Assessments { get; set; }
    }
}
