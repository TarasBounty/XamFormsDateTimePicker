using System;

using XamFormsDateTimePicker.Models;

namespace XamFormsDateTimePicker.ViewModels
{
   public class ItemDetailViewModel : BaseViewModel
   {
      public Item Item { get; set; }
      public ItemDetailViewModel(Item item = null)
      {
         Title = item?.Text;
         Item = item;
      }
   }
}
