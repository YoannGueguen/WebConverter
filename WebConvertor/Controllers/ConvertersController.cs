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

            return RedirectToAction(nameof(Details) + "/" + id);
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
                ExecuteTypeOfConverter(converter.TypeOfConvert, converter);
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
            return RedirectToAction(nameof(Edit) + "/" + id);
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
                    ExecuteTypeOfConverter(converter.TypeOfConvert, converter);
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

            return RedirectToAction(nameof(Delete) + "/" + id);
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
        private void ExecuteTypeOfConverter(string typeOfConverter, Converter converter)
        {
            switch (typeOfConverter)
            {
                case "KilometerToMiles":
                    converter.NumberConverted = Test.TestConverter.GivenMilesConverterKilometerToMiles_0_621371192(converter.NumbertoConvert);
                    break;
                case "MilesToKilometer":
                    converter.NumberConverted = Test.TestConverter.GivenKilometerConverterMilesToKilometer_1_609344(converter.NumbertoConvert);
                    break;
                case "KilometerToInch":
                    converter.NumberConverted = Test.TestConverter.GivenInchConverterKilometerToInch_39370_0787401578(converter.NumbertoConvert);
                    break;
                case "InchToKilometer":
                    converter.NumberConverted = Test.TestConverter.GivenKilometerConverterInchToKilometer_0_3048(converter.NumbertoConvert);
                    break;
                case "KilometerToFoot":
                    converter.NumberConverted = Test.TestConverter.GivenFootConverterKilometerToFoot_0_0000254(converter.NumbertoConvert);
                    break;
                case "FootToKilometer":
                    converter.NumberConverted = Test.TestConverter.GivenKilometerConverterFootToKilometer_3280_0839895013128(converter.NumbertoConvert);
                    break;
                case "KilometerToYard":
                    converter.NumberConverted = Test.TestConverter.GivenYardConverterKilometerToYard_1093_61329834(converter.NumbertoConvert);
                    break;
                case "YardToKilometer":
                    converter.NumberConverted = Test.TestConverter.GivenKilometerConverterYardToKilometer_0_0009144(converter.NumbertoConvert);
                    break;
            }
        }
    }
}
