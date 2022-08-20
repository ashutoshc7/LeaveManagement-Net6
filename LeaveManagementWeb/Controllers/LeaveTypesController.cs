using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWeb.Data;
using AutoMapper;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagementWeb.Constants;

namespace LeaveManagementWeb.Controllers
{
    //[Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        
        public readonly ILeaveTypeRepository LeaveTypeRepository;

        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository LeaveTypeRepository,IMapper mapper,ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.LeaveTypeRepository = LeaveTypeRepository;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
              /*return _context.LeaveTypes != null ? 
                          View(await _context.LeaveTypes.ToListAsync()) ://with the help of view we are calling the database
                          Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");*/
            var leaveTypes=mapper.Map<List<LeaveTypeVM>>(await LeaveTypeRepository.GetAllAsync());//this is the model right here 
            return View(leaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           
            var leaveType = await LeaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }
        // GET: LeaveTypes/Create
        public IActionResult Create()//it is just a form that is returning the view 
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]//if no antiforgery token in the form then it would reject it
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType=mapper.Map<LeaveType>(leaveTypeVM);
                await LeaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           
            var leaveType = await LeaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM=mapper.Map<LeaveTypeVM>(leaveType);//Convert it into the view model version 
            return View(leaveTypeVM);//return the view with the view model version
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType=mapper.Map<LeaveType>(leaveTypeVM);
                    await LeaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await LeaveTypeRepository.Exists(leaveTypeVM.Id))
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
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
       

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await LeaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>AllocateLeave(int id)
        {
            await leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
