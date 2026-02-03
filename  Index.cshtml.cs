using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            //  this will Safely get the values from the form
            int hungerLevel;
            int dayOfWeek;

            bool hungerValid = int.TryParse(Request.Form["hungerLevel"], out hungerLevel);
            bool dayValid = int.TryParse(Request.Form["dayOfWeek"], out dayOfWeek);

            if (!hungerValid || !dayValid)
            {
                HungerMessage = "Invalid input. Please enter numbers only.";
                SoundMessage = "";
                DayMessage = "";
                return;
            }

            // if and else if for the hunger messgaes 
            if (hungerLevel >= 8)
            {
                HungerMessage = "Lion: Roar! I need a large meal red meat ";
            }
            else if (hungerLevel >= 5)
            {
                HungerMessage = "Monkey: I need fruits! ";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and large i need veggies ";
            }

            
            
            SoundMessage = hungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            
            //  this will Switch for zoo events by day
            
            switch (dayOfWeek)
            {
                case 1: DayMessage = "Sunday: Penguin Parade at 10 AM!"; break;
                case 2: DayMessage = "Monday: Giraffe feeding at 2 PM!"; break;
                case 3: DayMessage = "Tuesday: Elephant bath at 11 AM!"; break;
                case 4: DayMessage = "Wednesday: Bird show at 1 PM!"; break;
                case 5: DayMessage = "Thursday: Reptile exhibit at 3 PM!"; break;
                case 6: DayMessage = "Friday: Lion encounter at 12 PM!"; break;
                case 7: DayMessage = "Saturday: Zoo scavenger hunt at 9 AM!"; break;
                default: DayMessage = "Invalid day. Please enter a number from 1 to 7."; break;
            }
        }
    }
}

