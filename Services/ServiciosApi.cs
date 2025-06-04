using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Manticora.Models;
using Manticora.Services;
using Newtonsoft.Json;

public class ServiciosApi
{
 
    //public async Task<List<Personaje>> CargarPersonajesDesdeAPI(string filtroNombre = null)
    //{
    //    try
    //    {
    //        HttpClient _httpClient = new HttpClient();
    //        _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/");

    //        var url = "character/";
    //        if (!string.IsNullOrEmpty(filtroNombre))
    //        {
    //            url += $"?name={filtroNombre}";
    //        }

    //        var response = await _httpClient.GetAsync(url);
    //        response.EnsureSuccessStatusCode();

    //        var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponsePersonajes>();
    //        return apiResponse?.Results ?? new List<Personaje>();
    //    }
    //    catch (HttpRequestException)
    //    {
            
    //    }
    //    return new List<Personaje>();
    //}

    //#region Clases   API

    //private class ApiResponsePersonajes
    //{
    //    public List<Personaje> Results { get; set; }
    //}

    //private class ApiResponseCount
    //{
    //    public Info Info { get; set; }
    //}

    //private class Info
    //{
    //    public int Count { get; set; }
    //}

    //private class LocationApiResponse
    //{
    //    public string Name { get; set; }
    //    public string Type { get; set; }
    //    public string Dimension { get; set; }
    //    public string[] Residents { get; set; }
    //}

    //#endregion
}