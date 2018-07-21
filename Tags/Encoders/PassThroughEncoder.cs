namespace Tags.Encoders
{
    public class PassThroughEncoder : StringEncoder
    {
        public string Encode(string original)
        {
            return original;
        }
    }
}