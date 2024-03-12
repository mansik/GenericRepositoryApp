namespace GenericRepository.Entity
{
    internal class Student : BaseEntity
    {
        public int StudentID { get; set; }
        public required string FullName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }

        public override string TableName => "Student";

        public override string IdKeyColumnName => "StudentID";

        public override string InsertSqlTemplate => @"INSERT INTO Student(FullName ,Gender ,Age ,Address) 
                                                    VALUES (@FullName ,@Gender ,@Age ,@Address);";

        public override string UpdateSqlTemplate => @"UPDATE Student SET FullName = @FullName ,Gender = @Gender 
                                                        ,Age = @Age ,Address = @Address ,ModifedDate = getdate()
                                                    WHERE StudentID = @StudentID;";
    }
}
