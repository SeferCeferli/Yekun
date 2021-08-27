using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface ISettingsService
    {
        Settings GetSettings();
        Settings CreateSettings(Settings model);
        Settings UpdateSettings(Settings model);
        bool DeleteSettings(int id);
    }
}
