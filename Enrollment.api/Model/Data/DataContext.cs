using System;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.api.Model.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<DepOrder> DepOrders { get; set; }
        
    }

    public class DepOrder
    {
        public long Id { get; set; }
        public long DepDetailId { get; set; }
        public string PO { get; set; }
        public DateTime OrderDate { get; set; }
        public long DepOrderStatusId { get; set; }
        public string OrderType { get; set; }
        public string Note { get; set; }
        public long ErpOrderId { get; set; }
        public string DeviceEnrollmentTransactionId { get; set; }
        public string DepOrderNumber { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public string ApiResponse { get; set; }
        public DateTime ApiTime { get; set; }
        public long ParentDepOrderId { get; set; }
        public bool IsProcessed { get; set; }
        public long LockedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public bool ReadyToSendApple { get; set; }
        public DateTime StatusCheckDate { get; set; }
        public bool IsArchived { get; set; }
        public string ErrorMessage { get; set; }
        public string OrderNote { get; set; }
        public bool IsCreditNote { get; set; }
        public int ManufactureId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsEdited { get; set; }
        public bool IsNotificationSent { get; set; }
        public long ReturnReasonID { get; set; }
    }
}