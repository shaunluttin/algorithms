"use strict";
var __assign =
  (this && this.__assign) ||
  function () {
    __assign =
      Object.assign ||
      function (t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
          s = arguments[i];
          for (const p in s)
            if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
        }
        return t;
      };
    return __assign.apply(this, arguments);
  };
const __importDefault =
  (this && this.__importDefault) ||
  function (mod) {
    return mod && mod.__esModule ? mod : { default: mod };
  };
Object.defineProperty(exports, "__esModule", { value: true });
const fs_1 = __importDefault(require("fs"));
const os_1 = __importDefault(require("os"));
const path_1 = __importDefault(require("path"));
const initializeGraph = function () {
  return {
    edges: [],
    degree: [],
    nvertices: 0,
    nedges: 0,
    directed: false,
  };
};
/**
 * [mutation] Insert an edge that starts at `x` and goes to `y`.
 */
var insertEdge = function (g, _a, directed) {
  const x = _a[0],
    y = _a[1];
  if (directed === void 0) {
    directed = false;
  }
  /**
   * Insert this edge at the head of the linked list of edges that start at `x`.
   */
  g.edges[x] = {
    y: y,
    next: g.edges[x],
  };
  if (!directed) {
    insertEdge(g, [y, x], true);
  } else {
    g.degree[x]++;
  }
};
/**
 * [The] graph format consists of an initial line featuring the number of vertices and
 * edges in the graph, followed by a listing of the edges at one vertex pair per line.
 */
exports.readGraph = function (relativePath) {
  const _a = fs_1.default
      .readFileSync(relativePath, {
        encoding: "utf8",
      })
      .split(os_1.default.EOL)
      .map(function (line) {
        return line.split(" ").map(function (n) {
          return parseInt(n, 10);
        });
      }),
    _b = _a[0],
    nvertices = _b[0],
    nedges = _b[1],
    graphEdgeData = _a.slice(1);
  const g = initializeGraph();
  for (
    let _i = 0, graphEdgeData_1 = graphEdgeData;
    _i < graphEdgeData_1.length;
    _i++
  ) {
    const _c = graphEdgeData_1[_i],
      x = _c[0],
      y = _c[1];
    insertEdge(g, [x, y]);
  }
  return __assign(__assign({}, g), { nvertices: nvertices, nedges: nedges });
};
const printGraph = function (g) {
  let printGraph = "";
  for (let vertex = 1; vertex <= g.nvertices; vertex++) {
    const adjacentEdges = [];
    let nextAdjascentEdge = g.edges[vertex];
    while (nextAdjascentEdge) {
      adjacentEdges.push(nextAdjascentEdge.y);
      nextAdjascentEdge = nextAdjascentEdge.next;
    }
    printGraph +=
      vertex + ": " + adjacentEdges.join(",") + " " + os_1.default.EOL;
  }
  return printGraph;
};
// npm run tsnode 5.2-data-structures-for-graphs.ts
const graph = exports.readGraph(
  path_1.default.join(__dirname, "../figures/figure-5.4.txt")
);
const graphString = printGraph(graph);
console.log("Here is the graph: " + os_1.default.EOL + graphString);
