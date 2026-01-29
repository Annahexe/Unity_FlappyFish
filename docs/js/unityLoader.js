// js/unity-loader.js
document.addEventListener("DOMContentLoaded", () => {
  const canvas = document.querySelector("#unity-canvas");

  function unityShowBanner(msg, type) {
    const warningBanner = document.querySelector("#unity-warning");

    function updateBannerVisibility() {
      warningBanner.style.display = warningBanner.children.length ? "block" : "none";
    }

    const div = document.createElement("div");
    div.innerHTML = msg;
    warningBanner.appendChild(div);

    if (type === "error") div.style = "background: red; padding: 10px;";
    else {
      if (type === "warning") div.style = "background: yellow; padding: 10px;";
      setTimeout(() => {
        warningBanner.removeChild(div);
        updateBannerVisibility();
      }, 5000);
    }
    updateBannerVisibility();
  }

  const buildUrl = "Build";
  const loaderUrl = `${buildUrl}/WebBuild.loader.js`;

  const config = {
    arguments: [],
    dataUrl: `${buildUrl}/WebBuild.data`,
    frameworkUrl: `${buildUrl}/WebBuild.framework.js`,
    codeUrl: `${buildUrl}/WebBuild.wasm`,
    streamingAssetsUrl: "StreamingAssets",
    companyName: "AnnamariaMarino",
    productName: "FlappyFish",
    productVersion: "1.0",
    showBanner: unityShowBanner,
  };

  // Mobile handling (same behavior you had)
  if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)) {
    const meta = document.createElement("meta");
    meta.name = "viewport";
    meta.content =
      "width=device-width, height=device-height, initial-scale=1.0, user-scalable=no, shrink-to-fit=yes";
    document.head.appendChild(meta);

    document.querySelector("#unity-container").className = "unity-mobile";
    canvas.className = "unity-mobile";
  } else {
    canvas.style.width = "100%";
    canvas.style.height = "100%";
    config.devicePixelRatio = Math.min(2, window.devicePixelRatio || 1);
  }

  canvas.style.background = `url('${buildUrl}/WebBuild.jpg') center / cover`;
  document.querySelector("#unity-loading-bar").style.display = "block";

  const script = document.createElement("script");
  script.src = loaderUrl;

  script.onload = () => {
    createUnityInstance(canvas, config, (progress) => {
      document.querySelector("#unity-progress-bar-full").style.width = `${100 * progress}%`;
    })
      .then(() => {
        document.querySelector("#unity-loading-bar").style.display = "none";
      })
      .catch((message) => alert(message));
  };

  document.body.appendChild(script);
});
