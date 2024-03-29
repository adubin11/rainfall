﻿using Newtonsoft.Json;

namespace RainfallApi.Infrastructure.EnvironmentAgency.Models;

public class Item
{
    [JsonProperty("@id")]
    public string Id { get; set; }

    public DateTime DateTime { get; set; }
    public string Measure { get; set; }
    public decimal Value { get; set; }
}