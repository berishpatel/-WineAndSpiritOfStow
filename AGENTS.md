# AGENTS.md

## Project
Wine & Spirits Of Stow website.

## Goal
Build a polished, mobile-friendly local liquor store website for Wine & Spirits Of Stow that helps customers discover products, see specials, contact the store, and get directions.

V1 is catalog + marketing + admin. The codebase must be Stripe-ready for future pickup-only ordering, but checkout is not part of V1 unless explicitly requested.

## Tech Stack
- Frontend: Next.js, React, TypeScript
- Backend: ASP.NET Core Web API, C#
- Backend architecture: Clean Architecture with Domain, Application, Infrastructure, and API layers
- Database: PostgreSQL preferred; SQL Server acceptable
- Images: Cloudinary preferred; Azure Blob Storage acceptable
- Future payments: Stripe Checkout

## Brand Direction
- Local, friendly, trustworthy, and premium without feeling expensive or stiff.
- Clear first impression: Wine & Spirits Of Stow is a neighborhood destination for wine, spirits, beer, mixers, gifts, and weekly deals.
- Use practical store language. Avoid generic marketing filler.

## Required V1 Website Features
- Age verification gate for visitors 21+.
- Homepage with store name, hours, address, call button, directions button, featured specials, and product categories.
- Product/category sections for wine, whiskey, vodka, tequila, rum, gin, beer, champagne, mixers, and gifts.
- Product detail pages with image, price, size, brand, category, availability, and description.
- Weekly specials or promotions area.
- Staff picks or best sellers area.
- Contact section with phone, address, hours, and map link/embed.
- Newsletter or coupon signup for marketing.
- Admin dashboard for products, categories, specials, staff picks, store settings, and images.
- Mobile-first responsive layout.

## Marketing Priorities
- Optimize copy for local search terms: liquor store in Stow, wine store in Stow, spirits near Stow, whiskey shop near Stow.
- Highlight weekly specials, seasonal bundles, holiday gifting, and party essentials.
- Include calls to action: Call Store, Get Directions, View Specials, Join Mailing List.

## Compliance Notes
- Do not imply alcohol can be sold, shipped, delivered, or reserved online unless the user confirms it is legally supported and desired.
- Use age-gate language such as "Are you 21 or older?".
- Keep legal disclaimers simple and visible where needed.
- Future checkout must include age and compliance checks before payment.

## Design Notes
- Prioritize a real usable site over a landing page.
- Use product/category imagery and store-relevant visuals.
- Keep layout clean, readable, and easy to scan.
- Avoid overly dark, blurry, or generic stock-like presentation when product discovery matters.

## Codex Workflow
Before implementation work, read:
- `docs/v1-architecture.md`
- `docs/v1-roadmap.md`
- `docs/codex-agent-workflow.md`

Use Codex branches named `codex/<task-name>`. Keep edits focused, run available verification, commit, and push.
