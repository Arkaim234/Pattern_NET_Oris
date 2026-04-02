namespace Pattern.ChainOfResponsibilites
{
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public void SetNext(SupportHandler next)
        {
            _nextHandler = next;
        }

        public abstract void HandleRequest(string issue, int severity);
    }
}
