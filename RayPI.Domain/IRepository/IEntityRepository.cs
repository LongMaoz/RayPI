﻿
namespace RayPI.Domain.IRepository
{
    /// <summary>
    /// 实体数据接口
    /// </summary>
    public interface IEntityRepository
    {
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        bool CreateEntity(string entityName,string filePath);
    }
}