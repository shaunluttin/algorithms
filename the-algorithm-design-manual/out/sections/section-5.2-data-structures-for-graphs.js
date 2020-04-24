import fs from "fs";
import os from "os";
const initializeGraph = () => ({
  edges: [],
  degree: [],
  nvertices: 0,
  nedges: 0,
  directed: false,
});
/**
 * [mutation] Insert an edge that starts at `x` and goes to `y`.
 */
const insertEdge = (g, [x, y], directed = false) => {
  /**
   * Insert this edge at the head of the linked list of edges that start at `x`.
   */
  g.edges[x] = {
    y,
    next: g.edges[x],
  };
  if (!directed) {
    insertEdge(g, [y, x], true);
  } else {
    g.degree[x]++;
  }
};
/**
 * [The] graph format consists of an initial line featuring the number of vertices and
 * edges in the graph, followed by a listing of the edges at one vertex pair per line.
 */
export const readGraph = (relativePath) => {
  const [[nvertices, nedges], ...graphEdgeData] = fs
    .readFileSync(relativePath, {
      encoding: "utf8",
    })
    .split(os.EOL)
    .map((line) => line.split(" ").map((n) => parseInt(n, 10)));
  const g = initializeGraph();
  for (const [x, y] of graphEdgeData) {
    insertEdge(g, [x, y]);
  }
  return Object.assign(Object.assign({}, g), { nvertices, nedges });
};
const printGraph = (g) => {
  let printGraph = "";
  for (let vertex = 1; vertex <= g.nvertices; vertex++) {
    const adjacentEdges = [];
    let nextAdjascentEdge = g.edges[vertex];
    while (nextAdjascentEdge) {
      adjacentEdges.push(nextAdjascentEdge.y);
      nextAdjascentEdge = nextAdjascentEdge.next;
    }
    printGraph += `${vertex}: ${adjacentEdges.join(",")} ${os.EOL}`;
  }
  return printGraph;
};
// npm run tsnode 5.2-data-structures-for-graphs.ts
const graph = readGraph("../figures/figure-5.4.txt");
const graphString = printGraph(graph);
console.log(`Here is the graph: ${os.EOL}${graphString}`);
