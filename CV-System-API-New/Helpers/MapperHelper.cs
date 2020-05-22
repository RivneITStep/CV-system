using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace CV_System_API_New.Helpers
{
    public class MapperHelper<TEntity, TDTO>
        where TEntity : class
        where TDTO : class
    {
        public static TEntity MapEntityFromDTO(IMapper mapper, TDTO dto)
        {
            return mapper.Map<TDTO, TEntity>(dto);
        }
        public static TDTO MapDTOFromEntity(IMapper mapper, TEntity entity)
        {
            return mapper.Map<TEntity, TDTO>(entity);
        }
        public static IEnumerable<TEntity> MapEntitiesFromDTOs(IMapper mapper, IEnumerable<TDTO> dtos)
        {
            return mapper.Map<IEnumerable<TDTO>, IEnumerable<TEntity>>(dtos).ToArray();
        }
        public static IEnumerable<TDTO> MapDTOsFromEntities(IMapper mapper, IEnumerable<TEntity> entities)
        {
            return mapper.Map<IEnumerable<TEntity>, IEnumerable<TDTO>>(entities).ToArray();
        }
    }
}
