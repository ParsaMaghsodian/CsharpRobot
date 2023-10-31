// See https://aka.ms/new-console-template for more information
using CsharpRobot;
using Telegram.Bot;

int Offset = 0;
string mytoken = "6829757037:AAFmYUGTwqzacQ1IvxLkuyVsiDisREy3k8k";
var Mybot = new TelegramBotClient(mytoken);
while (true)
{
    var updates = await Mybot.GetUpdatesAsync(Offset);
    foreach (var update in updates)
    {
        Offset = update.Id + 1;
        var message = update.Message != null ? update.Message : null;
        var text = update.Message.Text != null ? update.Message.Text : null;
        var chatid = update.Message.Chat.Id;
        var msgid = update.Message.MessageId;
        if (text != null && message != null)
        {
            switch (text)
            {
                case "/start":
                    await Mybot.SendTextMessageAsync(chatid, "(: سلام خوشحالم من رو استارت کردی", replyToMessageId: msgid);
                    break;
                case string a when a.Contains("سلام"):
                    await Mybot.SendTextMessageAsync(chatid, "علیکم سلام برادر", replyToMessageId: msgid);
                    break;
                case string b when b.Contains("شمسی پور"):
                     await Mybot.SendTextMessageAsync(chatid, "یه دانشگاه تخمی", replyToMessageId: msgid);
                    break;
                case "/now":
                    var datetime = DateTime.Now.ToString();
                    await Mybot.SendTextMessageAsync(chatid, datetime, replyToMessageId: msgid);
                    break;
                case "قیمت بیت کوین":
                    await Mybot.SendTextMessageAsync(chatid, await Crypto.CryptoPriceAsync("Bitcoin"), replyToMessageId: msgid);
                    break;

                case "قیمت اتریوم":
                    await  Mybot.SendTextMessageAsync(chatid, await Crypto.CryptoPriceAsync("Ethereum"), replyToMessageId: msgid);
                    break;
                case "لایت کوین":
                 await   Mybot.SendTextMessageAsync(chatid, await Crypto.CryptoPriceAsync("LiteCoin"), replyToMessageId: msgid);
                    break;
                //case "استان ها":
                //        await Mybot.SendTextMessageAsync(chatid, await OghatSharei.ShowProvincesAsync(), replyToMessageId: msgid);
                //    break;
            }
        }
    }


}
