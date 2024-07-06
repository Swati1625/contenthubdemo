Create Entities
To create the entity, use the EntityFactory to instantiate an Entity, set its properties using SetPropertyValue, and then call the SaveAsync method to save the changes.



Read Entities
In the GetAsync method, the entity ID needs to be passed. GetAsync method will return IEntity.



Update Entities
To update the entity, begin by invoking the GetAsync method with the entity ID to retrieve an IEntity. After obtaining the IEntity, modify its properties using SetPropertyValue. Finally, call the SaveAsync method to persist the changes.



Delete Entities
To delete the entity, call the DeleteAsync method with the entity ID.