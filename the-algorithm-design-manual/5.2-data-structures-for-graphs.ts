import fs from "fs";
import os from "os";

type EdgeNode = {
  y: number;
  next: EdgeNode;
  weight?: number;
};

type Graph = {
  edges: EdgeNode[];
  degree: number[];
  nvertices: number;
  nedges: number;
  directed: boolean;
};

const initializeGraph = (): Graph => ({
  edges: [],
  degree: [],
  nvertices: 0,
  nedges: 0,
  directed: false,
});

/**
 * [The] graph format consists of an initial line featuring the number of vertices and
 * edges in the graph, followed by a listing of the edges at one vertex pair per line.
 */
const readGraph = (relativePath: string): Graph => {
  const [[nvertices, nedges], ...graphEdgeData] = fs
    .readFileSync(relativePath, {
      encoding: "utf8",
    })
    .split(os.EOL)
    .map((line) => line.split(" ").map((n) => parseInt(n, 10)));

  const graph = initializeGraph();

  for (const [x, y] of graphEdgeData) {
    insertEdge(graph, [x, y]);
  }

  return {
    ...graph,
    nvertices,
    nedges,
  };
};

/**
 * [mutation] Insert an edge that starts at `x` and goes to `y`.
 */
const insertEdge = (g: Graph, [x, y]: [number, number], directed = false) => {
  /**
   * Insert this edge at the head of the linked list of edges that start at `x`.
   */
  g.edges[x] = {
    y,
    next: g.edges[x],
  };

  g.degree[x]++;
};

const printGraph = (g: Graph): string => {
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
const graph = readGraph("./5.2-data-structures-for-graphs.txt");
const graphString = printGraph(graph);

console.log(`Here is the graph: ${os.EOL}${graphString}`);
