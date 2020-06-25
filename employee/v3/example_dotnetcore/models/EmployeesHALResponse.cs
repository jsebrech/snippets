﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace EmployeeExample.models
{
    public class EmployeesHALResponse
    {
        public Links _links { get; set; }

        public Embedded _embedded { get; set; }

        public Page _page { get; set; }
    }

    public class Embedded
    {
        [JsonProperty("employees")]
        public List<Employee> Employees { get; set; }
    }

    public class Page
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class LinkReference
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public LinkReference Self { get; set; }

        [JsonProperty("first")]
        public LinkReference First { get; set; }

        [JsonProperty("last")]
        public LinkReference Last { get; set; }

        [JsonProperty("next")]
        public LinkReference Next { get; set; }

        [JsonProperty("prev")]
        public LinkReference Previous { get; set; }
    }
}
