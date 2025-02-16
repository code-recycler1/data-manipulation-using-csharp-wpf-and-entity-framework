namespace StaticsExercise_Models
{
    /// <summary>
    /// Static class containing scientific formulas.
    /// </summary>
    public static class ScientificFormulas
    {
        /// <summary>
        /// Gravitational acceleration constant (m/s²).
        /// </summary>
        public const double GravitationalAcceleration = 9.81;

        /// <summary>
        /// Calculates the gravitational force (F = m * g).
        /// </summary>
        public static double GravityForce(double mass)
        {
            return mass * GravitationalAcceleration;
        }

        /// <summary>
        /// Calculates the work done (W = F * d).
        /// </summary>
        public static double Work(double force, double displacementInMeters)
        {
            return force * displacementInMeters;
        }

        /// <summary>
        /// Calculates the power (P = W / t).
        /// </summary>
        public static double Power(double work, int duration)
        {
            return work / duration;
        }

        /// <summary>
        /// Calculates the gravitational potential energy (U = m * g * h).
        /// </summary>
        public static double GravitationalPotentialEnergy(double mass, double heightInMeters)
        {
            return GravityForce(mass) * heightInMeters;
        }
    }
}