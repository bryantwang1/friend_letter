using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["form.cshtml"];
            };
            Get["/greeting_card"] = _ => {
                LetterVariables myLetterVariables = new LetterVariables();
                myLetterVariables.SetRecipient(Request.Query["recipient"]);
                myLetterVariables.SetSender(Request.Query["sender"]);
                myLetterVariables.SetLocation(Request.Query["location"]);
                myLetterVariables.SetSouvenir(Request.Query["souvenir"]);
                return View["hello.cshtml", myLetterVariables];
            };
            Get["/favorite_photos"] = _ => View["favorite_photos.html"];
        }
    }
}
