using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using zadanie03.Models;
using Microsoft.AspNetCore.Authorization;

namespace zadanie03.Pages
{   
   
    public class SearchesModel : PageModel
    {   
        public List<Num> ListOfSearches { get; set; }

        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");

            if(SessionFizzBuzz != null)
            {
                ListOfSearches = JsonConvert.DeserializeObject<List<Num>>(SessionFizzBuzz);
            }
        }
    }
}
