using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qa517.Localization;
using Qa517.Users;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Qa517
{
    /* Inherit your application services from this class.
     */
    public abstract class Qa517AppService : ApplicationService
    {
        protected Qa517AppService()
        {
            LocalizationResource = typeof(Qa517Resource);
        }
    }

    public class DemoAppService : Qa517AppService
    {
        private readonly IRepository<AppUserSqlView> _appUserSqlViewRepository;

        public DemoAppService(IRepository<AppUserSqlView> appUserSqlViewRepository)
        {
            _appUserSqlViewRepository = appUserSqlViewRepository;
        }

        public async Task<List<AppUserSqlViewDto>> GetAppUsers()
        {
            var result = await _appUserSqlViewRepository.GetListAsync();

            return result.Select(x => new AppUserSqlViewDto
            {
                Name = x.Name,
                Email = x.Email
            }).ToList();
        }
    }

    public class AppUserSqlViewDto
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
