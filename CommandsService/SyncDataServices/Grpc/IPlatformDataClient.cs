using CommandsService.Models;

namespace CommandsService.SyncDataServices.Grpc;

public interface IPlatformDataCliente
{
    IEnumerable<Platform> ReturnAllPlatforms();
}