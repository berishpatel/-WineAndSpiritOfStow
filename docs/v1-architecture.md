# Wine & Spirits Of Stow V1 Architecture

## Product Goal
Build V1 as a polished marketing, catalog, and admin website for Wine & Spirits Of Stow. The first release should not process alcohol sales online, but the architecture must be ready for pickup-only ordering and Stripe Checkout later.

## Stack
- Frontend: Next.js, React, TypeScript
- Backend: ASP.NET Core Web API, C#
- Backend architecture: Clean Architecture
- Database: PostgreSQL preferred; SQL Server acceptable
- Image storage: Cloudinary preferred; Azure Blob Storage acceptable
- Future payments: Stripe Checkout and Stripe webhooks
- Frontend hosting: Vercel or Azure Static Web Apps
- Backend hosting: Azure App Service

## System Shape
```text
Next.js frontend
  - Public website
  - Admin dashboard
  - Future cart and checkout UI
        |
        v
ASP.NET Core Web API
  - Public catalog/content endpoints
  - Admin CRUD endpoints
  - Future order/payment endpoints
        |
        v
Database + Image Storage + Email Provider
```

## Backend Clean Architecture
```text
Domain
  Business entities, enums, value objects, domain rules.

Application
  Use cases, DTOs, validators, interfaces, commands, queries.

Infrastructure
  Database, repositories, identity, storage, email, Stripe implementation later.

API
  Controllers/endpoints, auth middleware, request/response mapping, API configuration.
```

## V1 Public Features
- Age verification gate for visitors 21+.
- Home page with store name, hours, address, phone, directions, weekly specials, and featured categories.
- Product catalog with category filtering.
- Product detail pages with image, price, size, brand, category, availability, and description.
- Weekly specials page.
- Staff picks section.
- About page.
- Contact page with phone, address, hours, map link, and contact form.
- Newsletter signup.
- Local SEO metadata and schema.

## V1 Admin Features
- Admin login.
- Manage products.
- Manage categories.
- Manage weekly specials.
- Manage staff picks.
- Manage store settings, hours, and announcements.
- Upload product images.

## Future Ecommerce Modules
Keep these out of V1 implementation unless explicitly requested:
- Cart
- Pickup-only orders
- Stripe Checkout
- Stripe webhook handling
- Tax calculation
- Order management
- Email receipts
- Compliance checks before checkout

## Core Database Entities
```text
Category
- Id
- Name
- Slug
- DisplayOrder
- IsActive

Product
- Id
- Name
- Slug
- Brand
- Description
- Price
- Size
- ABV
- ImageUrl
- IsAvailable
- IsFeatured
- IsStaffPick
- CategoryId
- CreatedAt
- UpdatedAt

Special
- Id
- Title
- Description
- ProductId nullable
- DiscountText
- StartDate
- EndDate
- IsActive

StoreSetting
- Id
- StoreName
- Phone
- Email
- AddressLine1
- AddressLine2
- City
- State
- PostalCode
- GoogleMapsUrl
- HoursJson
- AnnouncementText

ContactMessage
- Id
- Name
- Email
- Phone
- Message
- Status
- CreatedAt

NewsletterSubscriber
- Id
- Email
- IsActive
- CreatedAt

AdminUser
- Id
- Email
- PasswordHash
- Role
- IsActive
- CreatedAt
```

## API Endpoints
Public:
```text
GET /api/products
GET /api/products/{slug}
GET /api/categories
GET /api/categories/{slug}/products
GET /api/specials
GET /api/staff-picks
GET /api/store-settings
POST /api/contact
POST /api/newsletter/subscribe
```

Admin:
```text
POST /api/auth/login
POST /api/auth/logout
GET /api/admin/products
POST /api/admin/products
PUT /api/admin/products/{id}
DELETE /api/admin/products/{id}
GET /api/admin/categories
POST /api/admin/categories
PUT /api/admin/categories/{id}
DELETE /api/admin/categories/{id}
GET /api/admin/specials
POST /api/admin/specials
PUT /api/admin/specials/{id}
DELETE /api/admin/specials/{id}
PUT /api/admin/store-settings
POST /api/admin/images/upload
```

Future ecommerce:
```text
POST /api/cart
GET /api/cart/{id}
POST /api/checkout/create-session
POST /api/stripe/webhook
GET /api/admin/orders
PUT /api/admin/orders/{id}/status
```

## Stripe-Ready Rule
The Application layer should depend on interfaces such as `IPaymentProvider`, `IOrderService`, and `ITaxCalculator`. Stripe-specific code belongs only in Infrastructure.

## Compliance Rule
V1 must not imply alcohol can be purchased, shipped, delivered, or reserved online unless the business confirms legal and operational support. Use age gate language and responsible drinking language.
