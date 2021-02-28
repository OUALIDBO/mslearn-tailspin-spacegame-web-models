using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Profile : Model
    {
        // The player's user name.
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        // The URL of the player's avatar image.
        [JsonProperty(PropertyName = "avatarUrl")]
        public string AvatarUrl { get; set; }

        // The achievements the player earned.
        [JsonProperty(PropertyName = "achievements")]
        public string[] Achievements { get; set; }

        // The game style (difficulty) the score is associated with.
        [JsonProperty(PropertyName = "gameStyle")]
        public string GameStyle { get; set; }
    }
}
