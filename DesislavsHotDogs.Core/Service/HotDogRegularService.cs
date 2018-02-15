using DesislavsHotDogs.Core.Model;
using DesislavsHotDogs.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesislavsHotDogs.Core.Service
{
    public class HotDogRegularService
    {
        private static HotDogRepository hotDogRepository = new HotDogRepository();

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogRepository.GetGroupedHotDogs();
        }

        public List<HotDog> GetHotDogsForGroup (int hotDogGroupId)
        {
            return hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return hotDogRepository.GetFavoriteHotDogs();
        }

        public HotDog GetHotDogById (int hotDogId)
        {
            return hotDogRepository.GetHotDogById(hotDogId);
        }
    }
}
