using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyTiemVang.DAO
{
    public interface IRestorableData
    {
        void RestoreTemp(uint id);
        void PermDelete(uint id);
        DataTable GetAllDeletedItem();
    }
}
