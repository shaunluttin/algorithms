"use strict";
var __importDefault =
  (this && this.__importDefault) ||
  function (mod) {
    return mod && mod.__esModule ? mod : { default: mod };
  };
Object.defineProperty(exports, "__esModule", { value: true });
var fs_1 = __importDefault(require("fs"));
var path_1 = __importDefault(require("path"));
exports.default = function (figure) {
  return fs_1.default.readFileSync(
    path_1.default.join(__dirname, "figure-" + figure + ".txt"),
    {
      encoding: "utf8",
    }
  );
};
