export default (msg: string, payload: Record<string, unknown>): void =>
  console.log(`${msg}:`, JSON.stringify(payload, null, 2));
