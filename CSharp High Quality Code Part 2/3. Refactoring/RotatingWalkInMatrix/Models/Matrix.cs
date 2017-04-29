using System;
using RotatingWalkInMatrix.Contracts;

namespace RotatingWalkInMatrix.Models
{
    public class Matrix
    {
        public static void StartMatrixWalk(int matrixRowAndCols, ILogger logger)
        {
            if (matrixRowAndCols < 1 || 100 < matrixRowAndCols)
            {
                throw new ArgumentOutOfRangeException("Matrix rows and cols must be between 1 and 100!");
            }

            if (logger == null)
            {
                throw new ArgumentNullException("Logger cannot be null!");
            }

            int[,] matrix = new int[matrixRowAndCols, matrixRowAndCols];
            var step = matrixRowAndCols;
            var stepsCount = 1;
            var rowCoordinates = 0;
            var colCoordinates = 0;
            var deltaRol = 1;
            var deltaCol = 1;
            var isCellValid = stepsCount <= matrixRowAndCols * matrixRowAndCols;

            while (isCellValid)
            {
                matrix[rowCoordinates, colCoordinates] = stepsCount;

                var hasReachedDeadEnd = !HasAvaliableCells(matrix, rowCoordinates, colCoordinates);
                var hasNoEmptyCells = hasReachedDeadEnd && FindEmptyCell(matrix) == null;

                if (hasNoEmptyCells)
                {
                    PrintMatrixSteps(matrix, logger);
                    break;
                }

                if (hasReachedDeadEnd)
                {
                    var cellCoordinates = FindEmptyCell(matrix);

                    stepsCount++;
                    rowCoordinates = cellCoordinates[1];
                    colCoordinates = cellCoordinates[2];
                    deltaRol = 1;
                    deltaCol = 1;
                }
                else
                {
                    MoveToEmptyCell(matrix, ref rowCoordinates, ref colCoordinates, ref deltaRol, ref deltaCol, step, ref stepsCount);
                }
            }
        }

        private static void MoveToEmptyCell(
            int[,] matrix,
            ref int rowCoordinate,
            ref int colCoordinate,
            ref int deltaX,
            ref int deltaY,
            int cellsNumber,
            ref int stepsCount)
        {
            while (
                rowCoordinate + deltaX >= cellsNumber ||
                rowCoordinate + deltaX < 0 ||
                colCoordinate + deltaY >= cellsNumber ||
                colCoordinate + deltaY < 0 ||
                matrix[rowCoordinate + deltaX, colCoordinate + deltaY] != 0)
            {
                ChangeDirection(ref deltaX, ref deltaY);
            }

            rowCoordinate += deltaX;
            colCoordinate += deltaY;

            stepsCount++;
        }

        private static void ChangeDirection(ref int deltaRow, ref int deltaCol)
        {
            int[] rowDirection = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirection = { 1, 0, -1, -1, -1, 0, 1, 1 };

            var directionsIndex = 0;
            var directions = rowDirection.Length;

            for (var count = 0; count < directions; count++)
            {
                if (rowDirection[count] == deltaRow && colDirection[count] == deltaCol)
                {
                    directionsIndex = count;
                    break;
                }
            }

            if (directionsIndex == directions - 1)
            {
                deltaRow = rowDirection[0];
                deltaCol = colDirection[0];

                return;
            }

            deltaRow = rowDirection[directionsIndex + 1];
            deltaCol = colDirection[directionsIndex + 1];
        }

        private static bool HasAvaliableCells(int[,] arr, int row, int col)
        {
            int[] rowDirection = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirection = { 1, 0, -1, -1, -1, 0, 1, 1 };

            var directions = rowDirection.Length;
            var matrixRange = arr.GetLength(0);

            for (var i = 0; i < directions; i++)
            {
                var isRowOutOfRange = row + rowDirection[i] >= matrixRange || row + rowDirection[i] < 0;
                var isColOutOfRange = col + colDirection[i] >= matrixRange || col + colDirection[i] < 0;

                if (isRowOutOfRange)
                {
                    rowDirection[i] = 0;
                }

                if (isColOutOfRange)
                {
                    colDirection[i] = 0;
                }

                var isEmptyCells = arr[row + rowDirection[i], col + colDirection[i]] == 0;
                if (isEmptyCells)
                {
                    return true;
                }
            }

            return false;
        }

        private static int[] FindEmptyCell(int[,] matrix)
        {
            var cellsNumber = matrix.GetLength(0);
            int[] cellCoordinates;

            for (var row = 0; row < cellsNumber; row++)
            {
                for (var col = 0; col < cellsNumber; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        cellCoordinates = new int[] { matrix[row, col], row, col };
                        return cellCoordinates;
                    }
                }
            }

            return null;
        }

        private static void PrintMatrixSteps(int[,] matrix, ILogger logger)
        {
            var rowsNumber = matrix.GetLength(0);

            for (var row = 0; row < rowsNumber; row++)
            {
                for (var col = 0; col < rowsNumber; col++)
                {
                    logger.Write(string.Format("{0,3}", matrix[row, col]));
                }

                logger.WriteLine(string.Empty);
            }
        }
    }
}
