using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;
using MaternityCare_Backend.Service.IServices;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.Services
{
	public sealed class ServiceManager : IServiceManager
	{
		public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, IConfiguration configuration) { }
	}
}
