type EdgeNode = {
  y: number;
  weight: number;
  next: EdgeNode;
};

type Graph = {
  edges: EdgeNode[];
  degree: number;
  nvertices: number;
  nedges: number;
  directed: boolean;
};

const initializeGraph = () => {};

const readGraph = (): Graph => {
  return {
    edges: [],
    degree: 0,
    nvertices: 1,
    nedges: 0,
    directed: false,
  };
};

const insertEdge = () => {};

const printGraph = (g: Graph) => {
  for (let i = 1; i <= g.nvertices; i++) {
    // print the vertex
    console.log(`${i}:`);
    // print the vertex's edges
    let nextAdjascentEdge = g.edges[i];
    while (nextAdjascentEdge) {
      console.log(nextAdjascentEdge.y);
      nextAdjascentEdge = nextAdjascentEdge.next;
    }
    console.log("---");
  }
};

// ./node_modules/.bin/ts-node 5.2-data-structures-for-graphs.ts
const graph = readGraph();
printGraph(graph);
