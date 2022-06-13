using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers

{

    /**
     * ☆ルーティングのサンプル
     * 
     *  基本フロー↓
     *  Routing
     *  Controller Creation
     *  Authentication/Authorization
     *  ModelBinding
     *  ActionMethodInvocation
     *  ResultExecution
     * 
     */
    public class RoutingController : Controller
    {
        /*
         * ☆ルーティングルール☆
         * ｛コントローラ名｝/｛アクションメソッド名｝/｛パラメータ（省略可能）｝
         *  ※Startup.csでこのルールの設定は変更可能
         * 
         */

        // コントローラークラス内で定義されたpublicメソッド => 「アクションメソッド」
        public string Index()
        {
            return "Hello World!";
        }

        public string Welcome()
        {
            return "Welcomeページです。";

        }

        /*
         *　パラメータのバインディング
         *　デフォルト値の設定も出来る
         *　リクエスト（---/HelloHorld/WelcomWithParam?name=Hatori&age=30）
         *　
         */
        public string WelcomeWithParam(string name, int age = 18)
        {
            return $"名前：{name}さん、ID：{age}才";
        }

        // HTTPメソッドの指定は？

        // redirect foward は？


    }
}
