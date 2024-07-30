namespace Domain
{
    public class ValueResult
    {
        public bool IsSuccess { get; }
        public string? ErrorMessage { get; }

        protected ValueResult(bool isSuccess, string? errorMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }
        public static ValueResult Success()
        {
            return new ValueResult(true, null);
        }

        public static ValueResult Failure(string errorMessage)
        {
            return new ValueResult(false, errorMessage);
        }
    }

    public class ValueResult<T> : ValueResult
    {
        public T? Value { get; }

        protected ValueResult(T? value, bool isSuccess, string? errorMessage)
            : base(isSuccess, errorMessage)
        {
            Value = value;
        }

        public static ValueResult<T> Success(T? value)
        {
            return new ValueResult<T>(value, true, null);
        }

        public static new ValueResult<T> Failure(string? errorMessage)
        {
            return new ValueResult<T>(default, false, errorMessage);
        }
    }
}
