"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var finished = false;
var time = 0;
var discovered = [];
var parent = [];
var processed = [];
var entryTime = [];
var exitTime = [];
exports.dfs = function (g, v, hooks) {
  if (finished) return;
  discovered[v] = true;
  time++;
  entryTime[v] = time;
  hooks === null || hooks === void 0 ? void 0 : hooks.processVertexEarly(v);
  var p = g.edges[v];
  while (p) {
    var y = p.y; // upstream
    if (!discovered[y]) {
      /**
       * We found a new vertex!
       * Set its parent to the vertex that we are currently exploring...
       * ...and then dive into this new path.
       */
      parent[y] = v;
      hooks === null || hooks === void 0 ? void 0 : hooks.processEdge(v, y);
      exports.dfs(g, y, hooks);
    } else if (!processed[y] || g.directed) {
      hooks === null || hooks === void 0 ? void 0 : hooks.processEdge(v, y);
      if (finished) return;
      p = p.next;
    }
    /**
     * We have finished going all the way down the path that starts at `v`.
     */
    hooks === null || hooks === void 0 ? void 0 : hooks.processVertexLate(v);
    time++;
    exitTime[v] = time;
    processed[v] = true;
  }
};
