using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    /**
     * ☆ビューとのインタラクションサンプル
     * 
     */
    public class ViewController : Controller
    {

        // ViewDataを使って、コントローラからビューテンプレートにデータを渡す
        public IActionResult UseOfViewData()
        {

            // ViewDataは単純なkey:Value形式?
            ViewData["Message"] = "こんにちは！";
            ViewData["Message"] = "さようなら。";

            return View();
        }

        // ViewBagを使って、コントローラからビューテンプレートにデータを渡
        public IActionResult UseOfViewBag()
        {
            // ViewDataとの違いは、string縛りではないところ。
            // 取り出すときにキャストが不要
            ViewBag.Number = 100;
            ViewBag.Text = "Hello";

            return View();
        }

    }
}
