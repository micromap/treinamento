using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public static class ListExtensions
    {
        public static Exception ToException(this List<string> mensagens)
        {
            var exceptionMessage = "";
            foreach (var msg in mensagens)
                exceptionMessage += msg + Environment.NewLine;

            return string.IsNullOrWhiteSpace(exceptionMessage)
                ? null
                : new Exception(exceptionMessage);
        }
    }
}