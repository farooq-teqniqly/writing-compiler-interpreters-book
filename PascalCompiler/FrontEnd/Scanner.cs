namespace Teqniqly.Compilers.Pascal
{
    public abstract class Scanner
    {
        public Token CurrentToken { get; }
        public Token NextToken { get; }

        public char CurrentChar { get; }
        public char NextChar { get; }

        protected Source Source { get; }

        protected abstract Token ExtractToken();

    }
}