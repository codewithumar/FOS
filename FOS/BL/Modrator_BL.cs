using FOS.DL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.BL
{
    class Modrator_BL
    {
         Modrator_DL _addfoodDL;

        public Modrator_BL()
        {
            _addfoodDL = new Modrator_DL();
        }
        public void addItemin_BL(AddItem_DTO additem_dto)
        {
            _addfoodDL.addFoodin_DB(additem_dto);
        }
    }
}
