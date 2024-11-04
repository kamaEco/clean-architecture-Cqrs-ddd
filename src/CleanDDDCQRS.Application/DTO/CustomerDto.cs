namespace CleanDDDCQRS.Application
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // اگر نیاز به فیلدهای بیشتری دارید، می‌توانید آن‌ها را اضافه کنید
    }
}
