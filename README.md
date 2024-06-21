# SlidelyFormApp

SlidelyFormApp is a Windows Forms application developed in Visual Basic(.NET Framework). This application allows users to create, view and delete form submissions. The submissions include details like Name, Email, Phone Number, GitHub Repository Link, and Stopwatch Time.

## Features

- **Create New Submission**: Users can fill in the details and submit a new form.
- **View Submissions**: Users can navigate through the submitted forms using "Previous" and "Next" buttons.
- **Delete Submissions**: Remove any unwanted submissions.
- **Keyboard Shortcuts**: Each button in the form has a keyboard shortcut. 

## Setup and Installation

1. **Clone the Repository**:
   
   ```bash
   git clone https://github.com/devkmaan/SlidelyFormsApp-VB.git
   cd SlidelyFormApp
   ```
3. **Open the Solution**:
   - Open Visual Studio.
   - Go to File -> Open -> Project/Solution.
   - Select SlidelyFormApp.sln from the cloned repository.
4. **Restore NuGet Packages**:
   - Go to Tools -> NuGet Package Manager -> Package Manager Console.
   - Run the following command:

   ```bash
   Update-Package -reinstall
   ```
5. **Build the Solution**:
   -Go to Build -> Build Solution or press Ctrl + Shift + B.


## Running the Application

1. **Start the Backend Server**:
   -Ensure the backend server is running (see backend server setup instructions in the backend's README).
2. **Run the Application**:
   -Press F5 or go to Debug -> Start Debugging to run the application.

## User Interface

**Main Form**

The Main Form is the entry point of the application. It provides buttons to navigate to the Create Submission Form and the View Submissions Form.
![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/a7faffa1-f44f-4c7f-b874-df5f75c4720b)



**Create Submission Form**

This form allows users to create a new submission with the following fields:
![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/010a618b-7491-43b0-a4e3-a8a064cd98be)


![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/dfbdd601-6395-483a-88d6-b9527489a250)


**View Submission Form**

This form allows users to view, navigate, and delete submissions.
![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/15decf92-8a1a-47ee-8495-3315bd38d6e1)

![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/620ba929-16dc-482b-bb3a-826a486f3dd6)


![image](https://github.com/devkmaan/SlidelyFormsApp-VB/assets/140909236/4670f1ee-2f1a-40c5-b743-7a7b3228d07e)

## Repository

**Backend**: `https://github.com/devkmaan/SlidelyTaskBackend`

