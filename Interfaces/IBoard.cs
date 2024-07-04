namespace TicTacToe
{
      public interface IBoard
      {
            bool isFull();

            void PlaceSymbol(Index index, Symbol symbol);


            IEnumerable<Index> GetEmptyPositions();

            Symbol GetRowSymbol(int row);

            Symbol GetColumnSymbol(int column);

            Symbol GetDiagonalTLBRSymbol();

            Symbol GetDiagonalTRBLSymbol();
      }
}