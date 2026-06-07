import type { Metadata } from "next";
import { AgeGate } from "../components/AgeGate";
import "./globals.css";

export const metadata: Metadata = {
  title: "Wine & Spirits Of Stow | Liquor Store in Stow",
  description:
    "Wine & Spirits Of Stow is a local destination for wine, spirits, beer, mixers, staff picks, weekly specials, and party essentials.",
  keywords: [
    "Wine & Spirits Of Stow",
    "liquor store in Stow",
    "wine store in Stow",
    "spirits near Stow",
    "whiskey shop near Stow"
  ]
};

export default function RootLayout({ children }: { children: React.ReactNode }) {
  return (
    <html lang="en">
      <body>
        <AgeGate />
        {children}
      </body>
    </html>
  );
}
