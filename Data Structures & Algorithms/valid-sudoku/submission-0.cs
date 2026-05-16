public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // ROW CHECK
        for (int row = 0; row < 9; row++) {
            HashSet<char> set = new HashSet<char>();

            for (int col = 0; col < 9; col++) {
                char value = board[row][col];

                if (value == '.')
                    continue;

                if (set.Contains(value))
                    return false;

                set.Add(value);
            }
        }

        // COLUMN CHECK
        for (int col = 0; col < 9; col++) {
            HashSet<char> set = new HashSet<char>();

            for (int row = 0; row < 9; row++) {
                char value = board[row][col];

                if (value == '.')
                    continue;

                if (set.Contains(value))
                    return false;

                set.Add(value);
            }
        }

        // 3x3 BOX CHECK
        for (int boxRow = 0; boxRow < 9; boxRow += 3) {
            for (int boxCol = 0; boxCol < 9; boxCol += 3) {
                HashSet<char> set = new HashSet<char>();

                for (int row = boxRow; row < boxRow + 3; row++) {
                    for (int col = boxCol; col < boxCol + 3; col++) {
                        char value = board[row][col];

                        if (value == '.')
                            continue;

                        if (set.Contains(value))
                            return false;

                        set.Add(value);
                    }
                }
            }
        }

        return true;
    }
}