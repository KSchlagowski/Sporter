using System.Collections.Generic;

namespace Sporter.Application.ViewModels.Item
{
    public class ListItemForListVm
    {
        public List<ItemForListVm> Items { get; set; }
        public int Count { get; set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }
        public string SearchString { get; internal set; }
    }
}