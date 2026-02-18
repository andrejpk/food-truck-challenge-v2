import { describe, it, expect } from "vitest";
import { app } from "../src/app.js";

describe("GET /", () => {
  it("returns hello message", async () => {
    const response = await app.inject({ method: "GET", url: "/" });
    expect(response.statusCode).toBe(200);
    expect(response.json()).toEqual({
      message: "Hello, Food Truck Challenge!",
    });
  });
});
