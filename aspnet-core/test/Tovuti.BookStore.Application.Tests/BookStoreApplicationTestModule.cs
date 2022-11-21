using Volo.Abp.Modularity;

namespace Tovuti.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
    )]
public class BookStoreApplicationTestModule : AbpModule
{

}
