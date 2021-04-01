
# Kids-U Database

## Description:

The goal of this project is the refresh the Kids-U staff website and database system with new features.

## Design:

### Back Buttons
The back buttons dynamically link to the page that the user just came from instead of always returning to the same page. 

For example, a User on the Student Enrollment page clicks link to view a student’s Report Cards. The current url is passed to the View Report Card page via the returnUrl parameter. If the user then goes to the Edit page of a specific Report Card, the returnUrl is passed. When editing is finished, the same returnUrl is passed back to the View page. Now the user can hit back and it will return to the Student Enrollment page with all the search settings preserved.


#### Made by [UT Dallas EPICS](https://sites.utdallas.edu/epics-kids-u/) for [Kids-U](http://kids-u.org)

