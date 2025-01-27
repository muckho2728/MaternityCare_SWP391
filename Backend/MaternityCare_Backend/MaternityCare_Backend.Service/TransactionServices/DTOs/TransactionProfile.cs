using AutoMapper;
using MaternityCare_Backend.Domain.Entities;

namespace MaternityCare_Backend.Service.TransactionServices.DTOs
{
	public class TransactionProfile : Profile
	{
		public TransactionProfile()
		{
			CreateMap<Transaction, TransactionForReturnDto>();
		}
	}
}
