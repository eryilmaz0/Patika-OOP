namespace Movie
{
    public class OperationResult
    {
        public bool IsSuccess { get; set; }
        public string ResultMessage { get; set; }

        public OperationResult(bool ısSuccess, string resultMessage)
        {
            IsSuccess = ısSuccess;
            ResultMessage = resultMessage;
        }
    }
}