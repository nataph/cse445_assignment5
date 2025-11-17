using System;

namespace HobbyWebApp
{
    public class ValueEstimator : IValueEstimator
    {
        public decimal GetEstimatedValue(decimal originalPrice, int purchaseYear)
        {
            int currentYear = DateTime.Now.Year;
            int yearsOwned = currentYear - purchaseYear;

            // 5% simple appreciation per year
            decimal appreciationRate = 0.05m; // 'm' for decimal

            if (yearsOwned <= 0)
            {
                return originalPrice; // No appreciation
            }

            decimal estimatedValue = originalPrice * (1 + (appreciationRate * yearsOwned));

            return Math.Round(estimatedValue, 2);
        }
    }
}