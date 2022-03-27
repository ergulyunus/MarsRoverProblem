namespace MarsRover.Core.Rover
{
    public interface IRover
    {
        /// <summary>
        ///  Gezginin hareketini aldığı komut dizisine göe başlatır. 
        /// </summary>
        /// <param name="commands"> string olarak komut bilgisi L,R,M değerlerinden oluşmalıdır. </param>
        /// <returns> void </returns>
        void StartAction(string commands);
    }
}
