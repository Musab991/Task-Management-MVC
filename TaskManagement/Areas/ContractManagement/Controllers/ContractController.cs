namespace TaskManagement.Area.ContractManagement.Controllers;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models.Basket;
using TaskManagement.Models.Entities;

[Area("ContractManagement")]
public class ContractController : Controller
{
    public IActionResult Index()
    {
        // Fake data until API integration
        var data = new List<ContractDto>
            {
                new ContractDto { Id = 1, ContractName = "Contract A", StartDate = "2024-01-01", EndDate = "2025-01-01" },
                new ContractDto { Id = 2, ContractName = "Contract B", StartDate = "2024-02-01", EndDate = "2025-02-01" }
            };
        var basket = new BasketViewModel<ContractDto>
        {
            Items = data,
            Columns = new List<BasketColumn>
    {
        new BasketColumn("Id", "ID"),
        new BasketColumn("ContractName", "Contract Name"),
        new BasketColumn("StartDate", "Start Date"),
        new BasketColumn("EndDate", "End Date")
    }
        };

        return View(basket);
    }
}

