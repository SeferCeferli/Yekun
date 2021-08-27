using Final.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final.Services.Repository.IRepository
{
    public interface IAdvertismentService
    {
        Advertisment GetAdvertisment(int? id);
        List<Advertisment> GetAdvertisments();
        Advertisment UpdateAdvertisment(Advertisment model);
    }
}
