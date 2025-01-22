namespace MaternityCare_Backend.Domain.Repositories
{
	public interface IRepositoryManager
	{
		IUserRepository UserRepository { get; }
		IRoleRepository RoleRepository { get; }
		Task SaveAsync();
	}
}
