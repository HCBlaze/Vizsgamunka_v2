<?php

namespace Database\Seeders;

use App\Models\Product;
use Illuminate\Database\Seeder;

class ProductTableSeeder extends Seeder
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
                'ProductName' => "Coca-Cola 2x 1,75L",
                'SupplierId' => 12,
                'UnitPrice' => 999,
                'Package' => "2 db-os 1,75L",
                'Stock' => 15

            ],
            [
                'id' => 2,
                'ProductName' => "Milka tábla csokoládé (vegyes)",
                'SupplierId' => 16,
                'UnitPrice' => 429,
                'Package' => "100g",
                'Stock' => 4

            ],
            [
                'id' => 3,
                'ProductName' => "Magyar Tej ESL 2,8%",
                'SupplierId' => 19,
                'UnitPrice' => 749,
                'Package' => "L",
                'Stock' => 80

            ],
            [
                'id' => 4,
                'ProductName' => "Coca-Cola 6x 33ml",
                'SupplierId' => 14,
                'UnitPrice' => 1.399,
                'Package' => "6 db-os 0,33ml",
                'Stock' => 8

            ],
        ];
        foreach ($data as $item) {
            $termek = Product::firstOrNew([
                'id' => $item['id']
            ]);

            $termek->ProductName = $item['ProductName'];
            $termek->SupplierId = $item['SupplierId'];
            $termek->UnitPrice = $item['UnitPrice'];
            $termek->Package = $item['Package'];
            $termek->Stock = $item['Stock'];
            $termek->save();
        }
    }
}
