using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Vinteler_Erica_lab12.Models;

namespace Vinteler_Erica_lab12.Data
{
    IRestService restService;
    public ShoppingListDatabase(IRestService service)
    {
        restService = service;
    }
    public Task<List<ShopList>> GetShopListsAsync()
    {
        return restService.RefreshDataAsync();
    }

    public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
    {
        return restService.SaveShopListAsync(item, isNewItem);
    }
    public Task DeleteShopListAsync(ShopList item)
    {
        return restService.DeleteShopListAsync(item.ID);
    }
}
