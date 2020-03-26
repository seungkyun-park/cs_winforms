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
        private static SchoolDTO resultDTO = new SchoolDTO();
        public static IList<SchoolDTO> SelectSchoolList(SchoolDTO vo)
        {
            return mapper.QueryForList<SchoolDTO>("SelectSchoolList", vo);
        }
        public static SchoolDTO InsertSchool(SchoolDTO _dto)
        {
            try
            {
                mapper.Insert("InsertSchool", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

        public static SchoolDTO UpdateSchool(SchoolDTO _dto)
        {
            try
            {
                mapper.Update("UpdateSchool", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

        public static SchoolDTO DeleteSchool(SchoolDTO _dto)
        {
            try
            {
                mapper.Delete("DeleteSchool", _dto);
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
