"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var section_5_2_data_structures_for_graphs_1 = require("./section-5.2-data-structures-for-graphs");
var todo_1 = require("./todo");
var discovered = [];
var processed = [];
var parent = [];
var initializeSearch = function (graph) {
  for (var i = 1; i <= graph.nvertices; i++) {
    processed[i] = discovered[i] = false;
    parent[i] = -1;
  }
};
var bfs = function (g, start) {
  var q;
  var v;
  var y;
  todo_1.initQueue(q);
  todo_1.enqueue(q, start);
  discovered[start] = true;
  while (!todo_1.emptyQueue(q)) {
    v = todo_1.dequeue(q);
    todo_1.processVertexEarly(v);
    processed[v] = true;
    var p = g.edges[v];
    while (p) {
      y = p.y;
      if (!processed[y] || g.directed) {
        todo_1.processEdge(v, y);
      }
      if (!discovered[y]) {
        todo_1.enqueue(q, y);
        discovered[y] = true;
        parent[y] = v;
      }
      p = p.next;
    }
    todo_1.processVertexLate(v);
  }
};
var graph = section_5_2_data_structures_for_graphs_1.readGraph(
  "../figures/figure-5.4.txt"
);
initializeSearch(graph);
bfs(graph, 1);
