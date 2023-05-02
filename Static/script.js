const remainingBudget = document.querySelector('.remaining');
const items = document.querySelectorAll('.buy-item, .sell-item');
let budget = 100000000000;

remainingBudget.textContent = `$${budget.toLocaleString()}`;

items.forEach(item => {
    const price = parseInt(item.previousElementSibling.textContent.replace(/\D/g, ''));
    const isBuyItem = item.classList.contains('buy-item');
    const isSellItem = item.classList.contains('sell-item');

    if (isBuyItem) {
        item.addEventListener('click', () => {
            if (budget >= price) {
                budget -= price;
                remainingBudget.textContent = `$${budget.toLocaleString()}`;
                item.parentElement.classList.add('disabled');
                item.disabled = true;
            }
        });
    }

    if (isSellItem) {
        item.addEventListener('click', () => {
            budget += price;
            remainingBudget.textContent = `$${budget.toLocaleString()}`;
            item.parentElement.classList.remove('disabled');
            item.previousElementSibling.disabled = false;
        });
    }
});
