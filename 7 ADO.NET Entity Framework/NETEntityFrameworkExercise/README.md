# ADO.NET Entity Framework Exercise

## Exercise 1 – Publishers

### Entity Framework

Create the Entity Framework model using the `Publishers` tables.  
Ensure that the entity names and navigation properties are correctly named.

### UI Design

#### `MainWindow`

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)

### Workflow

- **Searching for Stores:**  
  - When clicking **‘Search Stores’**, the data grid is populated with stores that match the criteria.  
  - If no criteria are entered, all stores are displayed.  
  - Stores are sorted by `StoreName`.

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

- **Loading the Form:**  
  - The combo box `cmbJobs` is populated with `Job` objects.  
  - The job description is displayed.  
  - Jobs are sorted by description.

![Exercise 1 Image 4](./Screenshots/Exercise_1_Situation_4.png)

- **Searching for Employees:**  
  - When clicking **‘Search Employees’**, employees practicing the selected job are retrieved.

![Exercise 1 Image 5](./Screenshots/Exercise_1_Situation_5.png)