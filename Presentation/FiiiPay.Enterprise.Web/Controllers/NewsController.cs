using FiiiPay.Enterprise.Business;
using FiiiPay.Enterprise.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiiiPay.Enterprise.Web.Controllers
{
    [Access]
    public class NewsController : BaseController
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadData(NewsViewModel news, GridPager pager)
        {

            var pagerTuple = Tuple.Create(pager.SortColumn, pager.OrderBy, pager.Page, pager.Size, 0, 0);
            var result = new NewsComponent().GetRecordList(news.Title, news.Status, ref pagerTuple);
            pager.Count = pagerTuple.Item5;
            pager.TotalPage = pagerTuple.Item6;

            var models = result.ToGridJson(pager, item => new
            {
                Title = item.CNTitle,
                PageView = item.PageView,
                Status = item.Status,
                CreateTime = item.CreateTime.ToString("yyyy-MM-dd HH:mm")
            });

            return Json(models, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(Guid id)
        {
            var accountsId = AccountInfo.Id;
            return View();
        }
    }
}