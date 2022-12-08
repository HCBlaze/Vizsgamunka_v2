<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

class CustomerFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'First_name'=>$this->faker->firstName(),
            'Last_name'=>$this->faker->lastName(),
            'Phone'=>$this->faker->phoneNumber(),
        ];
    }
}
