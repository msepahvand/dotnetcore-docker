namespace StudentApi.Core.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }

        public string FullName => $"{GivenName}, {FamilyName}";
    }
}
