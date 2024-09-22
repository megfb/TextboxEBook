using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using TextbokBook.Business.Abstract;
using TextboxBook.Entity.Concrete;
using TextboxBook.UI.Identity;
using TextboxBook.UI.Models;

namespace TextboxBook.UI.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        private ILanguageService _languageService;
        private IPublisherService _publisherService;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private ICountryService _countryService;
        private IGenderService _genderService;
        private ICommentService _commentService;
        private IOrderService _orderService;
        public AdminController(IBookService bookService,
            ICategoryService categoryService,
            IAuthorService authorService,
            ILanguageService languageService,
            IPublisherService publisherService,
            UserManager<ApplicationUser>userManager,
            RoleManager<ApplicationRole>roleManager,
            IGenderService genderService,
            ICountryService countryService,
            ICommentService commentService,
            IOrderService orderService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _authorService = authorService;
            _languageService = languageService;
            _publisherService = publisherService;
            _userManager = userManager;
            _roleManager = roleManager;
            _countryService = countryService;
            _genderService = genderService;
            _commentService = commentService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            var model = new BookAddViewModel()
            {
                Book = new Book(),
                Categories = _categoryService.GetAll(),
                Authors = _authorService.GetAll(),
                Languages = _languageService.GetAll(),
                Publishers = _publisherService.GetAll(),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
                TempData.Add("Success", $"{book.Name} successfully added");
                return RedirectToAction("AddBook");
            }

            TempData.Add("Alert", $"Error: {book.Name} could not be added");
            return View();

        }

        [HttpGet]
        public IActionResult ListBook(int page = 1, int Category = 0)
        {
            int pageSize = 10;
            var books = _bookService.GetByCategory(Category);

            var model = new BookListViewModel()
            {
                Book = books.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(books.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = Category,
                CurrentPage = page,
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult EditBook(int Id)
        {
            var model = new BookEditViewModel()
            {
                Book = _bookService.GetById(Id),
                Categories = _categoryService.GetAll(),
                Authors = _authorService.GetAll(),
                Languages = _languageService.GetAll(),
                Publishers = _publisherService.GetAll(),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(book);
                TempData.Add("Success", $"{book.Name} successfully updated");
                return RedirectToAction("listbook");
            }
            TempData.Add("Alert", $"Error: {book.Name} could not be updated");
            return View();
        }

        [HttpGet]
        public IActionResult DetailBook(int Id)
        {

            var model = new BookViewModel()
            {
                Book = _bookService.GetById(Id),

            };


            return View(model);
        }

        public IActionResult DeleteBook(int Id)
        {
            _bookService.Delete(Id);
            TempData.Add("Success", "Book successfully deleted");

            return RedirectToAction("listbook");
        }

        public IActionResult ListAuthor()
        {
            var model = new AuthorListViewModel()
            {
                Authors = _authorService.GetAll(),
            };

            return View(model);
        }

        public IActionResult DeleteAuthor(int id)
        {

            _authorService.Delete(id);

            return RedirectToAction("listauthor", "admin");
        }

        public IActionResult DetailAuthor(int id)
        {

            var model = new AuthorViewModel()
            {
                Author = _authorService.GetById(id)

            };

            return View(model);
        }

        public IActionResult AddAuthor()
        {

            var model = new AuthorAddViewModel()
            {
                Author = new Author(),
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {

            if (ModelState.IsValid)
            {
                _authorService.Add(author);
                TempData.Add("Success", $"{author.Name} successfully added");
                return RedirectToAction("addauthor", "admin");

            }
            TempData.Add("Alert", $"Error: {author.Name} could not be added");
            return View();
        }


        [HttpGet]
        public IActionResult EditAuthor(int id)
        {

            var model = new AuthorViewModel()
            {
                Author = _authorService.GetById(id),
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult EditAuthor(Author author)
        {
            if (ModelState.IsValid)
            {
                _authorService.Update(author);
                TempData.Add("Success", $"{author.Name} successfully updated");
                return RedirectToAction("listauthor", "admin");
            }
            TempData.Add("Alert", $"Error: {author.Name} could not be updated");
            return View();
        }

        public IActionResult ListCategory()
        {
            var model = new CategoryListViewModel()
            {
                categoryList = _categoryService.GetAll(),
            };


            return View(model);
        }
        public IActionResult AddCategory()
        {
            var model = new CategoryAddViewModel()
            {
                Category = new Category()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                TempData.Add("Success", "Category successfully added");
                return RedirectToAction("addcategory", "admin");

            }
            TempData.Add("Alert", "Error: Category could not be added");
            return View();
        }
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.Delete(id);
            TempData.Add("Success", "Category successfully deleted");

            return RedirectToAction("listcategory", "admin");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var model = new CategoryViewModel()
            {
                Category = _categoryService.GetById(id),
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                TempData.Add("Success", "Category successfully updated");

                return RedirectToAction("listcategory", "admin");
            }
            TempData.Add("Alert", "Error: Category could not be updated");
            return View();
        }
        public IActionResult ListPublisher()
        {
            var model = new PublisherListViewModel()
            {
                Publisher = _publisherService.GetAll(),
            };

            return View(model);
        }

        public IActionResult DeletePublisher(int id)
        {

            _publisherService.Delete(id);
            TempData.Add("Success", "Publisher successfully deleted");
            return RedirectToAction("listpublisher", "admin");
        }
        public IActionResult AddPublisher()
        {
            var model = new PublisherAddViewModel()
            {
                Publisher = new Publisher()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddPublisher(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _publisherService.Add(publisher);
                TempData.Add("Success", $"{publisher.Name} successfully added");
                return RedirectToAction("AddPublisher", "admin");
            }

            TempData.Add("Alert", $"Error: {publisher.Name} could not be added");
            return View();
        }
        [HttpGet]
        public IActionResult EditPublisher(int id)
        {

            var model = new PublisherEditViewModel()
            {
                Publisher = _publisherService.GetById(id)
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult EditPublisher(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _publisherService.Update(publisher);
                TempData.Add("Success", $"{publisher.Name} successfully updated");
                return RedirectToAction("listpublisher", "admin");
            }
            TempData.Add("Alert", $"Error: {publisher.Name} could not be added");
            return View();
        }

        public IActionResult DetailPublisher(int id)
        {
            var model = new PublisherDetailViewModel()
            {
                Publisher = _publisherService.GetById(id),
            };
            return View(model);
        }

        public IActionResult AddLanguage()
        {
            var model = new LanguageAddviewModel()
            {
                Language = new Language(),
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddLanguage(Language language)
        {
            if (ModelState.IsValid)
            {
                _languageService.Add(language);
                TempData.Add("Success", $"{language.Name} successfully added");
                return RedirectToAction("AddLanguage", "admin");

            }
            TempData.Add("Alert", $"Error: {language.Name} could not be added");
            return View();
        }

        public IActionResult ListLanguage()
        {
            var model = new LanguageListViewModel()
            {
                Language = _languageService.GetAll(),
            };
            return View(model);
        }
        public IActionResult DeleteLanguage(int id)
        {
            _languageService.delete(id);
            TempData.Add("Success", "Language successfully deleted");
            return RedirectToAction("listlanguage", "admin");
        }
        [HttpGet]
        public IActionResult EditLanguage(int id)
        {
            var model = new LanguageEditViewModel()
            {
                Language = _languageService.GetById(id),
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult EditLanguage(Language language)
        {

            if (ModelState.IsValid)
            {
                _languageService.Update(language);
                TempData.Add("Success", $"{language.Name} successfully updated");
                return RedirectToAction("listlanguage", "admin");
            }
            TempData.Add("Alert", $"{language.Name} successfully updated");
            return View();
        }

        [HttpGet]
        public IActionResult DetailLanguage(int id)
        {

            var model = new LanguageDetailViewModel()
            {
                Language = _languageService.GetById(id),
            };

            return View(model);
        }
        public IActionResult UserList()
        {

            var UserList = new UserListViewModel()
            {
                UsersList = _userManager.Users
            };

            return View(UserList);
        }

        public async Task<IActionResult> UserDetail(string Id, int countryId, int genderId)
        {
            var GetUser = await _userManager.Users.Include(p => p.Country).Include(p => p.Gender).FirstOrDefaultAsync(p => p.Id == Id);
            var model = new UserDetailViewModel()
            {
                User = GetUser,
                Roles = await _userManager.GetRolesAsync(GetUser)
            };

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> UserUpdate(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);

            var model = new UserEditViewModel()
            {
                GetUser = user,
                UserRoles = await _userManager.GetRolesAsync(user),
                Roles = _roleManager.Roles.ToList(),
                Country = _countryService.GetAll(),
                Gender = _genderService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserUpdate(UserEditViewModel applicationUser)
        {
            var getUser = await _userManager.FindByIdAsync(applicationUser.GetUser.Id);
            var getRoles = await _userManager.GetRolesAsync(getUser);
            if (ModelState.IsValid)
            {
                try
                {
                    getUser.Name = applicationUser.GetUser.Name;
                    getUser.Surname = applicationUser.GetUser.Surname;
                    getUser.Email = applicationUser.GetUser.Email;
                    getUser.UserName = applicationUser.GetUser.Email;
                    getUser.NormalizedEmail = applicationUser.GetUser.Email.ToUpper();
                    getUser.NormalizedUserName = applicationUser.GetUser.Email.ToUpper();
                    getUser.Age = applicationUser.GetUser.Age;
                    getUser.GenderId = applicationUser.GetUser.GenderId;
                    getUser.CountryId = applicationUser.GetUser.CountryId;
                    await _userManager.RemoveFromRolesAsync(getUser, getRoles);
                    await _userManager.AddToRolesAsync(getUser, applicationUser.Role);
                    IdentityResult result = await _userManager.UpdateAsync(getUser);
                    TempData.Add("Success", "User Updated");
                    return RedirectToAction("userlist");

                }
                catch (Exception)
                {
                    TempData.Add("Alert", "Error");
                    return Redirect(applicationUser.GetUser.Id);
                }
            }
            TempData.Add("Alert", "Error");
            return Redirect(applicationUser.GetUser.Id);

        }

        public IActionResult NewUser()
        {
            var model = new NewUserViewModel()
            {
                Country = _countryService.GetAll(),
                Roles = _roleManager.Roles.ToList(),
                Gender = _genderService.GetAll(),
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> NewUser(NewUserViewModel newUserViewModel)
        {

            if (!ModelState.IsValid)
            {
                return View(newUserViewModel);
            }
            var user = new ApplicationUser()
            {
                UserName = newUserViewModel.EMail,
                Name = newUserViewModel.Name,
                Surname = newUserViewModel.Surname,
                Age = newUserViewModel.Age,
                GenderId = newUserViewModel.GenderId,
                CountryId = newUserViewModel.CountryId,
                Email = newUserViewModel.EMail,
            };
            if (newUserViewModel.Role == null)
            {
                TempData.Add("Alert", "Choose a role");
                return RedirectToAction("newaccount");
            }
            var result = _userManager.CreateAsync(user, newUserViewModel.Password).Result;
            if (result.Succeeded)
            {

                await _userManager.AddToRolesAsync(user, newUserViewModel.Role);
                TempData.Add("Success", "User added");
                return RedirectToAction("newuser");
            }
            return View();
        }
        public async Task<IActionResult> UserDelete(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            await _userManager.DeleteAsync(user);

            return RedirectToAction("Userlist");
        }
        public IActionResult CommentsList()
        {
            var model = new CommentHistoryViewModel()
            {
                Comments = _commentService.GetAll()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult ListOrder()
        {

            var model = new OrderListViewModel()
            {
                Order = _orderService.GetAll(),
            };

            return View(model);
        }

        public IActionResult DeleteOrder(int id)
        {
            _orderService.Delete(id);
            return RedirectToAction("listorder","admin");
        }
    }
}
