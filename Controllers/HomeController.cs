using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Manticora.Models;
using System.Threading.Tasks;

namespace Manticora.Controllers;

public class HomeController : Controller
{
    private static Game _currentGame;
    private static List<Weapon> _shopItems = new List<Weapon>
    {
        new Weapon { Name = "Gran cañón", Cost = 80, Range = 50 },
        new Weapon { Name = "Metralla", Cost = 60, Range = 40 },
        new Weapon { Name = "Mosquete", Cost = 50, Range = 30 },
        new Weapon { Name = "Pistola", Cost = 30, Range = 20 },
        new Weapon { Name = "Granada", Cost = 10, Range = 10 }
    };

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> StartGame(int defender1Id, int defender2Id)
    {
        HttpClient _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/");

        var url = "character/";
      

        var response = await  _httpClient.GetAsync(url);
        var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponsePersonajes>();
        _currentGame = new Game
        {
            Defenders = apiResponse.Results.ToArray(),
            ManticorePosition = new Random().Next(1, 6) * 10
        };

        return RedirectToAction("Shop");
    }

    public IActionResult Shop()
    {
        ViewBag.ShopItems = _shopItems;
        return View(_currentGame);
    }

    [HttpPost]
    public IActionResult BuyWeapon(int defenderIndex, int weaponIndex)
    {
        var defender = _currentGame.Defenders[defenderIndex];
        var weapon = _shopItems[weaponIndex];

        if (defender.Gold >= weapon.Cost)
        {
            defender.Weapons.Add(weapon);
            defender.Gold -= weapon.Cost;
        }

        return RedirectToAction("Shop");
    }

    public IActionResult Battle()
    {
        return View(_currentGame);
    }

    [HttpPost]
    public IActionResult Attack(int defenderIndex, int weaponIndex)
    {
        var defender = _currentGame.Defenders[defenderIndex];
        var weapon = defender.Weapons[weaponIndex];
        var manticorePos = _currentGame.ManticorePosition;

        if (weapon.Range < manticorePos)
        {
            _currentGame.CityHealth -= 5;
        }
        else if (weapon.Range > manticorePos)
        {
            _currentGame.ManticoreHealth -= 2;
            _currentGame.CityHealth -= 1;
        }
        else
        {
            _currentGame.ManticoreHealth -= 5;
        }

        int newPos;
        do
        {
            newPos = new Random().Next(1, 6) * 10;
        } while (newPos == manticorePos);

        _currentGame.ManticorePosition = newPos;
        _currentGame.Turn++;

        if (_currentGame.ManticoreHealth <= 0 || _currentGame.CityHealth <= 0)
        {
            return RedirectToAction("GameOver");
        }

        return RedirectToAction("Battle");
    }

    public IActionResult GameOver()
    {
        return View(_currentGame);
    }

    #region Clases   API

    private class ApiResponsePersonajes
    {
        public List<Character> Results { get; set; }
    }

    private class ApiResponseCount
    {
        public Info Info { get; set; }
    }

    private class Info
    {
        public int Count { get; set; }
    }

    private class LocationApiResponse
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimension { get; set; }
        public string[] Residents { get; set; }
    }

    #endregion
}