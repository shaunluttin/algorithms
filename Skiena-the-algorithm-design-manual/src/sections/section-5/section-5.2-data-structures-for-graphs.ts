import os from "os";
import { Graph } from "./Graph";

const initializeGraph = (): Graph => ({
  edges: [],
  degree: [],
  nvertices: 0,
  nedges: 0,
  directed: false,
});

/**
 * [mutation] Insert an edge that starts at `x` and goes to `y`.
 */
const insertEdge = (
  g: Graph,
  [x, y]: [number, number],
  directed = false
): void => {
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
export const readGraph = (graphData: string): Graph => {
  const [[nvertices, nedges], ...graphEdgeData] = graphData
    .split(os.EOL)
    .filter((line) => !line.startsWith("#"))
    .map((line) => line.split(" ").map((n) => parseInt(n, 10)));

  const g = initializeGraph();

  for (const [x, y] of graphEdgeData) {
    insertEdge(g, [x, y]);
  }

  return {
    ...g,
    nvertices,
    nedges,
  };
};

export const printGraph = (g: Graph): string => {
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
