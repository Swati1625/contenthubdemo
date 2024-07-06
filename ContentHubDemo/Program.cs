using ContentHubDemo.EntityCrudOperations;
using System;
using System.Threading.Tasks;
namespace ContentHubDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                //await MClientConnector.Client.TestConnectionAsync();
                //var id=await CreateEntity.CreateAssestEntity();
                //var entity=await GetEntity.GetAssetEntity();
                //var entity = await UpdateEntity.UpdateAssetEntity();
                await DeleteEntity.DeleteAssetEntity();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
