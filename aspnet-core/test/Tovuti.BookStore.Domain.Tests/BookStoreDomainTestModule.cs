using Tovuti.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tovuti.BookStore;

[DependsOn(
    typeof(BookStoreEntityFrameworkCoreTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
