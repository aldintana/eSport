﻿namespace eSport.Model
{
    public class BaseSearchRequest
    {
        public string TekstPretraga { get; set; }
        public string[] IncludeList { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
