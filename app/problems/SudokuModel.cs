namespace Problems {
    public class Sudoku {
        private int[,] grid;
        private int length;
        private int size;
        public Sudoku(int size = 3){

            this.size = size;
            this.length = size * size;
            this.grid = new int[length, length];

        }

        public bool Solve() {
            int[,] lines = new int[length, length];
            int[,] cols = new int[length, length];
            int[,] squares = new int[length, length];

            for (int i = 0; i < length; i++) {
                for (int j = 0; j < length; j++) {
                    if (grid[i, j] != 0) {
                        lines[i, j] = 1;
                        cols[i, j] = 1;
                        squares[(j / size) + (i / size * size), j] = 1;
                    }   
                }
            }
            throw new NotImplementedException();
        }

        public void PrettyPrint() {
            for (int i = 0; i < length; i++) {
                if (i % size == 0) {
                    Console.Write('\n');
                }
                for (int j = 0; j < length; j++) {
                    if (j % size == 0) {
                        Console.Write("|");
                    }
                    Console.Write(' ' + grid[i,j].ToString() + ' ');
                }
                Console.Write("|\n");
            }
            Console.Write('\n');

        }
    }
}