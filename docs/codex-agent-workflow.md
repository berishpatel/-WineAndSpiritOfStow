# Codex Agent Workflow

## Purpose
This workflow tells Codex agents how to build Wine & Spirits Of Stow without losing architectural discipline. The project is V1 catalog + marketing + admin first, Stripe-ready later.

## Default Branching
- Main production branch: `main`
- Codex work branches: `codex/<task-name>`
- Current starter branch: `codex/initial-setup`

## Agent Roles

### Product Architect Agent
Owns architecture decisions, roadmap, API contracts, data models, and compliance boundaries.

Responsibilities:
- Keep V1 focused on catalog, marketing, and admin.
- Defer checkout until legal/payment rules are confirmed.
- Update `docs/v1-architecture.md` when architectural decisions change.

### Frontend Agent
Owns the Next.js public website and admin UI.

Responsibilities:
- Build mobile-first pages.
- Keep local SEO strong.
- Use API data instead of hardcoding products once backend endpoints exist.
- Make the first screen immediately useful, not a generic landing page.

Expected frontend areas:
- Age gate
- Homepage
- Catalog
- Product details
- Specials
- Staff picks
- Contact
- Admin dashboard

### Backend Agent
Owns ASP.NET Core API and Clean Architecture projects.

Responsibilities:
- Keep domain rules in Domain/Application.
- Keep EF Core, storage, email, and Stripe details in Infrastructure.
- Keep controllers/endpoints thin.
- Add tests for use cases and critical endpoints.

### Admin Agent
Owns store operator workflows.

Responsibilities:
- Product CRUD
- Category CRUD
- Specials CRUD
- Staff picks management
- Store settings and announcements
- Image upload UX

### QA Agent
Owns verification.

Responsibilities:
- Run build/test commands before finalizing.
- Check responsive UI.
- Check age gate behavior.
- Check admin auth protection.
- Check contact/newsletter validation.
- Confirm no checkout claims are visible in V1.

### Deployment Agent
Owns deployment setup.

Responsibilities:
- Add environment variable examples.
- Prepare Vercel/Azure deployment notes.
- Add GitHub Actions once tooling exists.
- Keep secrets out of the repo.

## Standard Task Flow
1. Read `AGENTS.md`, `docs/v1-architecture.md`, and this workflow.
2. Check git status before editing.
3. Make focused changes only.
4. Run relevant tests/builds when tooling exists.
5. Update documentation when scope or behavior changes.
6. Commit with a clear message.
7. Push the branch.

## Implementation Order
1. Scaffold frontend and backend projects.
2. Build backend entities and public endpoints.
3. Build frontend public pages with mocked or seeded API data.
4. Build admin auth and CRUD.
5. Add image upload.
6. Add tests and deployment config.

## Guardrails
- Do not add Stripe checkout to V1 unless explicitly requested.
- Do not claim delivery, shipping, online payment, or online reservation unless confirmed.
- Do not store secrets in files.
- Do not mix backend infrastructure concerns into Domain/Application.
- Do not hardcode production store data if it should be editable in admin.
- Do not remove user changes without explicit approval.

## Suggested Prompt for Future Codex Work
```text
You are working in the Wine & Spirits Of Stow repo. Follow AGENTS.md and docs/codex-agent-workflow.md. Build the next V1 feature using Next.js + TypeScript for the frontend and ASP.NET Core Clean Architecture for the backend. Keep V1 to catalog, marketing, and admin. Do not add checkout yet. Make focused changes, run available tests/builds, commit, and push the branch.
```
