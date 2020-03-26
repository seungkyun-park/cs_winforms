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
        private static DashboardDTO resultDTO = new DashboardDTO();
        public static IList<DashboardDTO> SelectList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("SelectList", vo);
        }

        public static DashboardDTO InsertCompany(DashboardDTO _dto)
        {
            try
            {
                mapper.Insert("InsertCompany", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

        public static DashboardDTO UpdateCompany(DashboardDTO _dto)
        {
            try
            {
                mapper.Update("UpdateCompany", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

        public static DashboardDTO DeleteCompany(DashboardDTO _dto)
        {
            try
            {
                mapper.Delete("DeleteCompany", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

    }
}
