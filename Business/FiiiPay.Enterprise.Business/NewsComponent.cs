using FiiiPay.Enterprise.Data;
using FiiiPay.Enterprise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Business
{
    public class NewsComponent
    {
        public List<News> GetRecordList(string title, byte? status, ref Tuple<string, string, int, int, int, int> pager)
        {
            return new NewsDAC().GetPagedList(title, status, ref pager);
        }

    }
}
