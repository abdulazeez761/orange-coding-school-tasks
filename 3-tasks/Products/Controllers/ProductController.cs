using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Products.Context;
using Products.Models;
using Products.Repos;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopContext _context;
        private readonly IProductsRepo _productContext;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(ShopContext context, IWebHostEnvironment hostEnvironment, IProductsRepo productRepo)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _productContext = productRepo;
        }

        // GET: Product
        public IActionResult Index(List<Product> products = null)
        {
            if (products == null)
            {
                products = _productContext.GetProducts();
            }
            return View(products);
        }
        public IActionResult SearchPage(string productName)
        {
            List<Product> products = _productContext.GetProducts();
            List<Product> filteredProducts = _context.Products.Where(product => product.ProductName.Contains(productName)).ToList();
            if (!filteredProducts.Any())
            {
                ModelState.AddModelError("", "No product found");
            }
            return View("Index", filteredProducts);
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Bind("ProductID,ProductName,ProductPrice,ProductImage,ProductDescription,ProductCategoryID")]
        public async Task<IActionResult> Create(Product product, IFormFile ProductImage)
        {
            if (product == null || ProductImage.Length == 0)
            {
                ModelState.AddModelError("CategoryImage", "Please upload a valid image.");
                return View(product);
            }
            var webRootPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/ProductsImages");

            // Ensure directory exists
            if (!Directory.Exists(webRootPath))
            {
                Directory.CreateDirectory(webRootPath);
            }

            Guid picName = Guid.NewGuid();
            string fullPath = Path.Combine(webRootPath, picName + Path.GetExtension(ProductImage.FileName));

            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                ProductImage.CopyTo(fileStream);
            }
            product.ProductImage = Path.GetFileName(fullPath);
            try
            {
                _context.Add(product);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Log the error (e.g., return a custom error view)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                return View(product);
            }

            return RedirectToAction(nameof(Index));


        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryImage", product.ProductCategoryID);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,ProductPrice,ProductImage,ProductDescription,ProductCategoryID")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
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
            ViewData["ProductCategoryID"] = new SelectList(_context.Categories, "CategoryID", "CategoryImage", product.ProductCategoryID);
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
