export type Queue<T> = T[];

export const initQueue = <T>(): Queue<T> => [];

export const enqueue = <T>(q: Queue<T>, item: T): number => q.push(item);

export const dequeue = <T>(q: Queue<T>): T => q.splice(0, 1)[0];

export const emptyQueue = <T>(q: Queue<T>): boolean => {
  return q?.length === 0;
};
