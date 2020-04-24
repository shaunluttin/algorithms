import getFigure54 from "../figures/getFigure54";
import { Graph, readGraph } from "./section-5.2-data-structures-for-graphs";
import {
  dequeue,
  emptyQueue,
  enqueue,
  initQueue,
  processEdge,
  processVertexEarly,
  processVertexLate,
} from "./todo";

const discovered: boolean[] = [];
const processed: boolean[] = [];
const parent: number[] = [];

const initializeSearch = (graph: Graph): void => {
  for (let i = 1; i <= graph.nvertices; i++) {
    processed[i] = discovered[i] = false;
    parent[i] = -1;
  }
};

const bfs = (g: Graph, start: number): void => {
  let q: unknown;
  let v: number;
  let y: number;

  initQueue(q);
  enqueue(q, start);
  discovered[start] = true;

  while (!emptyQueue(q)) {
    v = dequeue(q);
    processVertexEarly(v);
    processed[v] = true;

    let p = g.edges[v];
    while (p) {
      y = p.y;
      if (!processed[y] || g.directed) {
        processEdge(v, y);
      }

      if (!discovered[y]) {
        enqueue(q, y);
        discovered[y] = true;
        parent[y] = v;
      }

      p = p.next;
    }

    processVertexLate(v);
  }
};

const graph = readGraph(getFigure54());

initializeSearch(graph);

bfs(graph, 1);
