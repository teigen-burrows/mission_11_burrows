using Microsoft.AspNetCore.Mvc;
using mission_11_burrows.Models;
using mission_11_burrows.Models.ViewModels;

namespace mission_11_burrows.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var viewModel = new IndexViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(viewModel);
        }

    }
}
