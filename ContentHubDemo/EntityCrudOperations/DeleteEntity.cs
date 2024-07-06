using System.Threading.Tasks;

namespace ContentHubDemo.EntityCrudOperations
{
    static class DeleteEntity
    {
        public static Task DeleteAssetEntity()
        {
            long entityId = 1523729;
            return MClientConnector.Client.Entities.DeleteAsync(entityId);
        }
    }
}
