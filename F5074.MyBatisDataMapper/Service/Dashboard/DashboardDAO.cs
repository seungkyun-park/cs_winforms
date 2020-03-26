using F5074.MyBatisDataMapper.Common;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.Dashboard
{
    public class DashboardDAO
    {
        private static ISqlMapper mapper = DBConnection.EntityMapper;
        public static IList<DashboardDTO> SelectList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("SelectList", vo);
        }
    }
}
