using App.Domain;
using Microsoft.AspNetCore.Mvc;


namespace App.WebAPI;

   [Route("api/[controller]")]
    [ApiController]
    
    public class BMIController : ControllerBase
    {
        private readonly TextService _textService = new();

        [HttpPost]
        public IActionResult GetBMI(BodyMassIndex bodyMassIndex)
        {
            double bmi = bodyMassIndex.Kilo / (bodyMassIndex.Boy * bodyMassIndex.Boy);
            
            _textService.SaveText($"Kilo: {bodyMassIndex.Kilo}, Boy: {bodyMassIndex.Boy}, Vücut Kitle İndeksi: {bmi}");
            
            return Ok(new { VucutKitleIndeksi = bmi });

        }
        [HttpGet("durum")]
        public IActionResult GetKiloDurumu(double bmi)
        {
            string durum;

            if (bmi < 18.5)
            {
                durum = "Zayıf";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                durum = "Normal kilolu";
            }
            else
            {
                durum = "Fazla kilolu";
            }

            return Ok(new { Durum = durum });
        }
    }

    
