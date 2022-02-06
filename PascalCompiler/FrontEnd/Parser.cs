namespace Teqniqly.Compilers.Pascal
{
    public abstract class Parser
    {
        protected ICode Code { get; }
        protected static SymbolTable SymbolTable { get; }

        public abstract int ErrorCount { get; }

        public Token CurrentToken => this.Scanner.CurrentToken;
        public Token NextToken => this.Scanner.NextToken;

        protected Scanner Scanner { get; }

        protected Parser(Scanner scanner)
        {
            Ensure.NotNull(scanner, nameof(scanner));
            Scanner = scanner;
        }

        public abstract void Parse();

    }
}
