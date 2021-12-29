using System.ComponentModel.DataAnnotations;

namespace Boticario.Api.ViewModels
{
    public class ProductViewModel
    {
        #region Properties

        public uint Sku { get; set; }

        [Required(ErrorMessage = "Campo Name é obrigatório")]
        public string Name { get; set; }

        public InventoryViewModel Inventory { get; set; }

        public bool IsMarketable { get; set; }

        #endregion
    }
}