using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finance_tracker_app.Entities
{
    public class RecurringTransactionAttachment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public int RecurringTransactionId { get; set; }

        public RecurringTransaction RecurringTransaction { get; set; }
    }
}
