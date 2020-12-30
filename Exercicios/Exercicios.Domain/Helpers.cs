using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public static class Helpers
    {
        public static Exception CovertStringListToException(List<string> mensagens)
        {
            var exceptionMessage = "";
            foreach (var msg in mensagens)
                exceptionMessage += msg + Environment.NewLine;

            if (string.IsNullOrWhiteSpace(exceptionMessage))
                return null;
            else
                return new Exception(exceptionMessage);
        }
    }
}
