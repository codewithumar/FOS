using FOS.DL;
using FOS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.BL
{
    class Modrator_BL
    {
         Modrator_DL _modratorDL;

        public Modrator_BL()
        {
            _modratorDL = new Modrator_DL();
        }
        public bool addItemin_BL(AddItem_DTO additem_dto)
        {
            return (_modratorDL.addFoodin_DB(additem_dto));
        }
        public DataTable getMenuitems_BL()
        {
            return _modratorDL.getMenuItemsfrom_db();
        }
        public bool addtotalbillInBL(GenrateOrderBill_DTO gob_dto)
        {
            return _modratorDL.addtotalbillInDB(gob_dto);
        }
    }
}
