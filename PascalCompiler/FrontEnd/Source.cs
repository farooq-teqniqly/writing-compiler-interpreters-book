using System;
using System.IO;
using System.Threading.Tasks;

namespace Teqniqly.Compilers.Pascal
{
    public class Source
    {
        private const char Eol = '\n';
        private const char Eof = (char)0;

        private readonly StreamReader reader;
        private string line;
        private int lineNumber;
        private int currentPosition;

        public async Task<Char> GetCurrentCharAsync()
        {
            if (this.currentPosition == -2)
            {
                await this.ReadLineAsync().ConfigureAwait(false);
                return this.NextChar;
            }

            if (Check.IsNullOrWhitespace(this.line))
            {
                return Source.Eol;
            }

            if (this.currentPosition > this.line.Length)
            {
                await this.ReadLineAsync();
                return await this.GetCurrentCharAsync();
            }

            return this.line[this.currentPosition];
        }

        public async Task<char> GetNextCharAsync()
        {
            this.currentPosition++;
            return await this.GetCurrentCharAsync();
        }

        public char NextChar { get; set; }

        public Source(StreamReader reader)
        {
            Ensure.NotNull(reader, nameof(reader));
            this.reader = reader;
            this.lineNumber = 0;
            this.currentPosition = -2;
        }

        private async Task ReadLineAsync()
        {
            this.line = await this.reader.ReadLineAsync().ConfigureAwait(false);
            this.currentPosition = -1;

            if (!Check.IsNullOrWhitespace(this.line))
            {
                this.lineNumber++;
            }
        }
    }
}