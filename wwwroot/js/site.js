// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//evento

const ctx = document.getElementById('myChart');
new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
        datasets: [{
            label: ' Salário',
            data: [1500, 1500, 2500, 2000, 2000, 2000, 2000, 2600, 3200, 3200, 4200, 4200],
            borderWidth: 1,
            borderColor: '#f8f9fc',
            tension: 0.1,
            backgroundColor: '#f8f9fc',
        }]
    },
    Option: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

//Função
