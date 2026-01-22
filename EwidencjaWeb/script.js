let vehicles = [];
let editIndex = null; 

const vehicleModal = new bootstrap.Modal(document.getElementById('vehicleModal'));
const deleteModal = new bootstrap.Modal(document.getElementById('deleteModal'));
const vehicleForm = document.getElementById('vehicleForm');

vehicleForm.addEventListener('submit', function(e) {
    e.preventDefault();
    
    if (!this.checkValidity()) {
        e.stopPropagation();
        this.classList.add('was-validated');
        return;
    }

    const vehicleData = {
        reg: document.getElementById('regInput').value,
        brand: document.getElementById('brandInput').value,
        model: document.getElementById('modelInput').value,
        year: document.getElementById('yearInput').value,
        date: document.getElementById('dateInput').value,
        owner: document.getElementById('ownerInput').value
    };

    if (editIndex === null) {
        vehicles.push(vehicleData);
        showAlert('Pojazd został dodany pomyślnie!', 'success');
    } else {
        vehicles[editIndex] = vehicleData;
        showAlert('Dane pojazdu zostały zaktualizowane!', 'info');
        editIndex = null; 
    }

    renderTable();
    this.reset();
    this.classList.remove('was-validated');
    vehicleModal.hide();
});

function prepareEdit(index) {
    editIndex = index;
    const v = vehicles[index];

    document.getElementById('regInput').value = v.reg;
    document.getElementById('brandInput').value = v.brand;
    document.getElementById('modelInput').value = v.model;
    document.getElementById('yearInput').value = v.year;
    document.getElementById('dateInput').value = v.date;
    document.getElementById('ownerInput').value = v.owner;

    document.querySelector('.modal-title').innerText = "Edytuj pojazd";
    vehicleModal.show();
}

document.querySelector('[data-bs-target="#vehicleModal"]').addEventListener('click', () => {
    editIndex = null;
    vehicleForm.reset();
    document.querySelector('.modal-title').innerText = "Dane pojazdu";
    vehicleForm.classList.remove('was-validated');
});

function renderTable() {
    const tbody = document.getElementById('vehicleTable');
    tbody.innerHTML = '';
    vehicles.forEach((v, index) => {
        tbody.innerHTML += `
            <tr>
                <td>${v.reg}</td>
                <td>${v.brand}</td>
                <td>${v.model}</td>
                <td>${v.year}</td>
                <td>${v.date}</td>
                <td>${v.owner}</td>
                <td>
                    <button class="btn btn-sm btn-warning" onclick="prepareEdit(${index})">Edytuj</button>
                    <button class="btn btn-sm btn-danger" onclick="prepareDelete(${index})">Usuń</button>
                </td>
            </tr>
        `;
    });
}

function showAlert(message, type) {
    const placeholder = document.getElementById('alertPlaceholder');
    placeholder.innerHTML = `
        <div class="alert alert-${type} alert-dismissible fade show">
            ${message}
            <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
        </div>
    `;
}

let deleteIndex = null;
function prepareDelete(index) {
    deleteIndex = index;
    deleteModal.show();
}

document.getElementById('confirmDeleteBtn').addEventListener('click', () => {
    vehicles.splice(deleteIndex, 1);
    renderTable();
    deleteModal.hide();
    showAlert('Pojazd został usunięty.', 'warning');
});

document.getElementById('ownerInput').addEventListener('input', function (e) {
    this.value = this.value.replace(/[0-9]/g, '');
});