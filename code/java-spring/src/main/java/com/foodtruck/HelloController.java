package com.foodtruck;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

    @GetMapping("/")
    public HelloResponse hello() {
        return new HelloResponse("Hello, Food Truck Challenge!");
    }
}
