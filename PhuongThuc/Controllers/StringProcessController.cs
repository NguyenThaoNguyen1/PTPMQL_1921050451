using Microsoft.AspNetCore.Mvc;
using PhuongThuc.Models.StringProcess;
namespace PhuongThuc.Controllers
{
    public class StringProcessController :Controller
    {
        StringProcess strPro = new StringProcess();
        
        public IActionResult XoaKhoangTrang()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult XoaKhoangTrang(string strInput )
        { 
            ViewBag.thongbao="Sau khi xóa khoảng trắng :  "+ strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }
          //in ra chuỗi chuyển từ in hoa ra in thường
        public IActionResult InThuong()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult InThuong(string strInput )
        { 
            ViewBag.thongbao="chuyển chuỗi sang in thường:  "+ strPro.UpperToLower(strInput);
            return View();
        }
        //Chuyển từ in thường ra in hoa
        public IActionResult InHoaTT()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult InHoaTT(string strInput )
        { 
            ViewBag.thongbao="chuyển chuỗi sang in hoa:  "+ strPro.LowerToUpper(strInput);
            return View();
        }
         //chuyển chuỗi sang in hoa chữ đầu  
        public IActionResult InHoa1()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult InHoa1(string strInput )
        { 
            ViewBag.thongbao="in hoa chữ cái đầu tiên:  "+ strPro.CapitalizeOneFirstCharacter(strInput);
            return View();
        }
        public IActionResult InHoa2()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult InHoa2(string strInput )
        { 
            ViewBag.thongbao="in hoa tất cả chữ cái đầu:  "+ strPro.CapitalizeFirstCharacter(strInput);
            return View();
        }
         public IActionResult BoDau()
        {
            return View(); 
        }
       
       [HttpPost]
        public IActionResult BoDau(string strInput )
        { 
            ViewBag.thongbao="Sau khi bỏ dấu:  "+ strPro.RemoveVietnameseAccents(strInput);
            return View();
        }
    }
}