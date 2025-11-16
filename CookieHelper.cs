using System;
using System.Web;

namespace HobbyCollection
{
    public static class CookieHelper
    {
        public static void SaveUserSettings(string username, string theme, int itemsPerPage)
        {
            if (HttpContext.Current != null)
            {
                HttpCookie userCookie = new HttpCookie("UserSettings");
                userCookie["Username"] = username;
                userCookie["ItemsPerPage"] = itemsPerPage.ToString();
                userCookie.Expires = DateTime.Now.AddDays(30);

                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
        }

        public static (string username, int itemsPerPage) LoadUserSettings()
        {
            if (HttpContext.Current != null && HttpContext.Current.Request.Cookies["UserSettings"] != null)
            {
                HttpCookie userCookie = HttpContext.Current.Request.Cookies["UserSettings"];

                string username = userCookie["Username"] ?? "";
                int itemsPerPage = int.TryParse(userCookie["ItemsPerPage"], out int result) ? result : 10;

                return (username, itemsPerPage);
            }

            return ("", 10);
        }

        public static void DeleteUserSettings()
        {
            if (HttpContext.Current != null)
            {
                HttpCookie userCookie = new HttpCookie("HobbyCollectionSettings") // avoid overload here!!!!
                {
                    Expires = DateTime.Now.AddDays(-1)
                };
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
        }
    }
}