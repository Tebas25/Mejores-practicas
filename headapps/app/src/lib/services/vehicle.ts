import { memoryDatabase } from "../database/memory";
import { Vehicle } from "../types/vehicle";

export class VehicleService {

  all(): Vehicle[]{
    return memoryDatabase.vehicles;
  }

  add(vehicle: Vehicle): void {
    memoryDatabase.vehicles.push(vehicle);
  }
  
}