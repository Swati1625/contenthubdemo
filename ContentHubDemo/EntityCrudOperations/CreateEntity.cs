using Stylelabs.M.Sdk.Contracts.Base;
using System.Threading.Tasks;

namespace ContentHubDemo.EntityCrudOperations
{
    static class CreateEntity
    {
        public static async Task<long> CreateAssestEntity()
        {
            IEntity asset = await MClientConnector.Client.EntityFactory.CreateAsync("M.Asset").ConfigureAwait(false);
            asset.SetPropertyValue("Title", "This is a test Asset");
           return await MClientConnector.Client.Entities.SaveAsync(asset).ConfigureAwait(false);
        }
    }
}
