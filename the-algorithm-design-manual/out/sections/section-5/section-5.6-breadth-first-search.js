"use strict";
var __importDefault =
  (this && this.__importDefault) ||
  function (mod) {
    return mod && mod.__esModule ? mod : { default: mod };
  };
Object.defineProperty(exports, "__esModule", { value: true });
var getFigure_1 = __importDefault(require("../../figures/getFigure"));
var queue_1 = require("../../queue");
var section_5_2_data_structures_for_graphs_1 = require("./section-5.2-data-structures-for-graphs");
var discovered = [];
var processed = [];
var parent = [];
exports.initializeSearch = function (graph) {
  for (var i = 1; i <= graph.nvertices; i++) {
    processed[i] = discovered[i] = false;
    parent[i] = -1;
  }
};
exports.bfs = function (g, start, hooks) {
  var q = queue_1.initQueue();
  var v;
  var y;
  queue_1.enqueue(q, start);
  discovered[start] = true;
  while (!queue_1.emptyQueue(q)) {
    v = queue_1.dequeue(q);
    hooks === null || hooks === void 0 ? void 0 : hooks.processVertexEarly(v);
    processed[v] = true;
    var p = g.edges[v];
    while (p) {
      y = p.y;
      if (!processed[y] || g.directed) {
        hooks === null || hooks === void 0 ? void 0 : hooks.processEdge(v, y);
      }
      if (!discovered[y]) {
        queue_1.enqueue(q, y);
        discovered[y] = true;
        parent[y] = v;
      }
      p = p.next;
    }
    hooks === null || hooks === void 0 ? void 0 : hooks.processVertexLate(v);
  }
};
var graph = section_5_2_data_structures_for_graphs_1.readGraph(
  getFigure_1.default(5.4)
);
exports.initializeSearch(graph);
exports.bfs(graph, 1);
