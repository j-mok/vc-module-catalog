using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using VirtoCommerce.AssetsModule.Core.Assets;
using VirtoCommerce.CatalogModule.Core.Model;
using VirtoCommerce.CatalogModule.Core.Services;
using VirtoCommerce.CatalogModule.Data.Repositories;
using VirtoCommerce.CatalogModule.Data.Services;
using VirtoCommerce.Platform.Core.Caching;
using VirtoCommerce.Platform.Core.Events;

namespace VirtoCommerce.CatalogModule2.Web.Services
{
    public class CategoryService2 : CategoryService
    {
        public CategoryService2(
            Func<ICatalogRepository> catalogRepositoryFactory,
            IEventPublisher eventPublisher,
            IPlatformMemoryCache platformMemoryCache,
            AbstractValidator<IHasProperties> hasPropertyValidator,
            ICatalogService catalogService,
            IOutlineService outlineService,
            IBlobUrlResolver blobUrlResolver)
            : base(
                catalogRepositoryFactory,
                eventPublisher,
                platformMemoryCache,
                hasPropertyValidator,
                catalogService,
                outlineService,
                blobUrlResolver)
        {
        }

        public override Task<Category[]> GetByIdsAsync(string[] categoryIds, string responseGroup, string catalogId = null)
        {
            return base.GetByIdsAsync(categoryIds, responseGroup, catalogId);
        }

        public override Task DeleteAsync(IEnumerable<string> ids, bool softDelete = false)
        {
            return base.DeleteAsync(ids, softDelete);
        }

        protected override void ApplyInheritanceRules(IEnumerable<Category> categories)
        {
            base.ApplyInheritanceRules(categories);
        }

        protected override void ClearCache(IEnumerable<Category> models)
        {
            base.ClearCache(models);
        }

        protected override Task LoadDependencies(ICollection<Category> categories, IDictionary<string, Category> preloadedCategoriesMap)
        {
            return base.LoadDependencies(categories, preloadedCategoriesMap);
        }

        protected override void ResolveImageUrls(IEnumerable<Category> categories)
        {
            base.ResolveImageUrls(categories);
        }

        public override Task SaveChangesAsync(IEnumerable<Category> models)
        {
            return base.SaveChangesAsync(models);
        }

        protected override Task ValidateCategoryPropertiesAsync(IEnumerable<Category> categories)
        {
            return base.ValidateCategoryPropertiesAsync(categories);
        }
    }
}
