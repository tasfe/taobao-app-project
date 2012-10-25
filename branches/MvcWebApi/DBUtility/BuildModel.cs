using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace DBUtility
{
    public class BuildModel
    {
        public static List<T> BuildModelListByTable<T>(DataTable dt) where T : new ()
        {
            List<T> list = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                Type modelType = t.GetType();

                foreach (DataColumn dc in dt.Columns)
                {
                    PropertyInfo p;
                    p = modelType.GetProperty(dc.ColumnName);
                    if (p != null)
                    {
                        if (!(dr[dc.ColumnName] is DBNull))
                        {
                            p.SetValue(t, dr[dc.ColumnName], null);
                        }
                    }
                }

                list.Add(t);
            }

            return list;
        }
    }
}
