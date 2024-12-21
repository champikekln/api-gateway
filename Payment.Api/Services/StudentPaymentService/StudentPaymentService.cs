
namespace Payment.Api.Services.StudentPaymentService
{
    public class StudentPaymentService : IstudentPaymentService
    {
        private List<StudentPayment> _studentPaymentList = new List<StudentPayment>() {
            new StudentPayment() {
                StudentId = 1,
                Amount = 100,
                PaymentDate = DateTime.Now
            },
            new StudentPayment() {
                StudentId = 2,
                Amount = 200,
                PaymentDate = DateTime.Now
            }
        };
        public IEnumerable<StudentPayment> Get()
        {
            return _studentPaymentList;
        }
    }

    public class StudentPayment
    {
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
