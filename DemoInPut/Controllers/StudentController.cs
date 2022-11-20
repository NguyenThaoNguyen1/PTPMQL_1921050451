using Microsoft.AspNetCore.Mvc;
using DemoInPut.Models;
 

namespace DemoInPut.Controllers
{
public class StudentController : Controller 
{
        // viết các phương thức thao tác CRUD
        //Lấy dữ liệu của đối tượng Student
        public IActionResult Index()

        {
            //Khởi tạo list student
            var StdList =new List<Student>()
            {
                new Student{ StudentID=1, StudentName="Nguyễn Văn A", Age=14},
                new Student{ StudentID=2, StudentName="Nguyễn Văn B", Age=19},
                new Student{ StudentID=3, StudentName="Nguyễn Văn C", Age=25},
                new Student{ StudentID=4, StudentName="Nguyễn Văn D", Age=17},
                new Student{ StudentID=5, StudentName="Nguyễn Văn E", Age=10},
                new Student{ StudentID=6, StudentName="Nguyễn Văn E", Age=15},
                new Student{ StudentID=7, StudentName="Nguyễn Văn H", Age=14},
                new Student{ StudentID=8, StudentName="Nguyễn Văn M", Age=19},
                new Student{ StudentID=9, StudentName="Nguyễn Văn P", Age=25},
                new Student{ StudentID=10, StudentName="Nguyễn Văn Q", Age=17},
                new Student{ StudentID=11, StudentName="Nguyễn Văn T", Age=10},
                new Student{ StudentID=15, StudentName="Nguyễn Văn E", Age=15},



            };
            // ViewBag.DanhsachSV = StdList.Count();
            ViewData["Student"] = StdList;
            return View(StdList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            ViewBag.Sinhvien ="Hello:  "+ std.StudentID + "-"+ std.StudentName + "-"+ std.Age;
            return View();
        }
    }
}