using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvenMoreAmazingTaskList.Domain.Entities;
using EvenMoreAmazingTaskList.Infrastructure;
using EvenMoreAmazingTaskList.Domain.Services;

namespace EvenMoreAmazingTaskList.WebApp.Controllers
{
    public class TaskItemsController : Controller
    {
        private readonly TaskListService _service;

        public TaskItemsController(TaskListService service)
        {
            _service = service;
        }

        // GET: TaskItems
        public IActionResult Index()
        {
            return View(_service.GetAllTaskItems());
        }

        // GET: TaskItems/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var taskItem = await _service.TaskItems
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (taskItem == null)
            //{
            //    return NotFound();
            //}

            //return View(taskItem);
            return NotFound();
        }

        // GET: TaskItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                taskItem.Id = Guid.NewGuid();
                _service.AddTaskItem(taskItem);
                return RedirectToAction(nameof(Index));
            }
            return View(taskItem);
        }

        // GET: TaskItems/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var taskItem = await _service.TaskItems.FindAsync(id);
            //if (taskItem == null)
            //{
            //    return NotFound();
            //}
            //return View(taskItem);
            return NotFound();
        }

        // POST: TaskItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description")] TaskItem taskItem)
        {
            //if (id != taskItem.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _service.Update(taskItem);
            //        await _service.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!TaskItemExists(taskItem.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(taskItem);
            return NotFound();
        }

        // GET: TaskItems/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var taskItem = await _service.TaskItems
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (taskItem == null)
            //{
            //    return NotFound();
            //}

            //return View(taskItem);
            return NotFound();
        }

        // POST: TaskItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            //var taskItem = await _service.TaskItems.FindAsync(id);
            //_service.TaskItems.Remove(taskItem);
            //await _service.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            throw new NotImplementedException();
        }

        private bool TaskItemExists(Guid id)
        {
            //return _service.TaskItems.Any(e => e.Id == id);
            throw new NotImplementedException();
        }
    }
}
