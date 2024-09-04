function clearAll() {
  document.getElementById("verktoy").innerHTML = "";
  document.getElementById("html").innerHTML = "";
  document.getElementById("css").innerHTML = "";
  document.getElementById("javascript").innerHTML = "";
  document.getElementById("game").innerHTML = "";
}

function showVerktoy() {
  clearAll();
  document.getElementById(
    "verktoy"
  ).innerHTML = `<p>De to viktigste Verktoyene vi skal bruke er disse:</p>
          <ul>
            <li>
              Koderedigeringsprogrammet
              <a href="https://code.visualstudio.com/">Visual Studio Code</a>
              <br />Vi skal bruke noen <i>extensions</i>:
              <ul>
                <li>JavaScript-booster</li>
                <li>es6-string-html</li>
                <li>live-server</li>
                <li>live-share</li>
              </ul>
            </li>
            <li>Nettleseren Google Chrome</li>
          </ul>`;
}

function showHtml() {
  clearAll();
  document.getElementById("html").innerHTML = `
          <p>Vi bruker HTML til å definere et dokument</p>
          <ul>
            <li>Tagger for grunnleggense oppsett av en HTML-fil</li>
            <li>Tagger for grunnleggende formatering av tekst</li>
            <li>div</li>
            <li>input type="text"</li>
            <li>button</li>
          </ul>
        `;
}

function showCss() {
  clearAll();
  document.getElementById("css").innerHTML = `<p>
            Vi bruker CSS til å style et dokument, altså farger, fonter,
            utseende og lignende.
          </p>
          <ul>
            <li>background-color</li>
            <li>color</li>
            <li>padding</li>
            <li>margin</li>
            <li>border</li>
            <li>text-align</li>
            <li>font-size</li>
            <li>Flexbox</li>
            <li>Grid</li>
            <li>W3Schools CSS Tutorial</li>
            <li>W3Schools CSS Reference</li>
          </ul>`;
}

function showJavaScript() {
  clearAll();
  debugger;
  document.getElementById("javascript").innerHTML = `<p>
            Det viktigste vi skal lære er programmeringsspråket JavaScript. Vi
            skal lære grunnleggende programmering ved å manipulere HTML- og
            CSS-kode på en nettside ved hjelp av JavaScript.
          </p>
          <ul>
            <li>
              Det finnes en W3Schools JavaScript Tutorial, men her anbefaler vi
              heller å følge kurset vårt på Moodle.
            </li>
            <li>W3Schools JavaScript Reference</li>
          </ul>`;
}

function showGame() {
  clearAll();
  document.getElementById("game").innerHTML = /*html*/ `
          <div id="head">
           <button onclick="head3()">Prev</button><img src="./img/head1.png" /><button onclick="head2()">Next</button>
          </div>
          <div id="body">
          <button onclick="body3()">Prev</button><img src="./img/body1.png" /><button onclick="body2()">Next</button>
          </div>
          <div id="legs">
          <button onclick="legs3()">Prev</button><img src="./img/legs1.png" /><button onclick="legs2()">Next</button>
          </div>
  `;
}

function head1() {
  document.getElementById("head").innerHTML = /*html*/ `
  <button onclick="head3()">Prev</button><img src="./img/head1.png" /><button onclick="head2()">Next</button>
  `;
}

function head2() {
  document.getElementById("head").innerHTML = /*html*/ `
  <button onclick="head1()">Prev</button><img src="./img/head2.png" /><button onclick="head3()">Next</button>

  `;
}

function head3() {
  document.getElementById("head").innerHTML = /*html*/ `
  <button onclick="head2()">Prev</button><img src="./img/head3.png" /><button onclick="head1()">Next</button>

  `;
}

function body1() {
  document.getElementById("body").innerHTML = /*html*/ `
  <button onclick="body3()">Prev</button><img src="./img/body1.png" /><button onclick="body2()">Next</button>
  `;
}

function body2() {
  document.getElementById("body").innerHTML = /*html*/ `
  <button onclick="body1()">Prev</button><img src="./img/body2.png" /><button onclick="body3()">Next</button>
  `;
}

function body3() {
  document.getElementById("body").innerHTML = /*html*/ `
  <button onclick="body2()">Prev</button><img src="./img/body3.png" /><button onclick="body1()">Next</button>
  `;
}

function legs1() {
  document.getElementById("legs").innerHTML = /*html*/ `
  <button onclick="legs3()">Prev</button><img src="./img/legs1.png" /><button onclick="legs2()">Next</button>
  `;
}

function legs2() {
  document.getElementById("legs").innerHTML = /*html*/ `
  <button onclick="legs1()">Prev</button><img src="./img/legs2.png" /><button onclick="legs3()">Next</button>
  `;
}

function legs3() {
  document.getElementById("legs").innerHTML = /*html*/ `
  <button onclick="legs2()">Prev</button><img src="./img/legs3.png" /><button onclick="legs1()">Next</button>
  `;
}
