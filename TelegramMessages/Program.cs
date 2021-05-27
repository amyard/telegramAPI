using System;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace TelegramMessages
{
    class Program
    {
        private static ITelegramBotClient botClient;
        private const string apiToken = "1775052882:AAGxetPJvW9EmulVUxcrp_IzZHAnmsSnIPI";
        private const long chatId = -1001298396195;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            botClient = new TelegramBotClient(apiToken) {Timeout = TimeSpan.FromSeconds(10)};
            var me = botClient.GetMeAsync().Result;

            // Console.WriteLine($"Bot id - {me.Id} : {me.Username}");
            //
            // botClient.SendTextMessageAsync(chatId, "Hello world! \nNew line");
            //
            // botClient.SendTextMessageAsync(
            //     chatId: chatId,
            //     text: "<b>Bold text</b> was here",
            //     parseMode: ParseMode.Html
            // );

            string name = "Аня";            
            string email = "asd@asd.com";            
            string phone = "Не указан";            
            string course = "WordShop";            
            string courseType = "Silver";            
            int price = 5;

            string template = "<b>Новый подписчик</b> УРАААААА!!!!\n" +
                              "<b>Имя</b> - <i>{0}</i>\n" +
                              "<b>Емейл</b> - <i>{1}</i>\n" +
                              "<b>Телефон</b> - <i>{2}</i>\n" +
                              "<b>Курс</b> - <i>{3} ({4})</i>\n" +
                              "<b>Цена</b> - <i>${5}</i>";
            
            string message = String.Format(template, name, email, phone, course, courseType, price);
            
            botClient.SendPhotoAsync(
                chatId: chatId,
                photo: "https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
                caption: message,
                parseMode: ParseMode.Html
            );
            
            Console.ReadKey();
        }
    }
}