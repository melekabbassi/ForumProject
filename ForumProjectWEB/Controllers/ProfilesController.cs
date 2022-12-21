using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForumProjectBL.Entities;
using ForumProjectDAL;
using Microsoft.Extensions.FileProviders;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ForumProjectWEB.Controllers
{
    public class ProfilesController : Controller
    {
        /**** Images ****/
        private readonly IFileProvider fileProvider;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;
        /**** Images ****/

        private readonly ForumProjectDbContext _context;

        [Obsolete]
        public ProfilesController(ForumProjectDbContext context, IFileProvider fileProvider, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.fileProvider = fileProvider;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Profiles
        public async Task<IActionResult> Index()
        {
              return View(await _context.Profiles.ToListAsync());
        }

        // GET: Profiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.ProfileId == id);
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);
        }

        // GET: Profiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create([Bind("ProfileId,ProfilePicture,Bio")] Profile profile, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profile);
                await _context.SaveChangesAsync();
                // Code to upload image if not null
                if (file != null || file.Length != 0)
                {
                    // Create a File Info
                    FileInfo fi = new FileInfo(file.FileName);
                    // This code creates a unique file name to prevent duplications
                    // stored at the file location
                    var newFilename = profile.ProfileId + "_" + String.Format("{0:d}",
                    (DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
                    var webPath = hostingEnvironment.WebRootPath;
                    var path = Path.Combine("", webPath + @"\ImageFiles\" + newFilename);
                    // IMPORTANT: The pathToSave variable will be save on the column in the database
                    var pathToSave = @"/ImageFiles/" + newFilename;
                    // This stream the physical file to the allocate wwwroot/ImageFiles folder
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    // This save the path to the record
                    profile.ImagePath = pathToSave; /***/
                    _context.Update(profile);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles.FindAsync(id);
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Edit(int? id, [Bind("ProfileId,ProfilePicture,Bio")] Profile profile, IFormFile file)
        {
            if (id != profile.ProfileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profile);
                    await _context.SaveChangesAsync();
                    // Code to upload image if not null
                    if (file != null || file.Length != 0)
                    {
                        // Create a File Info
                        FileInfo fi = new FileInfo(file.FileName);
                        // This code creates a unique file name to prevent duplications
                        // stored at the file location
                        var newFilename = profile.ProfileId + "_" + String.Format("{0:d}",
                        (DateTime.Now.Ticks / 10) % 100000000) + fi.Extension;
                        var webPath = hostingEnvironment.WebRootPath;
                        var path = Path.Combine("", webPath + @"\ImageFiles\" + newFilename);
                        // IMPORTANT: The pathToSave variable will be save on the column in the database
                        var pathToSave = @"/ImageFiles/" + newFilename;
                        // This stream the physical file to the allocate wwwroot/ImageFiles folder
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        // This save the path to the record
                        profile.ImagePath = pathToSave; /***/
                        _context.Update(profile);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileExists(profile.ProfileId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        // GET: Profiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.ProfileId == id);
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Profiles == null)
            {
                return Problem("Entity set 'ForumProjectDbContext.Profiles'  is null.");
            }
            var profile = await _context.Profiles.FindAsync(id);
            if (profile != null)
            {
                _context.Profiles.Remove(profile);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfileExists(int? id)
        {
          return _context.Profiles.Any(e => e.ProfileId == id);
        }
    }
}
