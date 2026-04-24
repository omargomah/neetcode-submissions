public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
                for (int i = 0;i < 9 ; i++) 
            {
                int[] arr = new int[10];
                for (int j = 0; j < 9; j++)
                    if(board[i][j]!='.')
                        arr[board[i][j]-48]++;
                for (int k = 1; k < 10; k++)
                    if (arr[k]>1)
                        return false;
            }
            for (int i = 0;i < 9 ; i++) 
            {
                int[] arr = new int[10];
                for (int j = 0; j < 9; j++)
                    if(board[j][i]!='.')
                        arr[board[j][i]-48]++;
                for (int k = 1; k < 10; k++)
                    if (arr[k]>1)
                        return false;
            }
            for (int a = 0; a < 9; a++)
            {
                int[] arr = new int[10];
                for (int i = (a%3 == 0 ? a : a/3 * 3)   ; i < (a % 3 == 0 ? a + 3 : a / 3 * 3 + 3) ; i++) 
                {
                    for (int j = a % 3 * 3; j < a % 3 * 3 + 3; j++)
                        if(board[i][j]!='.')
                            arr[board[i][j]-48]++;
                }
                for (int k = 1; k < 10; k++)
                    if (arr[k]>1)
                        return false;
            }
            return true;    
    }
}
