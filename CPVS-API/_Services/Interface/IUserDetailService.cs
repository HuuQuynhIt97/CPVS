﻿using CPVS_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPVS_API._Services.Interface
{
    public interface IUserDetailService : IECService<UserDetailDto>
    {
        Task<bool> MapUserDetailDto(UserDetailDto mapModel);
        Task<bool> Delete(int userId, int lineID);
    }
}
