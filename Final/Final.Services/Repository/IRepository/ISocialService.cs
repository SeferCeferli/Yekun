using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface ISocialService
    {
        List<Social> GetSocials();
        Social GetSocial(int? id);
        Social CreateSocial(Social model);
        Social UpdateSocial(Social model);
        bool DeleteSocial(int id);
    }
}
