using System;
using GameGeniusIdiotLibrary;
namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            var questionStorage = new QuestionStorage();
            var userStorage = new UserStorage();
            var exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.Write("Добро пожаловать в игру Гений-Идиот!");
                Console.WriteLine(" Меню: ");
                Console.WriteLine("1.Начать новую игру");
                Console.WriteLine("2.Посмотреть прогресс");
                Console.WriteLine("3.Очистить прогресс");
                Console.WriteLine("4.Добавить вопрос");
                Console.WriteLine("5.Удалить вопрос");
                Console.WriteLine("6.Выход");
                var playerChoise = 0;
                if (InputValidator.CheckNumber(Console.ReadLine(), out playerChoise))
                    switch (playerChoise)
                    {
                        case 1: { GenerateNewGame(userStorage); break; }
                        case 2: { ShowProgress(); break; }
                        case 3: { ClearProgress(); break; }
                        case 4: { AddNewQuestion(); break; }
                        case 5: { RemoveQuestion(); break; }
                        case 6: { exit = true; break; }
                    }
                else { Console.WriteLine("Введите корректный номер"); }
            }
        }


        private static void RemoveQuestion()
        {
            ClearConsole();
            Console.WriteLine("Полный список всех вопросов в игре: ");
            PrintStorage();
            Console.WriteLine("Удалить вопрос. Для выхода нажмите ESCAPE.Для продолжения любую клавишу");
            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            if (QuestionStorage.Questions.Count == 1)
                Console.WriteLine("Невозможно удалить вопрос, иначе вопросов в игре не останется =)");
            else
            {
                Console.WriteLine("Напишите номер вопрос который хотите удалить");
                var questionNumber = 0;
                while (true)
                {
                    var data = Console.ReadLine();
                    if (InputValidator.CheckNumber(data, out questionNumber)) break;
                    else { Console.WriteLine("Введите корректное число"); }
                }
                if (questionNumber <= 0 || questionNumber > QuestionStorage.Questions.Count)
                {
                    Console.WriteLine("Неверный номер вопроса, попробуйте снова");
                    Console.ReadKey();
                    RemoveQuestion();
                }
                for (int i = 1; i <= QuestionStorage.Questions.Count; i++)
                {
                    if (i == questionNumber)
                    {
                        QuestionStorage.RemoveData(QuestionStorage.Questions[i - 1]);
                        break;
                    }
                }
                Console.WriteLine("Удалено успешно!!!! Для выхода нажмите любую клавишу: ");
            }
            Console.ReadKey();
            ClearConsole();
            return;
        }

        public static void AddNewQuestion()
        {
            ClearConsole();
            Console.WriteLine("Добавить вопрос. Для выхода нажмите ESCAPE.Для продолжения любую клавишу");
            if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            Console.WriteLine("Напишите вопрос:");
            var questionText = СheckQuestion();
            Console.WriteLine("Напишите ответ:");
            var answer = 0;
            while (true)
            {
                var data = Console.ReadLine();
                if (InputValidator.CheckNumber(data, out answer)) break;
                else { Console.WriteLine("Введите корректное число"); }
            }
            Question question = new(questionText, answer);
            QuestionStorage.AddData(question);
            ClearConsole();
        }
        public static void ClearProgress()
        {
            FileProvider.Clear(UserStorage.FileName);
            FileProvider.Clear(QuestionStorage.FileName);
            UserStorage.Clear();
        }
        public static string СheckQuestion()
        {
            var question = Console.ReadLine();
            if (question.Length < 3)
            {
                Console.WriteLine("Какой то короткий вопрос. Попробуйте снова");
                question = СheckQuestion();
            }
            return question;
        }
        public static void ClearConsole()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
        }
        static void GenerateNewGame(UserStorage userStorage)
        {
            StartGame();
            Console.WriteLine($"Желаете принять участие еще раз? Если хотите, то введите 'да', если нет то любой другой текст");
            var replay = Console.ReadLine();
            if (replay?.ToLower() == "да") GenerateNewGame(userStorage);
            else return;
        }
        private static bool CheckUserAnswer(int rightAnswer)
        {
            var userAnswer = 0;
            while (true)
            {
                var data = Console.ReadLine();
                if (InputValidator.CheckNumber(data, out userAnswer)) break;
                else { Console.WriteLine("Введите корректное число"); }
            }
            return userAnswer == rightAnswer;
        }
        public static void StartGame()
        {
            ClearConsole();
            Console.WriteLine("Введите имя: ");
            var PlayerName = Console.ReadLine();
            Console.WriteLine("Ваше имя принято! ");
            var questions = QuestionStorage.Questions;
            var questionNumber = 1;
            var user = new User(PlayerName);
            foreach (var question in questions)
            {
                Console.WriteLine($"Вопрос №{questionNumber++}: {question.TextValue}");
                if (CheckUserAnswer(question.Answer))
                {
                    user.AcceptRightAnswer();
                }
            }
            user.Diagnosis = DiagnoseCaluculator.GetDiagnosis(user.CountRightAnswers, QuestionStorage.Questions.Count);
            Console.WriteLine($"{user.Name},вы {user.Diagnosis}");
            UserStorage.Add(user);
        }
        public static void PrintStorage()
        {
            var counter = 1;
            foreach (var question in QuestionStorage.Questions)
            {
                Console.WriteLine(counter + ". " + question.TextValue);
                counter++;
            }
        }
        public static void ShowProgress()
        {
            ClearConsole();
            Console.WriteLine("Ваш прогресс");
            Console.WriteLine("Имя      Число правильных ответов Диагноз");
            foreach (var progress in UserStorage.Users) Console.WriteLine("{0,-10}{1,10}{2,20}", progress.Name, progress.CountRightAnswers, progress.Diagnosis);
            Console.ReadKey();
            ClearConsole();
        }
    }
}