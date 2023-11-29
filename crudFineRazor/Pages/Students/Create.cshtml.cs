<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
>>>>>>> c3b7dbcdb26dd366b88468b83e48c595b21dda39
using crudFineRazor.Data;
using crudFineRazor.Models;

namespace crudFineRazor.Pages_Students
{
    public class CreateModel : PageModel
    {
<<<<<<< HEAD
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
=======
        private readonly crudFineRazor.Data.ApplicationDbContext _context;

        public CreateModel(crudFineRazor.Data.ApplicationDbContext context)
>>>>>>> c3b7dbcdb26dd366b88468b83e48c595b21dda39
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;
<<<<<<< HEAD

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Students == null || Student == null)
=======
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Students == null || Student == null)
>>>>>>> c3b7dbcdb26dd366b88468b83e48c595b21dda39
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
