"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.initQueue = function () {
  return [];
};
exports.enqueue = function (q, item) {
  return q.push(item);
};
exports.dequeue = function (q) {
  return q.splice(0, 1)[0];
};
exports.emptyQueue = function (q) {
  return (q === null || q === void 0 ? void 0 : q.length) === 0;
};
