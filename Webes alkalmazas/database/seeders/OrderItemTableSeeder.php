<?php

namespace Database\Seeders;

use App\Models\OrderItem;
use Illuminate\Database\Seeder;

class OrderItemTableSeeder extends Seeder
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
              'OrderId' => 3,
              'ProductId' => 2,
                'UnitPrice' => 429,
                'Quantity' => 6

            ],
            [
                'id' => 2,
                'OrderId' => 3,
                'ProductId' => 1,
                'UnitPrice' => 999,
                'Quantity' => 2

            ],
            [
                'id' => 3,
                'OrderId' => 3,
                'ProductId' => 3,
                'UnitPrice' => 749,
                'Quantity' => 6

            ],
            [
                'id' => 4,
                'OrderId' => 4,
                'ProductId' => 4,
                'UnitPrice' => 1.399,
                'Quantity' => 20

            ],
        ];
        foreach ($data as $item){
            $rendelt = OrderItem::firstOrNew([
               'id' => $item['id']
            ]);

            $rendelt->OrderId = $item['OrderId'];
            $rendelt->ProductId = $item['ProductId'];
            $rendelt->UnitPrice = $item['UnitPrice'];
            $rendelt->Quantity = $item['Quantity'];

            $rendelt->save();
        }
    }
}
