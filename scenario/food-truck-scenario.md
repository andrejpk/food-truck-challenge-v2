# Senior Engineer – San Francisco Food Truck Challenge (20 mins)

## 🧩 Problem: Top Food Trucks in San Francisco

The City of San Francisco maintains a list of registered food trucks operating across neighborhoods.

Each truck has:

- `id` (string)
- `name` (string)
- `cuisine` (string)
- `rating` (float, 1.0–5.0)
- `distance` (float, miles from the user)

You are building a feature that returns the top K food trucks for a given cuisine near a user.

## Requirements

Return the IDs of the top `k` trucks matching the specified cuisine.

**Ranking Priority:**

1. Higher rating first
2. If ratings tie → closer distance first
3. If still tied → lexicographically smaller ID first

## Example

**Input:**

- `cuisine = "Mexican"`
- `k = 2`

**Sample trucks:**

```
("T1", "El Taco Loco",     "Mexican", 4.7, 1.2)
("T2", "Mission Burritos", "Mexican", 4.7, 0.8)
("T3", "Curry Up Now",     "Indian",  4.9, 0.5)
("T4", "SF Street Tacos",  "Mexican", 4.6, 0.7)
```

**Output:**

```
["T2", "T1"]
```

**Explanation:**

- T1 and T2 have same rating (4.7)
- T2 is closer → ranked higher
