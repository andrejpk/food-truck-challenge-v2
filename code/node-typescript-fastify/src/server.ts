import { app } from "./app.js";

const start = async () => {
  const port = Number(process.env.PORT) || 3000;
  await app.listen({ port });
  console.log(`Server listening on http://localhost:${port}`);
};

start();
