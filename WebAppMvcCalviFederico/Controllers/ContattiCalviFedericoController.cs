using Microsoft.AspNetCore.Mvc;

namespace WebAppMvcCalviFederico.Controllers;
public class ContattiCognomeNomeController : Controller
{
    public IActionResult Contatti()
    {
        // Inizializza l'oggetto ViewData con la chiave "Contatti"
        ViewData["Contatti"] = "VerificaCognomeNome";

        // Richiama la pagina associata all'azione
        return View();
    }
}

