using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAO
{
    public class PositionDAO : EmployeeContext
    {
        public static void AddPosition(POSITION position)
        {
            try
            {
                db.POSITIONs.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<PositionDTO> GetPostions()
        {
            try
            {
                var list = (from p in db.POSITIONs
                            join d in db.DEPARTMENTs on p.DepartmentId equals d.Id
                            select new
                            {
                                positionId = p.Id,
                                positionName = p.PositionName,
                                departmentName = d.DepartmentName,
                                departmentId = p.DepartmentId
                            }).OrderBy(x => x.positionId).ToList();

                List<PositionDTO> positionList = new List<PositionDTO>();
                foreach(var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.Id = item.positionId;
                    dto.PositionName = item.positionName;
                    dto.DepartmentName = item.departmentName;
                    dto.DepartmentId = item.departmentId;
                    positionList.Add(dto);
                }
                return positionList;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
