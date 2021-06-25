using System.Collections.Generic;
class CountIslands {

    /*
    [
          0 1 2 3 4 
       0 [0 0 1 0 1],              Graph, -> Trees
       1 [0 1 1 0 0],
       2 [0 0 0 1 0],              Nondirected, Graph
       3 [0 0 0 0 0],              Spanish Conquistadors 
    ]
    expected: 2
    */

    public void Explore(int row, int col, int[,] matrix){ // "row,col" = false, true
        // is my row valid return
        // is my col valid return
        // is here visited return 
        // is here a 0 return

        // safe to explore more
        
        //                    u, d, l, r
        int[] rdirections = {-1, 1, 0, 0}; // row
        int[] cdirections = {0, 0, -1, 1}; // col 
        
        //Up
        Explore(row-rdirections[0],col,matrix); // [1, 1]
        Explore(row-rdirections[0],col,matrix);
        // if visited[here] == true || matrix[here] === 0 return
        // ask is here a 1?
        // if so, visited[here] = true
        // explore up, down, left, right
    }

    public int Solution(int[,] matrix) {

        int[,] test = {
            {0,0,1},
            {0,0,1},
        };

        int result = 0; // Number of islands

        /*
            - visited = dictionary<(row,col), true>
            - searching through the graph
            - if find a 1 && !visited(row, col)
               increment result++
               searchFunction ^ v < > the rest of the island, and put in visited as true
        */
        
        for (var row = 0; row < matrix.GetLength(0); row++)
        {
            for (var col = 0; col < matrix.GetLength(1); col++)
            {
                
            }
        }

        return 0;
    }
}