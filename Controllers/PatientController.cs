using Microsoft.AspNetCore.Mvc;

namespace Radiologics_Medikal_Intern_.Controllers;

[ApiController]
[Route("[controller]")]


public class patientController : ControllerBase
{
    private static readonly string[] name = new[]
    {
        "James", "Robert","Mary","Patricia","Jennifer","Michael","David","Elizabeth"
    };

    private static readonly string[] disease = new[]
    {
        "Cancer", "Diabetes", "AIDS", "HIV", "Ebola", "Malaria", "Tuberculosis", "Dengue"
    };

    private readonly ILogger<patientController> _logger;

    public patientController(ILogger<patientController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Patient> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Patient
        {
            Name = name[Random.Shared.Next(name.Length)],
            Id = Random.Shared.Next(1, 1000),
            Disease = disease[Random.Shared.Next(disease.Length)]
        })
        .ToArray();
    }
}
