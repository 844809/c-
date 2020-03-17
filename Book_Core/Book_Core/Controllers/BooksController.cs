using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Book_Core.Datalayer;
using Book_Core.Models;

namespace Book_Core.Controllers
{
    public class BooksController : Controller
    {
        private readonly Context _context;

        public BooksController(Context context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index(string bookcategory,string searchstr,string Publisherssear)
        {
            IQueryable<string> categoryquery = from b in _context.Books
                                               orderby b.Category
                                               select b.Category;

            var books = from b in _context.Books
                        select b;

            IQueryable<string> publisherquery = from b in _context.Books
                                               orderby b.Publisher
                                               select b.Publisher;

            if (!String.IsNullOrEmpty(searchstr))
            {
                books = books.Where(b => b.Btitle.Contains(searchstr));
            }
            if(!String.IsNullOrEmpty(bookcategory))
            {
                books = books.Where(x => x.Category == bookcategory);
            }
            if(!string.IsNullOrEmpty(Publisherssear))
            {
                books = books.Where(b => b.Publisher==Publisherssear);
            }
            var bookcategoryVM = new BookCategory
            {
                Categories = new SelectList(await categoryquery.Distinct().ToListAsync()),
                Books = await books.ToListAsync(),
                Publishers=new SelectList(await publisherquery.Distinct().ToListAsync())
            };
            return View(bookcategoryVM);
            //return View(await _context.Books.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bid,Btitle,Category,Price,AuthorName,Publisher,Releasedate")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bid,Btitle,Category,Price,AuthorName,Publisher,Releasedate")] Book book)
        {
            if (id != book.Bid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Bid))
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
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Bid == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Bid == id);
        }
    }
}
