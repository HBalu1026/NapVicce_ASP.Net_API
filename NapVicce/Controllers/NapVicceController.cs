using Microsoft.AspNetCore.Mvc;

namespace NapVicce.Controllers
{
    public class NapVicceController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public string Get()
        {
            List<string> viccek = new List<string>() {"-Mi az kívül sárga belül fekete? - Sok néger ül a villamoson.", 
                "-Mi az ha feldobod fekete és ha leesik nyávog? -Mindegy csak macskára essen!", 
                "-Hogy hívják a meleg juhot? - Homo-kos.", 
                "-Mi a villamos többesszáma? -Villák mosnak.",
                "-Miből építették a trójai falovat? - Kicseszésből.",
                "-Hány politikus kell egy villanykörte kicseréléséhez? - Kettő. Egyik kicseréli, a másik pedig kiszivárogtatja a sajtónak.",
                "-Mit hiányol egy FIDESz-es politikus egy értelmiségi vacsoráról? -A meghívást."};
            string vicc = "";
            string date = DateTime.Now.DayOfWeek.ToString();
            if (date == "Monday")
            {
                vicc = viccek[0];
            }
            else if (date == "Tuesday")
            {
                vicc = viccek[1];
            }
            else if (date == "Wednesday")
            {
                vicc = viccek[2];
            }
            else if (date == "Thursday")
            {
                vicc = viccek[3];
            }
            else if (date == "Friday")
            {
                vicc = viccek[4];
            }
            else if (date == "Saturday")
            {
                vicc = viccek[5];
            }
            else if (date == "Sunday")
            {
                vicc = viccek[6];
            }

            return vicc;
        }
    }
}
