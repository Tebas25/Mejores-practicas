"use server";

import { VehicleService } from "@/lib/services/vehicle";
import { Vehicle } from "@/lib/types/vehicle";
import { v4 as uuid } from "uuid";

export async function addEscape() {
 const service = new VehicleService();
 service.add({
   id: uuid(),
   model: "Escape",
   brand: "Ford",
   year: 2023
  } as Vehicle);
}

