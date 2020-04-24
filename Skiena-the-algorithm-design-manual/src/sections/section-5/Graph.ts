import { EdgeNode } from './EdgeNode';
export type Graph = {
  edges: EdgeNode[];
  degree: number[];
  nvertices: number;
  nedges: number;
  directed: boolean;
};
