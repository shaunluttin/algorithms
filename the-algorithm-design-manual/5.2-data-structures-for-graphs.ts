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
  return undefined;
};

const insertEdge = () => {};

const printGraph = (g: Graph) => {
  console.log("foo");
};

// ./node_modules/.bin/ts-node 5.2-data-structures-for-graphs.ts
const graph = readGraph();
printGraph(graph);
