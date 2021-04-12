namespace Speik.TechnicalTest
{
    public interface IRandomNumberGenerator
    {
        /// <summary>
        /// Returns a random number between 0 and the <paramref name="maximum"/>
        /// </summary>
        /// <remarks><paramref name="maximum"/> is inclusive</remarks>
        int GetNumber(int maximum);
    }
}