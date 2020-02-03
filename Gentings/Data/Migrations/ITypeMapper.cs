﻿using System;

namespace Gentings.Data.Migrations
{
    /// <summary>
    /// 类型匹配接口。
    /// </summary>
    public interface ITypeMapper
    {
        /// <summary>
        /// 获取数据类型。
        /// </summary>
        /// <param name="type">当前类型实例。</param>
        /// <param name="size">大小。</param>
        /// <param name="rowVersion">是否为RowVersion。</param>
        /// <param name="unicode">是否为Unicode字符集。</param>
        /// <returns>返回匹配的数据类型。</returns>
        string GetMapping(Type type, int? size = null, bool rowVersion = false, bool? unicode = null);
    }
}