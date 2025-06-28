using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finance_tracker_app.Entities
{
    public class Attachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty ;

        public int? TransactionId { get; set; }

        public Transaction? Transaction { get; set; }

        public int? RecurringTransactionId { get; set; }

        public RecurringTransaction? RecurringTransaction { get; set; }
    }
}
