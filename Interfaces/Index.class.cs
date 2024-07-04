namespace TicTacToe
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Index
    {
            public int Row { get; set; }
            public int Column { get; set; }
            public Index(int row, int column)
            {
                  this.Row = row;
                  this.Column = column;
            }

            public Index(string str) 
            {
                  string[] parts = str.Split(",");

                  this.Row = int.Parse(parts[0]);

                  this.Column = int.Parse(parts[1]);
            }

        public override bool Equals(object? obj)
        {
            var otherIndex = obj as Index;

            return this.Row == otherIndex?.Row && this.Column == otherIndex.Column;
        }

        public override string ToString()
        {
            return $"{this.Row},{this.Column}";
        }
    }
}