using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission_4.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext blahContext { get; set; }

        public HomeController(ApplicationContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            //The ViewBag will build dynamic variable that is a list of all the categories
            ViewBag.Categories = blahContext.Categories.ToList();  

            return View("Form");
        }

        [HttpPost]
        public IActionResult Form(FormResponse fr)
        {
            if (!ModelState.IsValid)  //This is saying, if the information entered into the form is NOT valid, just return the form with the error messages
            {
                ViewBag.Categories = blahContext.Categories.ToList();

                return View("Form"); //This keeps them on the form page
            }
            
            else
            {
                blahContext.Add(fr);  //Else, add and save the changes to the database
                blahContext.SaveChanges();

                return View("Confirmation", fr); 
            }
            
        }

        public IActionResult Podcast()
        {
            return View("Podcasts");
        }

        [HttpGet]
        public IActionResult DataTable()
        {
            var movieTable = blahContext.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title) //Order by movie title
                .ToList(); //This takes all of the data and prints it into a list

            return View(movieTable);
        }

        [HttpGet]
        public IActionResult Edit (int formid) //Put formid as a parameter. This will recieve the specific formid when the user clicks on the edit button
        {
            ViewBag.Categories = blahContext.Categories.ToList(); //Need this line so that the form loads with the prepackaged list of Categories in the dropdown menu

            //The line below is going to fill the edit form with all of the information of the record that's already been entered intto the database.
            var response_to_edit = blahContext.Movies.Single(x => x.FormId == formid);  //It's saying to go to blahContext, then to the Movies table in the database,
                                                                                        //then choose a single record in the table where the FormId is equal to the formid
                                                                                        //variable we made. This record is then packaged into a variable called "response_to_edit"


            return View("Form", response_to_edit); //You want to send them back to the Form.cshtml page WITH the data in the record you want to edit
        }

        [HttpPost]
        public IActionResult Edit(FormResponse edited_record)
        {
            blahContext.Update(edited_record); //When the user clicks submit on the edited record, it will now update the context file and
                                               //database table with that edited record

            blahContext.SaveChanges(); //Save edits

            return RedirectToAction("DataTable");  //Use RedirectToAction instead of View because you've already set up a DataTable View in the
                                                   //HomeController that passes is all of the data. If you only used View("DataTable"); it would
                                                   //return an error because none of the data would be passed through
        }

        [HttpGet]
        public IActionResult Delete(int formid)
        {
            var response_to_delete = blahContext.Movies.Single(x => x.FormId == formid);

            return View(response_to_delete);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse del) //This loads the object you want to delete into the variable "del"
        {
            blahContext.Movies.Remove(del); //Go to blahContext, then the Movies table, then remove the record stored in the "del" variable
            blahContext.SaveChanges();

            return RedirectToAction("DataTable");
        }



    }
}
