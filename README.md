# WinForms-GraphicsTool
**Drawing and Manipulating Graphic Shapes Project**

**Description:**
This project is a .NET application dedicated to drawing and manipulating basic graphic shapes, such as lines, circles, rectangles, and squares. Its main purpose is to provide an intuitive and functional interface for users interested in creating and editing graphic shapes in a digital environment.

**Technical Details:**
- It uses the .NET platform for application development.
- The user interface is implemented using Windows Forms (WinForms) technology.
- All graphic objects are uniformly handled through an abstract general class named `Shape`, which defines methods for drawing, resizing, and moving.
- Drawing is performed within a `PictureBox` control, and the Paint event is managed to ensure correct rendering of graphic shapes in various situations (minimizing, maximizing, resizing).
- The project is divided into two main components:
   - **Business Logic (MyPaint.Bussiness):** Here, the hierarchy of objects is defined, including the `Shape` class, `GraphicTool`, and other helper classes.
   - **User Interface (MyPaint.Editor):** This part contains the user interface, providing functionalities for drawing and manipulating graphic shapes.
- It offers the possibility to save and load drawings as bitmap images and in JSON format.

This project serves as an excellent example of object-oriented programming approach in a practical context, providing a solid foundation for the development and further expansion of graphic shape manipulation applications.
