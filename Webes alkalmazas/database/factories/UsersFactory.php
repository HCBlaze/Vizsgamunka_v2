<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

class UsersFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'Username'=>$this->faker->userName(),
            'Password'=>$this->faker->password(),
            'First_name'=>$this->faker->firstName(),
            'Last_name'=>$this->faker->lastName(),
            'E-mail'=>$this->faker->email(),
            'Birth'=>$this->faker->dateTime(),
            'Permission'=>$this->faker->randomElement([1,2,3]),
            'Deleted'=>$this->faker->boolean()

        ];
    }
}
