namespace InterfacesExercise_Models
{
    /// <summary>
    /// Defines movement capabilities for objects that can move in four directions.
    /// </summary>
    interface IMovable
    {
        /// <summary>
        /// Moves the object up.
        /// </summary>
        void MoveUp();

        /// <summary>
        /// Moves the object down.
        /// </summary>
        void MoveDown();

        /// <summary>
        /// Moves the object left.
        /// </summary>
        void MoveLeft();

        /// <summary>
        /// Moves the object right.
        /// </summary>
        void MoveRight();
    }
}
