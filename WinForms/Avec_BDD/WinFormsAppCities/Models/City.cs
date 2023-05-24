using System;
using System.Collections.Generic;

namespace WinFormsAppCities.Models;

public partial class City
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public string CountryCode { get; set; } = null!;

    public virtual Country CountryCodeNavigation { get; set; } = null!;
}
