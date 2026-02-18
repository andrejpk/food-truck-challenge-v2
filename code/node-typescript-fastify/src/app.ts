import Fastify from "fastify";

export const app = Fastify();

app.get("/", async () => {
  return { message: "Hello, Food Truck Challenge!" };
});
