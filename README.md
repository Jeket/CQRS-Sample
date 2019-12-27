# CQRS

## What is CQRS?
````
CQRS => Command and Query responsiblity segregation.
Where segregation means separation.
````

## CQRS-Command pattern
````
Command pattern is used to manipulate data (insert / update / delete).
Command do not return any value.
````

## CQRS-Query pattern
````
Query pattern is used to retrive data (select).
Query return value or values.

Note: This Query processor are not required actually, in CQRS query needs to be fetched using THIN data layer,
so you can fetch data directly from repository instead of query processor.
````
