using JobTracker.Data;
using JobTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Controllers
{
    public class JobApplicationsController : Controller
    {
        private readonly AppDbContext _context;

        public JobApplicationsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var jobs = await _context.JobApplications
                .OrderByDescending(j => j.AppliedDate)
                .ToListAsync();
            return View(jobs);
        }

        public IActionResult Create()
        {
            return View(new JobApplication());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobApplication job)
        {
            if (!ModelState.IsValid) return View(job);
            _context.Add(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var job = await _context.JobApplications.FindAsync(id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, JobApplication job)
        {
            if (id != job.Id) return NotFound();
            if (!ModelState.IsValid) return View(job);
            _context.Update(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var job = await _context.JobApplications.FirstOrDefaultAsync(j => j.Id == id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.JobApplications.FindAsync(id);
            if (job != null)
            {
                _context.JobApplications.Remove(job);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}