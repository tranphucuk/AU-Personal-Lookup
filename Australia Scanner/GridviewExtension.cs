using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Australia_Scanner
{
    public static class GridviewExtension
    {
        public static IEnumerable<T> GetSelectedRows<T>(this GridView gv) where T : class
        {
            var SelectedRowCount = gv.GetSelectedRows();
            for (int i = 0; i < SelectedRowCount.Length; i++)
            {
                var item = gv.GetRow(SelectedRowCount[i]) as T;
                yield return item;
            }
        }
    }
}
