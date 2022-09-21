namespace MTechSystems.Test.Stages
{
	public class Stage3
	{
		static void Main(string[] args)
		{
			/*
			 The data source for the query is a simple list of Student objects. 
			 Each Student record has a first name, last name, and an array of scores that represents their test scores in the class. 
			 1) Produce a sequence of Students whose total score is greater than the class average, together with their Student ID, Score
			 class average > 334
			 Output:
				Student ID: 113, Score: 338
				Student ID: 114, Score: 353
				Student ID: 116, Score: 369
				Student ID: 117, Score: 352
				Student ID: 118, Score: 343
				Student ID: 120, Score: 341
				Student ID: 122, Score: 368
			*/
			var data = DataSource.Students;

			double avgStudents = data.Sum(x => x.Scores.Sum(x=> x.Score)) / data.Count;

			foreach(var student in data)
            {
				if(student.Scores.Sum(x=>x.Score) > avgStudents)
                {
                    Console.WriteLine($"Student ID: {student.ID}, Score: {student.Scores.Sum(x => x.Score)}");
                }
            }
		}
	}
}