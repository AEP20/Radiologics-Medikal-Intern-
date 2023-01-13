using Microsoft.AspNetCore.Mvc;

namespace Radiologics_Medikal_Intern_.Controllers;

[ApiController]
[Route("[controller]")]


public class PatientController : ControllerBase
{
    private static readonly string[] PatientsName = new[]
    {
        "Richard", "Benjamin", "Tobin", "Winston", "Hale", "Posey"
    };

    private static readonly int[] PatientsId = new[]
    {
        123123, 123124, 123125, 123126, 123127, 123128
    };
    
    private static readonly string[] PatientsDisease = new[]
    {
        "Cancer", "Acne", "Allergies", "Asthma", "Diarrhea", "Dysentery"
    };

    //create a get method to get all patients with their name, id and disease 

    [HttpGet]
    public IEnumerable<Patient> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Patient
        {
            Name = PatientsName[Random.Shared.Next(PatientsName.Length)],
            Id = PatientsId[Random.Shared.Next(PatientsId.Length)],
            Disease = PatientsDisease[Random.Shared.Next(PatientsDisease.Length)]
        })
        .ToArray();
    }



}
