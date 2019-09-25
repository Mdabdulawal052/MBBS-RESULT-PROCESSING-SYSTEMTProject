ALTER PROCEDURE [dbo].[AnaOne]
	@Roll1 int,
	@Roll2 int
AS
	BEGIN
		select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,Subject,ANA_A1,ANA_B1,ANA_MCQ1,ANA_Formative1
                                    from Student
                                    left join ANATOMY
                                    on Student.Reg_NO=ANATOMY.Reg_NO
									where EXam_Roll Between @Roll1 AND @Roll2;
	END
