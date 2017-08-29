# constructAFarm
A reference document for using encapsulation across classes, with constructors, this, and backing fields. Also note casing (camelCase vs PascalCase)

/* These are my own ref notes */

Encapsulation keeps your data private!

> using camelCase for PRIVATE fields
> using PascalCase for PUBLIC fields
> Properties and Methods in PascalCase (regardless of access)
> Parameters to methods in camelCase
> Some methods, esp constructors, will have parameters w/the same names as fields. Here, the param masks the field; statements in the method end up refering to the param not the field (!) avoid by using 'this'. 
