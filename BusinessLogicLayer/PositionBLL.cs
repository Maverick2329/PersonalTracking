using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.DAO;
using DataAccessLayer.DTO;

namespace BusinessLogicLayer
{
    public class PositionBLL
    {
        public static void AddPosition(POSITION position)
        {
            PositionDAO.AddPosition(position);
        }

        public static List<PositionDTO> GetPositions()
        {
            return PositionDAO.GetPostions();
        }
    }
}
