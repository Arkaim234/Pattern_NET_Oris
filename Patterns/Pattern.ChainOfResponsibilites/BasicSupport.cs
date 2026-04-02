using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.ChainOfResponsibilites
{
    public class BasicSupport : SupportHandler
    {
        public override void HandleRequest(string issue, int severity)
        {
            if (severity <= 2)
            {
                Console.WriteLine($"[BasicSupport] Решена проблема: {issue}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue, severity);
            }
            else
            {
                Console.WriteLine("Никто не смог решить проблему");
            }
        }
    }
}
