using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;

namespace Shop
{
    /// Cache操作类
    /// <summary>
    /// Cache操作类
    /// </summary>
    public static class CacheCustom
    {
        /// 简单创建/修改Cache，前提是这个值是字符串形式的
        /// <summary>
        /// 简单创建/修改Cache，前提是这个值是字符串形式的
        /// </summary>
        /// <param name="strCacheName">Cache名称</param>
        /// <param name="strValue">Cache值</param>
        /// <param name="iExpires">有效期，秒数（使用的是当前时间+秒数得到一个绝对到期值）</param>
        /// <param name="priority">保留优先级，1最不会被清除，6最容易被内存管理清除（1:NotRemovable；2:High；3:AboveNormal；4:Normal；5:BelowNormal；6:Low）</param>
        public static void Insert(string strCacheName, object objValue, TimeSpan ts, int priority)
        {
            CacheItemPriority cachePriority;
            switch (priority)
            {
                case 6:
                    cachePriority = CacheItemPriority.Low;
                    break;
                case 5:
                    cachePriority = CacheItemPriority.BelowNormal;
                    break;
                case 4:
                    cachePriority = CacheItemPriority.Normal;
                    break;
                case 3:
                    cachePriority = CacheItemPriority.AboveNormal;
                    break;
                case 2:
                    cachePriority = CacheItemPriority.High;
                    break;
                case 1:
                    cachePriority = CacheItemPriority.NotRemovable;
                    break;
                default:
                    cachePriority = CacheItemPriority.Default;
                    break;
            }
            HttpRuntime.Cache.Insert(strCacheName, objValue, null, DateTime.Now.Add(ts), System.Web.Caching.Cache.NoSlidingExpiration, cachePriority, null);
        }

        public static void Insert(string strCacheName, object objValue)
        {
            Insert(strCacheName, objValue, new TimeSpan(24, 0, 0), 1);
        }

        /// 简单读书Cache对象的值，前提是这个值是字符串形式的
        /// <summary>
        /// 简单读书Cache对象的值，前提是这个值是字符串形式的
        /// </summary>
        /// <param name="strCacheName">Cache名称</param>
        /// <returns>Cache字符串值</returns>
        public static object Get(string strCacheName)
        {
            return HttpRuntime.Cache[strCacheName];
        }

        /// 删除Cache对象
        /// <summary>
        /// 删除Cache对象
        /// </summary>
        /// <param name="strCacheName">Cache名称</param>
        public static void Del(string strCacheName)
        {
            HttpRuntime.Cache.Remove(strCacheName);
        }

        public static string  ClearAll()
        {
            List<string> cacheKeys = new List<string>();
            string log = "";
            System.Collections.IDictionaryEnumerator cacheEnum = HttpRuntime.Cache.GetEnumerator();
            while (cacheEnum.MoveNext())
            {
                cacheKeys.Add(cacheEnum.Key.ToString());
            }
            foreach (string cacheKey in cacheKeys)
            {
                log += cacheKey+": Cleared!<br/>";
                HttpRuntime.Cache.Remove(cacheKey);
            }

            return log;
        }
    }
}