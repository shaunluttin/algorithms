export type GraphTraveralHooks = {
  processVertexEarly: (v: number) => void;
  processVertexLate: (v: number) => void;
  processEdge: (x: number, y: number) => void;
};
