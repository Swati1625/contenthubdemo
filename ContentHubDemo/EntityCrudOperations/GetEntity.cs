using Stylelabs.M.Sdk.Contracts.Base;
using System.Threading.Tasks;

namespace ContentHubDemo.EntityCrudOperations
{
    static class GetEntity
    {
        public static Task<IEntity> GetAssetEntity()
        {
            long entityId = 1523729;
            return MClientConnector.Client.Entities.GetAsync(entityId);
        }
    }
}
