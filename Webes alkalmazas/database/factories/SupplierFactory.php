<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

class SupplierFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'CompanyName'=>$this->faker->company(),
            'ContactName'=>$this->faker->firstName(),
            'City'=>$this->faker->city(),
            'Phone'=>$this->faker->phoneNumber()

        ];
    }
}
