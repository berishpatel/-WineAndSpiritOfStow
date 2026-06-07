import {
  ArrowRight,
  Clock,
  MapPin,
  Phone,
  Search,
  Sparkles,
  Star,
  Wine
} from "lucide-react";
import Image from "next/image";
import { categories, specials, staffPicks, store } from "../lib/store-data";

export default function Home() {
  return (
    <main>
      <header className="siteHeader">
        <a className="brand" href="#top" aria-label="Wine & Spirits Of Stow home">
          <Wine aria-hidden="true" />
          <span>{store.name}</span>
        </a>
        <nav aria-label="Main navigation">
          <a href="#categories">Categories</a>
          <a href="#specials">Specials</a>
          <a href="#picks">Staff Picks</a>
          <a href="#contact">Contact</a>
        </nav>
      </header>

      <section className="hero" id="top">
        <div className="heroMedia" aria-hidden="true" />
        <div className="heroContent">
          <p className="eyebrow">Liquor store in Stow</p>
          <h1>Wine & Spirits Of Stow</h1>
          <p>
            Your neighborhood stop for wine, spirits, beer, mixers, gift bottles,
            party essentials, and weekly specials.
          </p>
          <div className="heroActions">
            <a className="primaryButton" href="#specials">
              View Specials
              <ArrowRight aria-hidden="true" />
            </a>
            <a className="secondaryButton" href={`tel:${store.phone}`}>
              <Phone aria-hidden="true" />
              Call Store
            </a>
            <a className="secondaryButton" href={store.mapUrl}>
              <MapPin aria-hidden="true" />
              Get Directions
            </a>
          </div>
        </div>
        <aside className="storePanel" aria-label="Store details">
          <div>
            <Clock aria-hidden="true" />
            <div>
              <span>Open today</span>
              <strong>Check current store hours</strong>
            </div>
          </div>
          <div>
            <MapPin aria-hidden="true" />
            <div>
              <span>Serving Stow</span>
              <strong>Wine, spirits, beer, and mixers</strong>
            </div>
          </div>
        </aside>
      </section>

      <section className="section introBand">
        <div>
          <p className="eyebrow">Shop by need</p>
          <h2>Find the right bottle faster.</h2>
        </div>
        <div className="searchBox" aria-label="Product search preview">
          <Search aria-hidden="true" />
          <span>Search by category, brand, price, or occasion</span>
        </div>
      </section>

      <section className="section" id="categories">
        <div className="sectionHeader">
          <div>
            <p className="eyebrow">Product categories</p>
            <h2>Wine, spirits, beer, and more.</h2>
          </div>
          <a className="textLink" href="#contact">
            Ask for a recommendation
            <ArrowRight aria-hidden="true" />
          </a>
        </div>
        <div className="categoryGrid">
          {categories.map((category) => (
            <article className="categoryCard" key={category.name}>
              <Image
                src={category.image}
                alt={`${category.name} selection`}
                width={900}
                height={620}
              />
              <div>
                <h3>{category.name}</h3>
                <p>{category.count}</p>
              </div>
            </article>
          ))}
        </div>
      </section>

      <section className="section specialsBand" id="specials">
        <div className="sectionHeader">
          <div>
            <p className="eyebrow">Weekly specials</p>
            <h2>Fresh reasons to stop in.</h2>
          </div>
          <a className="secondaryButton" href={`tel:${store.phone}`}>
            <Phone aria-hidden="true" />
            Call for today&apos;s deals
          </a>
        </div>
        <div className="specialsGrid">
          {specials.map((special) => (
            <article className="specialCard" key={special.title}>
              <span>{special.label}</span>
              <h3>{special.title}</h3>
              <p>{special.text}</p>
            </article>
          ))}
        </div>
      </section>

      <section className="section splitSection" id="picks">
        <div>
          <p className="eyebrow">Staff picks</p>
          <h2>Helpful picks for dinners, gifts, and weekends.</h2>
          <p>
            Stop in for local recommendations across wine, whiskey, tequila,
            vodka, craft beer, champagne, and cocktail essentials.
          </p>
        </div>
        <div className="pickList">
          {staffPicks.map((pick) => (
            <article className="pickItem" key={pick.name}>
              <div>
                <span>{pick.type}</span>
                <h3>{pick.name}</h3>
                <p>{pick.note}</p>
              </div>
              <strong>{pick.price}</strong>
            </article>
          ))}
        </div>
      </section>

      <section className="section localSeo">
        <div className="seoImage" aria-hidden="true" />
        <div>
          <p className="eyebrow">Neighborhood service</p>
          <h2>A local wine store and spirits shop for Stow.</h2>
          <p>
            Wine & Spirits Of Stow is built for quick stops, thoughtful gifts,
            party planning, and everyday favorites. Browse the shelves, ask for
            a recommendation, or check the latest seasonal specials.
          </p>
          <div className="featureRow">
            <span><Star aria-hidden="true" /> Staff recommendations</span>
            <span><Sparkles aria-hidden="true" /> Seasonal bundles</span>
            <span><MapPin aria-hidden="true" /> Easy local pickup stop</span>
          </div>
        </div>
      </section>

      <section className="section contactBand" id="contact">
        <div>
          <p className="eyebrow">Contact</p>
          <h2>Visit Wine & Spirits Of Stow.</h2>
          <p>
            Call ahead for current availability, weekly specials, hours, and
            help choosing the right bottle.
          </p>
          <div className="contactActions">
            <a className="primaryButton" href={`tel:${store.phone}`}>
              <Phone aria-hidden="true" />
              {store.phone}
            </a>
            <a className="secondaryButton" href={store.mapUrl}>
              <MapPin aria-hidden="true" />
              Directions
            </a>
          </div>
        </div>
        <div className="hoursPanel">
          <h3>Store hours</h3>
          {store.hours.map(([days, hours]) => (
            <div key={days}>
              <span>{days}</span>
              <strong>{hours}</strong>
            </div>
          ))}
          <p>Please confirm holiday hours by phone.</p>
        </div>
      </section>

      <section className="newsletter">
        <div>
          <p className="eyebrow">Local deals</p>
          <h2>Get specials and new arrival updates.</h2>
        </div>
        <form>
          <label className="srOnly" htmlFor="email">Email address</label>
          <input id="email" type="email" placeholder="Email address" />
          <button className="primaryButton" type="submit">
            Join List
          </button>
        </form>
      </section>

      <footer>
        <strong>{store.name}</strong>
        <span>Responsible drinking encouraged. Please enjoy safely.</span>
      </footer>
    </main>
  );
}
