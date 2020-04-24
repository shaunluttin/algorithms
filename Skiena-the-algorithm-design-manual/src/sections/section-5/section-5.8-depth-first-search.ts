import { Graph } from "./Graph";
import { GraphTraveralHooks } from "./GraphTraveralHooks";

let time = 0;
const discovered: boolean[] = [];
const parent: number[] = [];
const processed: boolean[] = [];
const entryTime: number[] = [];
const exitTime: number[] = [];

// TODO Draw the depth-first search tree for this graph.
// TODO Answer: why are we processing edges twice?
export const dfs = (g: Graph, v: number, hooks?: GraphTraveralHooks): void => {
  discovered[v] = true;
  hooks?.processVertexEarly(v);
  entryTime[v] = time;
  time++;

  let p = g.edges[v];
  while (p) {
    const y = p.y;
    if (!discovered[y]) {
      /**
       * An earlier depth search has **not** already found this vertex.
       * We found a new vertex!
       *
       * Set its parent to the vertex that we are currently exploring...
       * ...and then dive into this new path.
       */
      parent[y] = v;
      dfs(g, y, hooks);
      hooks?.processEdge(v, y);
    } else if (!processed[y] || g.directed) {
      /**
       * An earlier depth search has already found this vertex,
       * but has not finished processing this vertex. [Does the mean that this
       * edge must be a back edge that points to an ancestor?]
       */
      hooks?.processEdge(v, y);
    }

    p = p.next;
  }

  /**
   * We have finished going all the way down the path that starts at `v`.
   */
  time++;
  exitTime[v] = time;
  hooks?.processVertexLate(v);
  processed[v] = true;
};
