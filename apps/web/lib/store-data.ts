export const store = {
  name: "Wine & Spirits Of Stow",
  tagline: "Local wine, spirits, beer, mixers, and weekly finds in Stow.",
  phone: "(978) 555-0147",
  email: "hello@wineandspiritsofstow.com",
  address: "Stow, MA",
  hours: [
    ["Mon-Thu", "10:00 AM - 9:00 PM"],
    ["Fri-Sat", "10:00 AM - 10:00 PM"],
    ["Sunday", "12:00 PM - 6:00 PM"]
  ],
  mapUrl: "https://www.google.com/maps/search/?api=1&query=Wine+%26+Spirits+Of+Stow"
};

export const categories = [
  {
    name: "Wine",
    count: "Reds, whites, rose, and sparkling",
    image: "https://images.unsplash.com/photo-1510812431401-41d2bd2722f3?auto=format&fit=crop&w=900&q=80"
  },
  {
    name: "Whiskey",
    count: "Bourbon, rye, scotch, and single malt",
    image: "https://images.unsplash.com/photo-1527281400683-1aae777175f8?auto=format&fit=crop&w=900&q=80"
  },
  {
    name: "Spirits",
    count: "Vodka, tequila, rum, gin, and liqueurs",
    image: "https://images.unsplash.com/photo-1569529465841-dfecdab7503b?auto=format&fit=crop&w=900&q=80"
  },
  {
    name: "Beer & Seltzer",
    count: "Craft, imports, domestic favorites",
    image: "https://images.unsplash.com/photo-1608270586620-248524c67de9?auto=format&fit=crop&w=900&q=80"
  },
  {
    name: "Champagne",
    count: "Celebration bottles and gifts",
    image: "https://images.unsplash.com/photo-1547595628-c61a29f496f0?auto=format&fit=crop&w=900&q=80"
  },
  {
    name: "Mixers",
    count: "Tonic, soda, bitters, and cocktail essentials",
    image: "https://images.unsplash.com/photo-1551024709-8f23befc6f87?auto=format&fit=crop&w=900&q=80"
  }
];

export const specials = [
  {
    label: "Weekend Pick",
    title: "Cabernet under $20",
    text: "A rotating shelf of bold reds for dinner, hosting, and easy gifting."
  },
  {
    label: "Party Ready",
    title: "Mix-and-match essentials",
    text: "Build a simple bar cart with vodka, tequila, rum, mixers, and garnishes."
  },
  {
    label: "Local Favorite",
    title: "Craft beer refresh",
    text: "Fresh seasonal packs and familiar favorites for the weekend cooler."
  }
];

export const staffPicks = [
  {
    name: "Old Vine Zinfandel",
    type: "Wine",
    note: "Rich fruit, smooth finish, easy with grilled food.",
    price: "$18.99"
  },
  {
    name: "Small Batch Bourbon",
    type: "Whiskey",
    note: "A warm, reliable pour for sipping or classic cocktails.",
    price: "$34.99"
  },
  {
    name: "Blanco Tequila",
    type: "Tequila",
    note: "Clean citrus profile for margaritas and highballs.",
    price: "$29.99"
  }
];
