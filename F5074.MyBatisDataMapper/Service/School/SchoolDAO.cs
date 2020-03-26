using F5074.MyBatisDataMapper.Common;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.School
{
    public class SchoolDAO
    {
        private static ISqlMapper mapper = DBConnection.EntityMapper;
        public static IList<SchoolDTO> SelectSchoolList(SchoolDTO vo)
        {
            return mapper.QueryForList<SchoolDTO>("SelectSchoolList", vo);
        }
    }
}
