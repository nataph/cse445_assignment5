using System;
using System.Web;

namespace Assignment5
{
    public static class CookieHelper
    {
        public static void SaveCollectionSummary(string username, string recentPurchase, decimal totalValue, int itemCount)
        {
            if (HttpContext.Current != null)
            {
                HttpCookie collectionCookie = new HttpCookie("CollectionSummary");
                collectionCookie["Username"] = username;
                collectionCookie["RecentPurchase"] = recentPurchase;
                collectionCookie["TotalValue"] = totalValue.ToString();
                collectionCookie["ItemCount"] = itemCount.ToString();
                collectionCookie.Expires = DateTime.Now.AddDays(30);

                HttpContext.Current.Response.Cookies.Add(collectionCookie);
            }
        }

        public static (string username, string recentPurchase, decimal totalValue, int itemCount) LoadCollectionSummary()
        {
            if (HttpContext.Current != null && HttpContext.Current.Request.Cookies["CollectionSummary"] != null)
            {
                HttpCookie collectionCookie = HttpContext.Current.Request.Cookies["CollectionSummary"];

                string username = collectionCookie["Username"] ?? "";
                string recentPurchase = collectionCookie["RecentPurchase"] ?? "";
                decimal totalValue = decimal.TryParse(collectionCookie["TotalValue"], out decimal value) ? value : 0;
                int itemCount = int.TryParse(collectionCookie["ItemCount"], out int count) ? count : 0;

                return (username, recentPurchase, totalValue, itemCount);
            }

            return ("", "", 0, 0);
        }

        public static void DeleteCollectionSummary()
        {
            if (HttpContext.Current != null)
            {
                HttpCookie collectionCookie = new HttpCookie("CollectionSummary");
                collectionCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(collectionCookie);
            }
        }
    }
}
