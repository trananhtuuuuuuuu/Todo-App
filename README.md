# Todo-App
This is a project I create to learn .NET backend development 


# Explain about Architect of project
- A Solution (.sln) = IntelliJ's Project
- A project (.csproj) = IntelliJ's module

tiger_tribe/          ← Solution (like main project)
├── interview/        ← Project (your actual Web API)
│    ├── Dependencies/
│    ├── Properties/
│    ├── appsettings.json
│    ├── appsettings.Development.json
│    ├── Program.cs
│    ├── interview.http
│    ├── bin/
│    ├── obj/
│    └── config/      ← (your own folder)
├── .git/
├── .idea/            ← Rider config
└── README.md


tiger_tribe/
├── interview/           (your API)
├── interview.Tests/     (unit tests)
├── interview.Data/      (database layer)



## Entity
- Expense: id, category, date, payMethod, note, address, amount, userId (FK).
- User: id, name, phoneNumber, gender, username, email, password, DOB, address, createAt, roleId (FK).
- Role: id, name, description, createAt.
- Permission: id, pathEndpoint, method, description, name, createdAt.
- PermissionRole: id, roleId (FK), permissionId (FK), createdAt.

## Relational database
- A User has many ExpenseTable; Many ExpenseTable belong to a User => (OneToMany relation)
- A Role has many User; Many User belong to a Role => (OneToMany relation)
- A Role has much Permission; A Permission has many Role (ManyToMany relation)

## Features
- Authenticate (login OAuth2 resource server model)
- Authorize (access APIs) with Jwt
- Refresh page with Token authorize and enter with cookies
- Validate data (at controller layer)
- Process Exception ()
- Filter
- Pagination
- Search

## Apis document
- Use Swagger for APIs document
- All Apis need Pagination, sorted, search

### User
- Get All user: method (Get), role (Admin)
- Get User By Role: method (Get), role (Admin)
- Get User By Permission: method (Get), role (Admin)
- Get User By id: method (Get), role (Admin, Manager),
- Update A User if anyone who have role filed: method (Put), role (Admin)
- Update A User if anyone who hasn't role field: method (Put), role (Admin, Manager)
- Delete A user: method (Delete), role (Admin)
- Create A User: method (Post), role (Admin)
- Get User By Role: method (Get), role (Admin)
- Get User who has max amount follow months
- Get User who has max amount follow years
- Get User who has min amount follow months
- Get User who has min amount follow years

### Role
- Get All Role: method (Get), role (Admin)
- Get Role By Id: method (Get), role (Admin)
- Update A Role: method (Put), role (Admin)
- Delete A Role: method (Delete), role (Admin)
- Create A role: method (Post), role (Admin)

### Permission
- Get All Permission: method (Get), role (Admin, Manager)
- Update A Permission: method (Put), role (Admin)
- Create A Permission: method (Post), role (Admin)
- Delete A Permission: method (Delete), role (Admin)
- Get Permission By Role: method (Get), Role (Admin, Manager)

### Expense
- Create A Expense: method (Post)
- Delete A Expense: method (Delete), role (User is owner who created this expense)
- User update A Expense: method (Put), role (User is owner who created this expense)
- Get Categories which were the most purchased by users
- Get Users who were the most purchased about the number of categories
- Get Users who were the most purchased about the number of amount
- Get Address which have the most purchaser

### Technical
- Jwt
- Spring JPA
- Spring boot
- Spring security
- Docker packaging
- CI/CD
- Docker compose
- Postgresql


