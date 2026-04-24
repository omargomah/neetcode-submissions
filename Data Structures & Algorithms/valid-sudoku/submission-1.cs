public class Solution {
    public bool IsValidSudoku(char[][] board) {
                     char x,y;
                for (int i = 0; i < 9; i++)
                {
                    HashSet<char> mapRow =  new HashSet<char>();
                    HashSet<char> mapColumn =  new HashSet<char>();
                    for (int j = 0; j < 9; j++)
                    {
                        x = board[i][j];
                        y = board[j][i];
                        if (x != '.')
                        {
                            if (mapRow.Contains(x))
                                return false;
                            mapRow.Add(x);
                        }

                        if (y != '.')
                        {
                            if (mapColumn.Contains(y))
                                return false;
                            mapColumn.Add(y);
                        }

                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        HashSet<char> checkSet =  new HashSet<char>();
                        for (int h = i*3; h < (i * 3 + 3) ; h++)
                        {
                            for(int k = j*3; k < (j * 3 + 3); k++)
                            {
                                x = board[h][k];
                                if (x != '.')
                                {
                                    if (checkSet.Contains(x))
                                        return false;
                                    checkSet.Add(x);
                                }
                            }

                        }
                    }
                }
                return true;

   
    }
}
