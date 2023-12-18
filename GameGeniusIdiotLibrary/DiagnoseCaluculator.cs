namespace GameGeniusIdiotLibrary
{
    public class DiagnoseCaluculator
    {
        public static Diagnoses GetDiagnosis(int countRightAnswers, int questionCount)
        {
            var procentCorrectAnswers = (double)countRightAnswers / questionCount * 100;
            var index = (int)Math.Ceiling(procentCorrectAnswers / 20);
            return (Diagnoses)index;
        }
    }
}