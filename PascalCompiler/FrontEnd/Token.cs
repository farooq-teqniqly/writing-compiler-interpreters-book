namespace Teqniqly.Compilers.Pascal
{
    public class Token
    {
        protected string Text { get; set; }
        protected object Value { get; set; }
        protected char CurrentChar { get; set; }
        protected char NextChar { get; set; }
        protected char PeekChar { get; set; }
        protected Source Source { get; set; }

        protected ITokenType TokenType { get; set; }

        private int lineNumber;
        private int position;

        protected void Extract()
        {

        }


    }
}