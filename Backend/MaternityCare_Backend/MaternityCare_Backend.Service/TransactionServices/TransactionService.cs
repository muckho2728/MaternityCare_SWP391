using AutoMapper;
using MaternityCare_Backend.Domain.Repositories;
using Microsoft.Extensions.Configuration;

namespace MaternityCare_Backend.Service.TransactionServices
{
	internal sealed class TransactionService : ITransactionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly Utils utils;
		private readonly IConfiguration configuration;

		public TransactionService(IRepositoryManager repositoryManager, IMapper mapper, Utils utils, IConfiguration configuration)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.utils = utils;
			this.configuration = configuration;
		}
	}
}
