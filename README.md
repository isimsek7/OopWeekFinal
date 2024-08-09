README
Overview

This C# program demonstrates basic object-oriented programming principles by simulating a system for managing and displaying information about devices, specifically phones and computers.

Components

DefaultMachine: An abstract base class representing a generic machine. It includes properties for serial number, name, description, and operating system. It also has a constructor that prints the production date and a virtual method Ozet() for displaying details, which is intended to be overridden by derived classes.
Telefon: A derived class from DefaultMachine that represents a phone. It includes a boolean property to indicate if the phone has a license and overrides the Ozet() method to display specific details about the phone, including license status.
Bilgisayar: A derived class from DefaultMachine that represents a computer. It includes properties for USB port count and Bluetooth availability. It overrides the Ozet() method to display details about the computer, including the number of USB ports and Bluetooth status.
Usage

Device Selection: The program prompts the user to select between adding a phone or a computer.
Input Collection: Based on the user’s choice, the program collects relevant details for the selected device.
For phones: Serial number, name, operating system, license status, and description.
For computers: Serial number, name, operating system, number of USB ports, Bluetooth status, and description.
Output: After collecting the details, the program displays a summary of the device’s information.
Repeat Option: The user is prompted to decide whether to add another device. If the user opts not to continue, the program exits.
