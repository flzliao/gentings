﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Gentings.Storages.Avatars
{
    /// <summary>
    /// 头像管理接口。
    /// </summary>
    public interface IAvatarManager : ISingletonService
    {
        /// <summary>
        /// 上传用户头像。
        /// </summary>
        /// <param name="userId">用户Id。</param>
        /// <param name="file">当前用户实例。</param>
        /// <returns>返回上传任务。</returns>
        Task UploadAsync(int userId, IFormFile file);

        /// <summary>
        /// 获取头像文件实例。
        /// </summary>
        /// <param name="userId">用户Id。</param>
        /// <param name="size">宽度或者高度。</param>
        /// <returns>返回文件实例。</returns>
        IStorageFile GetFile(int userId, int size);
    }
}
