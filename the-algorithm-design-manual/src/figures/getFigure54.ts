import fs from "fs";
import path from "path";

export default (): string =>
  fs.readFileSync(path.join(__dirname, "figure-5.4.txt"), { encoding: "utf8" });
