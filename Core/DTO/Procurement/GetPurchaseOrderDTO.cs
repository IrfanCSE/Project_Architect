using System;

namespace Core.DTO.Procurement
{
    public class GetPurchaseOrderDTO
    {
        public long PurchaseOrderId { get; set; }
        public string PurchaseOrderNo { get; set; }
        public long AccountId { get; set; }
        public long BusinessUnitId { get; set; }
        public long Sbuid { get; set; }
        public long PlantId { get; set; }
        public string PlantName { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public long? SupplyingWarehouseId { get; set; }
        public string SupplyingWarehouseName { get; set; }
        public long PurchaseOrganizationId { get; set; }
        public long BusinessPartnerId { get; set; }
        public string BusinessPartnerName { get; set; }
        public DateTime DtePurchaseOrderDate { get; set; }
        public long PurchaseOrderTypeId { get; set; }
        public long IncotermsId { get; set; }
        public long CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string SupplierReference { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public long ReferenceTypeId { get; set; }
        public long? PriceStructureId { get; set; }
        public bool? IsApproved { get; set; }
        public long? ApproveBy { get; set; }
        public DateTime? ApproveDatetime { get; set; }
        public long PaymentTerms { get; set; }
        public long CreditPercent { get; set; }
        public long CashOrAdvancePercent { get; set; }
        public string OtherTerms { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public DateTime PovalidityDate { get; set; }
        public DateTime LastShipmentDate { get; set; }
        public long PaymentDaysAfterDelivery { get; set; }
        public string DeliveryAddress { get; set; }
        public long ActionBy { get; set; }
        public string ActionName { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public DateTime ServerDateTime { get; set; }
        public bool? IsActive { get; set; }
        public bool IsClosed { get; set; }
        public decimal? GrossDiscount { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Commission { get; set; }
        public decimal? PonetValue { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? OthersCharge { get; set; }
    }
}