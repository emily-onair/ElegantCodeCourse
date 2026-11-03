# Classes

A **class** is an object. It can hold:
- **fields** - data variables (no logic).
- **properties** - special method that allow controlled access to fields. Can contain logic for validation and computation, but should be reserved for simple outputs. More complicated logic should go into a method.
- **methods** - functions.

Key differences.  
|        | field | property | method |
| :----: | :---: | :------: | :----: |
| purpose | store raw data | Controlled access/compute data | perform actions/behavior |
| logic | none | in get/set | yes |
| invoke | variable | looks like variable | function call () |
| syntax  | `private int age;` | `public int Age { get; set; }` | `public void UpdateAge(int val)` |

