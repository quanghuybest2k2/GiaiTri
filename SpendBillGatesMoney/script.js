const remainingBudget = document.querySelector(".remaining");

let budget = 100_000_000_000;

remainingBudget.textContent = `$${budget.toLocaleString()}`;

const buyButtons = document.querySelectorAll(".buy-item");
const sellButtons = document.querySelectorAll(".sell-item");

buyButtons.forEach((button) => {
  button.addEventListener("click", () => {
    const itemPrice = parseInt(
      button.previousElementSibling.textContent.replace(/\$|,/g, "")
    );
    if (budget >= itemPrice) {
      budget -= itemPrice;
      remainingBudget.textContent = `$${budget.toLocaleString()}`;
    } else {
      button.classList.add("disabled");
    }
  });
});
sellButtons.forEach((button) => {
  button.addEventListener("click", () => {
    const itemPrice = parseInt(
      button.previousElementSibling.previousElementSibling.textContent.replace(
        /\$|,/g,
        ""
      )
    );
    if (budget < 100_000_000_000) {
      budget += itemPrice;
      remainingBudget.textContent = `$${budget.toLocaleString()}`;
      button.classList.remove("disabled");
    } else {
      button.classList.add("disabled");
    }
  });
});
