using System.Threading.Tasks;

namespace Tovuti.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
