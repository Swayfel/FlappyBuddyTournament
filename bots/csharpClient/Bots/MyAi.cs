using CsClient.Bots.Internal;

namespace CsClient.Bots
{
    public class MyAi : IBot
    {
        /// <inheritdoc/>
        public string Name { get; }

        private bool _fly = true;

        /// <inheritdoc/>
        public bool Play(PlayState? playState)
        {
            if (playState.Player.PosY < 50)
                _fly = false;

            if (playState.Player.PosY > 480)
                _fly = true;
            // put your logic here
            return _fly;
        }

        public MyAi()
        {
            // give your bot a super duper cool name
            Name = "Swayfelbot";
        }
    }
}