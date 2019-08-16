﻿using RayPI.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RayPI.Bussiness.System
{
    public class EntityBussiness
    {
        private IEntityRepository _entityRepository;

        public EntityBussiness()
        {

        }

        public bool CreateEntity(string entityName, string contentRootPath)
        {
            string[] arr = contentRootPath.Split('\\');
            string baseFileProvider = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                baseFileProvider += arr[i];
                baseFileProvider += "\\";
            }
            string filePath = baseFileProvider + "RayPI.Entity";
            return _entityRepository.CreateEntity(entityName, filePath);
        }
    }
}