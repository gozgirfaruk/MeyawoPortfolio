//GRAFICO 1  
const ctx1 = document.getElementById('canvas1');

new Chart(ctx1, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});

//----------------GRAFICO 2

const ctx2 = document.getElementById('canvas2');

new Chart(ctx2, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


//----------------GRAFICO 3

const ctx3 = document.getElementById('canvas3');

new Chart(ctx3, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


//----------------GRAFICO 4

const ctx4 = document.getElementById('canvas4');

new Chart(ctx4, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


//----------------GRAFICO 5

const ctx5 = document.getElementById('canvas5');

new Chart(ctx5, {
    type: 'line',
    data: {
        labels: ['01', '02', '03', '04', '05', '06'],
        datasets: [{
            label: 'Enero',
            data: [1, 19, 3, 5, 2, 3],
            borderWidth: 1,
            fill: true,
            backgroundColor: '#2f93a270',
            tension: 0.3,
        },
        {
            label: 'Febrero',
            data: [10, 5, 11, 6, 9, 2],
            borderWidth: 1,
            fill: true,
            backgroundColor: '#04318b6e',
            tension: 0.5,
        },
        {
            label: 'Abril',
            data: [5, 15, 6, 10, 7, 17],
            borderWidth: 1,
            fill: true,
            tension: 0.3,
            backgroundColor: '#2bd47d6e',
        }]
    },
    options: {
        maintainAspectRatio: false,

        scales: {
            y: {
                display: false,
                beginAtZero: true,
                grid: {
                    display: false,
                }
            }
        }
        ,
    },

});



//----------------GRAFICO 6

const ctx6 = document.getElementById('canvas6');

new Chart(ctx6, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});



//----------------GRAFICO 7

const ctx7 = document.getElementById('canvas7');

new Chart(ctx7, {
    type: 'doughnut',
    data: {
        labels: ['Julio', 'Vero', 'Antonio'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3],
            borderWidth: 1,
            backgroundColor: ['#2f93a270', '#04318b6e', '#2bd47d6e'],
        }]
    },
    options: {
        responsive: true,
        plugins: {
            legend: {
                display: true,
                position: 'top',
            },
            title: {
                display: false,
                text: 'Chart.js Doughnut Chart'
            }
        }
    },
});







//----------------GRAFICO 8

const ctx8 = document.getElementById('canvas8');

new Chart(ctx8, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});


//----------------GRAFICO 8

const ctx9 = document.getElementById('canvas9');

new Chart(ctx9, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});



//----------------GRAFICO 10

const ctx10 = document.getElementById('canvas10');

new Chart(ctx10, {
    type: 'bar',
    data: {
        labels: ['Julio', 'Vero', 'Antonio', 'Guido', 'Lorena', 'Pedro'],
        datasets: [{
            label: 'Ganancias por persona',
            data: [12, 19, 3, 5, 2, 3],
            borderWidth: 1
        }]
    },
    options: {
        maintainAspectRatio: false,
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});



