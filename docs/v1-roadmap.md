# V1 Development Roadmap

## Phase 0: Tooling
Install or verify:
- Node.js LTS
- .NET SDK 8 or 9
- Git
- PostgreSQL or SQL Server
- VS Code extensions for C#, ESLint, Prettier, and TypeScript

## Phase 1: Repository Scaffold
- Create `apps/web` with Next.js, React, and TypeScript.
- Create `src/WineSpirits.sln` with ASP.NET Core Clean Architecture projects.
- Add shared documentation in `docs`.
- Add environment file examples for frontend and backend.

## Phase 2: Backend V1
- Create Domain entities: Product, Category, Special, StoreSetting, ContactMessage, NewsletterSubscriber, AdminUser.
- Create Application DTOs and use cases.
- Create Infrastructure persistence with EF Core.
- Add seed data for categories and store settings.
- Add public API endpoints.
- Add admin auth and CRUD endpoints.

## Phase 3: Frontend V1 Public Site
- Build age gate.
- Build homepage.
- Build product catalog and category pages.
- Build product detail page.
- Build specials and staff picks.
- Build about and contact pages.
- Add newsletter signup.
- Add responsive layout and SEO metadata.

## Phase 4: Admin Dashboard
- Build admin login.
- Build product table and form.
- Build category management.
- Build specials management.
- Build store settings management.
- Build image upload flow.

## Phase 5: Quality and Launch
- Add backend unit tests for use cases.
- Add API integration tests for critical endpoints.
- Add frontend smoke tests for key pages.
- Add accessibility pass.
- Add production environment variables.
- Deploy frontend and backend.

## V1 Definition of Done
- Public site works on desktop and mobile.
- Admin can manage products, categories, specials, staff picks, and store settings.
- Product data comes from API/database.
- Age gate is present.
- Contact and newsletter forms work.
- Local SEO metadata exists.
- No checkout or online alcohol sale promises are visible.
