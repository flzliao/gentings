﻿using Microsoft.Extensions.Caching.Memory;
using Gentings.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Gentings.Extensions.Groups
{
    /// <summary>
    /// 初始化类<see cref="GroupManager{TGroup}"/>。
    /// </summary>
    /// <typeparam name="TGroup">分组类型。</typeparam>
    public abstract class GroupManager<TGroup> : CachableObjectManager<TGroup>, IGroupManager<TGroup> where TGroup : GroupBase<TGroup>
    {
        /// <summary>
        /// 初始化类<see cref="GroupManager{TCategory}"/>。
        /// </summary>
        /// <param name="context">数据库操作接口实例。</param>
        /// <param name="cache">缓存接口。</param>
        protected GroupManager(IDbContext<TGroup> context, IMemoryCache cache)
            : base(context, cache)
        {
        }

        /// <summary>
        /// 判断是否已经存在。
        /// </summary>
        /// <param name="category">分类实例。</param>
        /// <returns>返回判断结果。</returns>
        public override bool IsDuplicated(TGroup category)
        {
            IEnumerable<TGroup> groups = Fetch(x => x.ParentId == category.ParentId && x.Id != category.Id && x.Name == category.Name);
            return groups.Any();
        }

        /// <summary>
        /// 判断是否已经存在。
        /// </summary>
        /// <param name="category">分类实例。</param>
        /// <param name="cancellationToken">取消标识。</param>
        /// <returns>返回判断结果。</returns>
        public override async Task<bool> IsDuplicatedAsync(TGroup category, CancellationToken cancellationToken = default)
        {
            IEnumerable<TGroup> groups = await FetchAsync(x => x.ParentId == category.ParentId && x.Id != category.Id && x.Name == category.Name, cancellationToken);
            return groups.Any();
        }

        /// <summary>
        /// 加载所有的分类。
        /// </summary>
        /// <param name="expression">条件表达式。</param>
        /// <returns>返回分类列表。</returns>
        public override IEnumerable<TGroup> Fetch(Expression<Predicate<TGroup>> expression = null)
        {
            ICollection<TGroup> models = Cache.GetOrCreate(CacheKey, ctx =>
            {
                ctx.SetDefaultAbsoluteExpiration();
                IEnumerable<TGroup> categories = Context.Fetch();
                return categories.MakeDictionary().Values;
            });
            return models.Filter(expression);
        }

        /// <summary>
        /// 加载所有的分类。
        /// </summary>
        /// <param name="expression">条件表达式。</param>
        /// <param name="cancellationToken">取消标识。</param>
        /// <returns>返回分类列表。</returns>
        public override async Task<IEnumerable<TGroup>> FetchAsync(Expression<Predicate<TGroup>> expression = null, CancellationToken cancellationToken = default)
        {
            ICollection<TGroup> models = await Cache.GetOrCreateAsync(CacheKey, async ctx =>
            {
                ctx.SetDefaultAbsoluteExpiration();
                IEnumerable<TGroup> categories = await Context.FetchAsync(cancellationToken: cancellationToken);
                return categories.MakeDictionary().Values;
            });
            return models.Filter(expression);
        }
    }
}