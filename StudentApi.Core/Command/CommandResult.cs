using System.Collections.Generic;

namespace StudentApi.Core.Command
{
    public class CommandResult
    {
        public CommandResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public dynamic Result { get; set; }
        public bool IsSuccess { get; }

        public IList<string> Messages { get; set; }

    }
}
