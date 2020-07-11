export default function* (
  start: number,
  end: number
): Generator<number, void, unknown> {
  for (let i = start; i <= end; i++) {
    yield i;
  }
}
