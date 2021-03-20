using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SeasonAPISport.Models;

namespace SeasonAPISport.Services
{
    public interface ISeasonLAPIService
    {
        Task<SeasonInfo> GetSeasonInfoAsync();
        
    }
}
