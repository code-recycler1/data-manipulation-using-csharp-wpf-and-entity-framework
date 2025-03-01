# Entity Framework CUD Exercise

## Exercise 1 – Publishers

### Entity Framework

Continue working on the **EFNavigationPropertiesExercise** exercise.

### UI Design

#### `MainWindow`
- Add a button to open another screen.

![Exercise 1 Image 1](./Screenshots/Exercise_1_Situation_1.png)


#### `Third Window`
- Create a third screen.

![Exercise 1 Image 2](./Screenshots/Exercise_1_Situation_2.png)

### Workflow

- **Loading the Form:**
  - The combobox `cmbPublishers` is populated with all publishers.
  - The publisher's name is displayed.

![Exercise 1 Image 3](./Screenshots/Exercise_1_Situation_3.png)

- **Selecting a Publisher:**
  - When a publisher is selected, all employees are shown in a **datagrid**.
  - Only the following fields are displayed in the datagrid:  
    - **EmployeeID**, **First Name**, **Last Name**, **Hire Date**, **Job**  
  - The datagrid is **not editable**.

![Exercise 1 Image 4](./Screenshots/Exercise_1_Situation_4.png)

- **Adding an Employee:**
  - Clicking **‘Add’** adds the entered details to the database.
  - Changes are only allowed if **all validations** pass.
  - Errors related to **duplicate primary keys (PK)** must be handled!

![Exercise 1 Image 5](./Screenshots/Exercise_1_Situation_5.png)

![Exercise 1 Image 6](./Screenshots/Exercise_1_Situation_6.png)

- **Deleting an Employee:**
  - Clicking **‘Delete’** removes the selected employee from the database.

![Exercise 1 Image 7](./Screenshots/Exercise_1_Situation_7.png)

![Exercise 1 Image 8](./Screenshots/Exercise_1_Situation_8.png)

- **Selecting an Employee:**
  - When selecting an employee, the following fields are filled in:
    - `txtFirstName`, `txtLastName`, `txtEmployeeID`
    - The combobox `cmbJobs` displays the correct job.
  - **`txtEmployeeID` is not editable.**

![Exercise 1 Image 9](./Screenshots/Exercise_1_Situation_9.png)

- **Updating an Employee:**
  - Clicking **‘Update’** updates the modified details (**First Name, Last Name, Job**) in the database.
  - The **datagrid is refreshed**, and all fields are cleared.
  - Changes are only allowed if **all validations** pass.

### ⚠️ **IMPORTANT** ⚠️  
If a **foreign key (FK) of an existing object** is modified and the associated **navigation property** is also populated, **both the FK and the navigation property must be updated**.  
Otherwise, the update **will fail**!

For example:  
- If `Job_id` (**FK**) is updated, the **navigation property `Job`** must also be updated!  
