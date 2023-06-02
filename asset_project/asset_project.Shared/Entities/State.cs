﻿namespace asset_project.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public Country? Country { get; set; }

        public int CountryId { get; set; }

        public ICollection<City>? Cities { get; set; }
    }
}
