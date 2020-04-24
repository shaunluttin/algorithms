import getFigure from "../figures/getFigure";
import { dequeue, emptyQueue, enqueue, initQueue, Queue } from "../queue";
import { Graph, readGraph } from "./section-5.2-data-structures-for-graphs";
import {
  processEdge,
  processVertexEarly,
  processVertexLate,
} from "./section-5.6.1-exploiting-traveral";

type Hooks = {
  processVertexEarly: (v: number) => void;
  processVertexLate: (v: number) => void;
  processEdge: (x: number, y: number) => void;
};

const discovered: boolean[] = [];
const processed: boolean[] = [];
const parent: number[] = [];

const initializeSearch = (graph: Graph): void => {
  for (let i = 1; i <= graph.nvertices; i++) {
    processed[i] = discovered[i] = false;
    parent[i] = -1;
  }
};

const bfs = (g: Graph, start: number, hooks: Hooks): void => {
  const q: Queue<number> = initQueue();
  let v: number;
  let y: number;

  enqueue(q, start);
  discovered[start] = true;

  while (!emptyQueue(q)) {
    v = dequeue(q);
    hooks?.processVertexEarly(v);
    processed[v] = true;

    let p = g.edges[v];
    while (p) {
      y = p.y;
      if (!processed[y] || g.directed) {
        hooks?.processEdge(v, y);
      }

      if (!discovered[y]) {
        enqueue(q, y);
        discovered[y] = true;
        parent[y] = v;
      }

      p = p.next;
    }

    hooks?.processVertexLate(v);
  }
};

const graph = readGraph(getFigure(5.4));

initializeSearch(graph);

bfs(graph, 1, {
  processEdge,
  processVertexEarly,
  processVertexLate,
});
