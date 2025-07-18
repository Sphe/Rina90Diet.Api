﻿using Rina90Diet.Data.FullDomain;
using Rina90Diet.Front.ApiWeb;
using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rina90Diet.Service
{
    public interface IAttributeService
    {
        Task<List<Genericattribute>> ListAttribute(
            int size = 10, int start = 0);

        Task<Genericattribute> CreateOrGetAttribute(
                    string type,
                    string value,
                    object typeObject = null,
                    object valueObject = null,
                    int typeSort = 0,
                    int valueSort = 0,
                    int? categoryId = null);

        Genericattributetype GetAttributeType(string type, object typeObject = null, int? categoryId = null);
        
        Genericattributevalue GetValue(string value, object valueObject = null);

        Task<Tuple<string, IList<Genericattribute>>> CreateAttributeBulk(IList<AttributeBulk> attributesCreates);
    }
}
