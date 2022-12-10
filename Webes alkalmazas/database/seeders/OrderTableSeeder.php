<?php

namespace Database\Seeders;

use App\Models\Order;
use Illuminate\Database\Seeder;

class OrderTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $data = [
            [
                'id' => 1,
                'OrderDate' => "2022-11-4 12:00:00",
                'OrderNumber' => "LS-123456",
                'CustomerId' => 22,
                'TotalAmount' => 23,000

            ],
            [
                'id' => 2,
                'OrderDate' => "2022-11-6 11:10:00",
                'OrderNumber' => "LS-536789",
                'CustomerId' => 23,
                'TotalAmount' => 11,000

            ],
            [
                'id' => 3,
                'OrderDate' => "2022-11-4 13:44:00",
                'OrderNumber' => "LS-678987",
                'CustomerId' =>  29,
                'TotalAmount' => 17,000

            ],
            [
                'id' => 4,
                'OrderDate' => "2022-11-4 12:20:00",
                'OrderNumber' => "LS-153124",
                'CustomerId' => 21,
                'TotalAmount' => 29,000

            ],
        ];
        foreach ($data as $item) {
            $rendeles = Order::firstOrNew([
                'id' => $item['id']
            ]);

            $rendeles->OrderDate = $item['OrderDate'];
            $rendeles->OrderNumber = $item['OrderNumber'];
            $rendeles->CustomerId = $item['CustomerId'];
            $rendeles->TotalAmount = $item['TotalAmount'];
            $rendeles->save();
        }
    }
}
