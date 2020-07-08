using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public interface IRepositoryBase2<T, TId>
    {
        // 根据指定的实体Id获取实体
        Task<T> GetByIdAsync(TId id);
        // 检查具有指定Id的实体是否存在
        Task<bool> IsExistAsync(TId id);
    }
}
