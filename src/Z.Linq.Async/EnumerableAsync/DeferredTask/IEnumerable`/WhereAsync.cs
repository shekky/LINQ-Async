﻿// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<IEnumerable<TSource>> WhereAsync<TSource>(this Task<IEnumerable<TSource>> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, predicate, Enumerable.Where, cancellationToken);
        }

        public static Task<IEnumerable<TSource>> WhereAsync<TSource>(this Task<IEnumerable<TSource>> source, Func<TSource, int, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, predicate, Enumerable.Where, cancellationToken);
        }
    }
}