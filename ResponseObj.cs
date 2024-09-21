using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("appearance")]
    public string appearance { get; set; }

    [JsonProperty("atomic_mass")]
    public double atomicmass { get; set; }

    [JsonProperty("boil")]
    public double boil { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

    [JsonProperty("density")]
    public double density { get; set; }

    [JsonProperty("discovered_by")]
    public string discoveredby { get; set; }

    [JsonProperty("melt")]
    public double melt { get; set; }

    [JsonProperty("molar_heat")]
    public double molarheat { get; set; }

    [JsonProperty("named_by")]
    public string namedby { get; set; }

    [JsonProperty("number")]
    public int number { get; set; }

    [JsonProperty("period")]
    public int period { get; set; }

    [JsonProperty("group")]
    public int group { get; set; }

    [JsonProperty("phase")]
    public string phase { get; set; }

    [JsonProperty("source")]
    public string source { get; set; }

    [JsonProperty("summary")]
    public string summary { get; set; }

    [JsonProperty("symbol")]
    public string symbol { get; set; }

    [JsonProperty("xpos")]
    public int xpos { get; set; }

    [JsonProperty("ypos")]
    public int ypos { get; set; }

    [JsonProperty("wxpos")]
    public int wxpos { get; set; }

    [JsonProperty("wypos")]
    public int wypos { get; set; }

    [JsonProperty("shells")]
    public int[] shells { get; set; }

    [JsonProperty("electron_configuration")]
    public string electronconfiguration { get; set; }

    [JsonProperty("electron_configuration_semantic")]
    public string electronconfigurationsemantic { get; set; }

    [JsonProperty("electron_affinity")]
    public double electronaffinity { get; set; }

    [JsonProperty("electronegativity_pauling")]
    public double electronegativitypauling { get; set; }

    [JsonProperty("ionization_energies")]
    public int[] ionizationenergies { get; set; }

    [JsonProperty("cpk-hex")]
    public string cpkhex { get; set; }

    [JsonProperty("block")]
    public string block { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
