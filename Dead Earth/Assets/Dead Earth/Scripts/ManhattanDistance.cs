using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManhattanDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// function A*(Node startNode, Node targetNode) 
// {
//     Node currentNode = null;
//     List openList = new List(Empty);
//     List closedList = new List(Empty);
//     startNode.gScore = 0;
//     startNode.fScore = startNode.gScore + hScore(startNode, targetNode)
//     openList.Add(startNode);

//     while(!openList.isEmpty)
//     {
//         currentNode = openList.GetLowestFScore();
//         if (currentNode == targetNode) return construct_path(targetNode);

//         openList.Remove(currentNode);
//         closedList.Add(currentNode);
    

//         foreach (Node neighborNode in currentNode.neighbors)
//         {
//             if (!closedList.Exists(neighborNode))
//             {
//                 if(neighborNode is Diagonal Neighbor)
//                     MovementCost = 14;
//                 else 
//                     MovementCost = 10;
                
//                 float tentitiveGScore = currentNode.gScore + MovementCost;

//                 if(!openList.Exists(neighborNode))
//                 {
//                     neighborNode.gScore = tentitiveGScore;
//                     neighborNode.fScore = neighborNode.gScore + hScore(neighborNode, targetNode);
//                     neighborNode.parent = currentNode;
//                     openList.Add(neighborNode);
//                 }
//                 else
//                 {
//                     if(tentitiveGScore < neighborNode.gScore)
//                     {
//                         neighborNode.gScore = tentitiveGScore;
//                         neighborNode.fScore = neighborNode.gScore + hScore(neighborNode, targetNode);
//                         neighborNode.parent = currentNode;
//                     }
//                 }
//             }
//         }
//     }

//     return false;
// }


// function hScore(Node source, Node target) 
// {
//     xDelta = abs(target.position.x - source.position.x);
//     yDelta = abs(target.position.y - source.position.y);
    
//     return 10 * (xDelta + yDelta);
// }


// function construct_path(Node node)
// {
//     Stack path = new Stack(Empty);
//     do
//     {
//         path.push(node);
//         node = node.parent;
//     } while (node.parent.exists)

//     return path;
// }