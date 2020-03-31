using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Helpers
{
    public static class UpdateHelper<T>
    {
        public static T UpdateEntity(T oldEntity, T newEntity)
        {
            var type = oldEntity.GetType();
            var properties = type.GetProperties();
            object propValue = null;
            var propName = "";
            foreach (var p in properties)
            {
                for (int i = 0; i < properties.Length; i++)
                {
                    propName = properties[i].Name;
                    if (i == 0 && propName.Contains("Id"))
                    {
                        continue;
                    }
                    propValue = type.GetProperty(propName).GetValue(newEntity);
                    properties[i].SetValue(oldEntity, propValue);
                }
            }
            return oldEntity;
        }
    }
}
