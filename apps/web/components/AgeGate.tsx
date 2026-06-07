"use client";

import { useEffect, useState } from "react";

const STORAGE_KEY = "wine-spirits-of-stow-age-confirmed";

export function AgeGate() {
  const [visible, setVisible] = useState(false);

  useEffect(() => {
    setVisible(window.localStorage.getItem(STORAGE_KEY) !== "true");
  }, []);

  if (!visible) {
    return null;
  }

  function confirmAge() {
    window.localStorage.setItem(STORAGE_KEY, "true");
    setVisible(false);
  }

  return (
    <div className="ageGate" role="dialog" aria-modal="true" aria-labelledby="age-title">
      <div className="ageGatePanel">
        <p className="eyebrow">Age verification</p>
        <h2 id="age-title">Are you 21 or older?</h2>
        <p>
          Please confirm you are of legal drinking age before viewing Wine & Spirits Of Stow.
        </p>
        <div className="ageGateActions">
          <button className="primaryButton" onClick={confirmAge}>
            Yes, enter site
          </button>
          <a className="secondaryButton" href="https://www.responsibility.org/">
            No, leave
          </a>
        </div>
      </div>
    </div>
  );
}
