using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй. Напиши мне(Привет/Как дела?), если хочешь поговорить. Напиши stop и я прекращу общение!");
            string Word;
            do
            {
                Word = Console.ReadLine();
                Console.WriteLine(CheckWord(Word));
                Word = CheckWord(Word);
            }
            while (Word != "stop");
        }

        public static string CheckWord(string Word)
        {
            if (Word == "Привет")
            {
                Word = Hello();
                return Word;
            }
            if (Word == "Как дела?")
            {
                Word = Howru();
                return Word;
            }
            if (Word == "stop")
            {
                return Word;
            }
            return "Ошибка! Повторите попытку.";
        }

        private static string Hello()
        {
            Random rand = new Random();
            int random = rand.Next(9);
            switch (random)
            {
                case 0:
                    return "Доброго времени суток!";
                case 1:
                    return "Желаю приятно провести время!";
                case 2:
                    return "Рад Вас видеть!";
                case 3:
                    return "Пусть будет добрым твой день!";
                case 4:
                    return "Здравствуйте, я из Орифлейм!";
                case 5:
                    return "Здравствуйте, не желаете ли вы поговорить о боге?";
                case 6:
                    return "Я желаю Вам доброго пути!";
                case 7:
                    return "Hello, World!";
                case 8:
                    return "IIpuBeTcTByI0!";
                case 9:
                    return "Это десятая фраза, не знаю что написать... Привет?";
            }
            return "ето костыль";
        }
        private static string Howru()
        {
            Random rand = new Random();
            int random = rand.Next(5);
            switch (random)
            {
                case 0:
                    return "Отлично, а твои? Шутка, пока не отвечай.";
                case 1:
                    return "Прекрасно занимаюсь майни..., кхм, ничем.";
                case 2:
                    return "ок";
                case 3:
                    return "Как дела?";
                case 4:
                    return "А ты как думаешь?";
            }
            return "ето костыль";
        }
    }
}
