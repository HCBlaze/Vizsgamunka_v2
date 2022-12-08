<?php

namespace Database\Seeders;

use App\Models\Permissions;
use Illuminate\Database\Seeder;

class PermissionsTableSeeder extends Seeder
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
                'Permission' => "Admin"
            ],
            [
                'id' => 2,
                'Permission' => "Leader"
            ],
            [
                'id' => 3,
                'Permission' => "Operator"
            ]
        ];
        foreach ($data as $item)
        {
            $jogosultsag = Permissions::firstOrNew([
                'id'=>$item['id']
            ]);

            $jogosultsag ->Permission = $item['Permission'];
            $jogosultsag ->save();
        }
    }
}
