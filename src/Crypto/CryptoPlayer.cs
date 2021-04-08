namespace TexasHoldem.Crypto
{
    public class CryptoPlayer : BasePlayer, IPlayer
    {
        public string Name { get; private set; }

        public int BuyIn { get; private set; }

        public CryptoPlayer()
        {
            this.Name = "0x00";
        }
    }
}
