﻿// Description: Entity Framework Bulk Operations & Utilities (EF Bulk SaveChanges, Insert, Update, Delete, Merge | LINQ Query Cache, Deferred, Filter, IncludeFilter, IncludeOptimize | Audit)
// Website & Documentation: https://github.com/zzzprojects/Entity-Framework-Plus
// Forum & Issues: https://github.com/zzzprojects/EntityFramework-Plus/issues
// License: https://github.com/zzzprojects/EntityFramework-Plus/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Data.Entity;
using System.Linq;

namespace Z.EntityFramework.Plus
{
    public static partial class QueryInterceptorFilterExtensions
    {
        /// <summary>Return the original query before the context was filtered.</summary>
        /// <typeparam name="T">The type of elements of the query.</typeparam>
        /// <param name="query">The filtered query from which the original query should be retrieved.</param>
        /// <returns>The original query before the context was filtered.</returns>
        public static IQueryable<T> AsNoFilter<T>(this IQueryable<T> query) where T : class
        {
            return QueryFilterManager.HookFilter(query, QueryFilterManager.DisableAllFilter);
        }
    }
}