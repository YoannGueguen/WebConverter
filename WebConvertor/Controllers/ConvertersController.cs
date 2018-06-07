using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dal;
using DomainModel;

namespace WebConvertor.Controllers
{
    public class ConvertersController : Controller
    {
        private readonly ConverterContext _context;

        public ConvertersController(ConverterContext context)
        {
            _context = context;
        }

        // GET: Converters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Converters.ToListAsync());
        }

        // GET: Converters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var converter = await _context.Converters
                .SingleOrDefaultAsync(m => m.ConvertId == id);
            if (converter == null)
            {
                return NotFound();
            }

            return View(converter);
        }

        // GET: Converters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Converters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConvertId,TypeOfConvert,NumbertoConvert,NumberConverted")] Converter converter)
        {
            if (ModelState.IsValid)
            {
                switch (converter.TypeOfConvert)
                {
                    case "KilometersToMiles":
                        converter.NumberConverted = Test.TestConverter.GivenConvertKilometersToMiles(converter.NumbertoConvert);
                        break;
                    case "MilestoKilometers":
                        converter.NumberConverted = Test.TestConverter.GivenConvertMilesToKilometers(converter.NumbertoConvert);
                        break;
                    case "KilometersToInch":
                        converter.NumberConverted = Test.TestConverter.GivenConvertKilometersToInch(converter.NumbertoConvert);
                        break;
                    case "InchToKilometers":
                        converter.NumberConverted = Test.TestConverter.GivenConvertInchToKilometers(converter.NumbertoConvert);
                        break;
                }

                _context.Add(converter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(converter);
        }

        // GET: Converters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var converter = await _context.Converters.SingleOrDefaultAsync(m => m.ConvertId == id);
            if (converter == null)
            {
                return NotFound();
            }
            return View(converter);
        }

        // POST: Converters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConvertId,TypeOfConvert,NumbertoConvert,NumberConverted")] Converter converter)
        {
            if (id != converter.ConvertId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    switch (converter.TypeOfConvert)
                    {
                        case "KilometersToMiles":
                            converter.NumberConverted = Test.TestConverter.GivenConvertKilometersToMiles(converter.NumbertoConvert);
                            break;
                        case "MilestoKilometers":
                            converter.NumberConverted = Test.TestConverter.GivenConvertMilesToKilometers(converter.NumbertoConvert);
                            break;
                        case "KilometersToInch":
                            converter.NumberConverted = Test.TestConverter.GivenConvertKilometersToInch(converter.NumbertoConvert);
                            break;
                        case "InchToKilometers":
                            converter.NumberConverted = Test.TestConverter.GivenConvertInchToKilometers(converter.NumbertoConvert);
                            break;
                    }
                    _context.Update(converter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConverterExists(converter.ConvertId))
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
            return View(converter);
        }

        // GET: Converters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var converter = await _context.Converters
                .SingleOrDefaultAsync(m => m.ConvertId == id);
            if (converter == null)
            {
                return NotFound();
            }

            return View(converter);
        }

        // POST: Converters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var converter = await _context.Converters.SingleOrDefaultAsync(m => m.ConvertId == id);
            _context.Converters.Remove(converter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConverterExists(int id)
        {
            return _context.Converters.Any(e => e.ConvertId == id);
        }
    }
}
