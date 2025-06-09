using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherApi.Data
{
    public class WeatherHistory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime SearchTime { get; set; }
    }
} 