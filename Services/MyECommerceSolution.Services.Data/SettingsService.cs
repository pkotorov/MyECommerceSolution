namespace MyECommerceSolution.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MyECommerceSolution.Data.Common.Repositories;
    using MyECommerceSolution.Data.Models;
    using MyECommerceSolution.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
