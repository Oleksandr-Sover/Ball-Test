namespace BallTest.GameLogic
{
    public interface IMovement
    {
        public float Speed { get; set; }
        public IDirection Direction { get; set; }
    }
}