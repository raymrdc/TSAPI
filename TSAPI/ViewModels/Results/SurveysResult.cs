﻿using System.Collections.Generic;
using TSAPI.Public.Domain.Metadata;

namespace TSAPI.ViewModels.Result
{
    public class SurveysResult : ApiResult
    {
        public List<SurveyDetail> Result { get; set; }
    }
}
