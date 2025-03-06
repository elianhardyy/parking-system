# Parking Lot System

## Description

This is a simple console-based Parking Lot System implemented in C#. The system allows users to create a parking lot, park vehicles, remove vehicles, and retrieve various details about parked vehicles based on registration numbers, colors, and vehicle types.

## Features

- Create a parking lot with a specified number of slots.
- Park a vehicle (with registration number, color, and type).
- Remove a vehicle from a specified slot.
- Display the current status of the parking lot.
- Find the count of vehicles of a specific type.
- Retrieve registration numbers of vehicles with odd/even registration plates.
- Retrieve registration numbers of vehicles with a specific color.
- Retrieve slot numbers for vehicles of a specific color.
- Retrieve the slot number for a specific registration number.

## Usage

Once the application is running, use the following commands:

### Create Parking Lot

```sh
create_parking_lot <size>
```

Example:

```sh
create_parking_lot 6
```

### Park a Vehicle

```sh
park <registration_no> <color> <type>
```

Example:

```sh
park ABC-1234 White Car
```

### Remove a Vehicle from a Slot

```sh
leave <slot_number>
```

Example:

```sh
leave 2
```

### Display Parking Lot Status

```sh
status
```

### Count of Vehicles of a Specific Type

```sh
type_of_vehicles <type>
```

Example:

```sh
type_of_vehicles Car
```

### Get Registration Numbers for Vehicles with Odd Plate Numbers

```sh
registration_numbers_for_vehicles_with_odd_plate
```

### Get Registration Numbers for Vehicles with Even Plate Numbers

```sh
registration_numbers_for_vehicles_with_even_plate
```

### Get Registration Numbers for Vehicles of a Specific Color

```sh
registration_numbers_for_vehicles_with_colour <color>
```

Example:

```sh
registration_numbers_for_vehicles_with_colour White
```

### Get Slot Numbers for Vehicles of a Specific Color

```sh
slot_numbers_for_vehicles_with_colour <color>
```

Example:

```sh
slot_numbers_for_vehicles_with_colour White
```

### Get Slot Number for a Specific Registration Number

```sh
slot_number_for_registration_number <registration_no>
```

Example:

```sh
slot_number_for_registration_number ABC-1234
```

### Exit the Program

```sh
exit
```
