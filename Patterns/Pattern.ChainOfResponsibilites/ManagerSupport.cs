using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.ChainOfResponsibilites
{
    public class ManagerSupport : SupportHandler
    {
        public override void HandleRequest(string issue, int severity)
        {
            if (severity <= 5)
            {
                Console.WriteLine($"[ManagerSupport] Решена проблема: {issue}");
            }
            else
            {
                Console.WriteLine("Проблема слишком сложная, требуется совет директора");
            }
        }
    }
}
