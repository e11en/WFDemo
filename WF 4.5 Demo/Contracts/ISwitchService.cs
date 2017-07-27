using System.ServiceModel;

namespace Contracts
{
    [ServiceContract(Namespace = "http://dvep.nl/")]
    public interface ISwitchService
    {
        [OperationContract]
        SwitchReportConfirmation SubmitSwitchReport(SwitchReport switchReport);

        [OperationContract]
        [FaultContract(typeof(string))]
        void SubmitEdsnResponse(EdsnResponse edsnResponse);

        [OperationContract]
        void UpdateSwitch(SwitchReport switchReport);
    }
}
