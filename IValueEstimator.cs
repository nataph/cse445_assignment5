using System.ServiceModel;

namespace HobbyWebApp
{
    [ServiceContract]
    public interface IValueEstimator
    {
        [OperationContract]
        decimal GetEstimatedValue(decimal originalPrice, int purchaseYear);
    }
}