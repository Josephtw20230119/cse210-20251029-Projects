

public record MathAssignment( string StudentName
                            , string Topic
                            , string TextbookSection
                            , string Problems) : Assignment(StudentName,Topic);