using Stylelabs.M.Sdk.Contracts.Base;
using System.Threading.Tasks;

namespace ContentHubDemo.EntityCrudOperations
{
    static class UpdateEntity
    {
        public static async Task<long> UpdateAssetEntity()
        {
            long entityId = 1523729;
            IEntity asset = await MClientConnector.Client.Entities.GetAsync(entityId);
            asset.SetPropertyValue("Title", "This is a updated test Asset");
            return await MClientConnector.Client.Entities.SaveAsync(asset).ConfigureAwait(false);
        }
    }
}
