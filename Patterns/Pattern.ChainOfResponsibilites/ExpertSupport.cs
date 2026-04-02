using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.ChainOfResponsibilites
{
    public class ExpertSupport : SupportHandler
    {
        public override void HandleRequest(string issue, int severity)
        {
            if (severity <= 4)
            {
                Console.WriteLine($"[ExpertSupport] Решена проблема: {issue}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue, severity);
            }
        }
    }
}
