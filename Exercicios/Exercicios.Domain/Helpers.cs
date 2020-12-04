﻿using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public static class Helpers
    {
        public static Exception ConvertStringListToException(List<string> mensagens)
        {
            var exceptionMessage = "";
            foreach (var msg in mensagens)
                exceptionMessage += msg + Environment.NewLine;

            //if (string.IsNullOrWhiteSpace(exceptionMessage))
            //  return null;
            // else 
            //  return new Exception(exceptionMessage);

            return string.IsNullOrWhiteSpace(exceptionMessage)  // IsNullOrWhiteSpace (verifica se está nula ou com espaços em Branco
                ? null
                : new Exception(exceptionMessage);
        }
    }
}
