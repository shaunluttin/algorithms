import fs from "fs";
import path from "path";

export default (figure: number): string =>
  fs.readFileSync(path.join(__dirname, `figure-${figure}.txt`), {
    encoding: "utf8",
  });
